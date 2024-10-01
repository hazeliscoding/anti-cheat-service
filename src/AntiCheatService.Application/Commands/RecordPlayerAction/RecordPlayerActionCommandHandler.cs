using AntiCheatService.Application.Interfaces;
using AntiCheatService.Domain.Aggregates;
using AntiCheatService.Domain.Entities;
using AntiCheatService.Domain.Enums;
using MediatR;

namespace AntiCheatService.Application.Commands.RecordPlayerAction;

/// <summary>
/// Handles the <see cref="RecordPlayerActionCommand"/>.
/// </summary>
public class RecordPlayerActionCommandHandler : IRequestHandler<RecordPlayerActionCommand>
{
    private readonly IPlayerRepository _playerRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordPlayerActionCommandHandler"/> class.
    /// </summary>
    /// <param name="playerRepository">The player repository.</param>
    public RecordPlayerActionCommandHandler(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    /// <inheritdoc/>
    public async Task Handle(RecordPlayerActionCommand request, CancellationToken cancellationToken)
    {
        var player = await _playerRepository.GetByIdAsync(request.PlayerId);

        if (player == null)
        {
            player = new Player(request.PlayerId);
            await _playerRepository.AddAsync(player);
        }

        if (!Enum.TryParse(request.ActionType, out ActionType actionType))
        {
            throw new ArgumentException("Invalid action type.");
        }

        var playerAction = new PlayerAction(actionType, request.Timestamp, request.Data);

        player.RecordAction(playerAction);

        await _playerRepository.UpdateAsync(player);
    }
}