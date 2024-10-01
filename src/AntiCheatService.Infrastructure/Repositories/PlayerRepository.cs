using System.Collections.Concurrent;
using AntiCheatService.Application.Interfaces;
using AntiCheatService.Domain.Aggregates;

namespace AntiCheatService.Infrastructure.Repositories;

/// <summary>
/// In-memory implementation of the player repository.
/// </summary>
public class PlayerRepository : IPlayerRepository
{
    private readonly ConcurrentDictionary<string, Player> _players = new();

    /// <inheritdoc/>
    public Task<Player?> GetByIdAsync(string playerId)
    {
        _players.TryGetValue(playerId, out var player);
        return Task.FromResult(player);
    }

    /// <inheritdoc/>
    public Task AddAsync(Player player)
    {
        _players.TryAdd(player.Id, player);
        return Task.CompletedTask;
    }

    /// <inheritdoc/>
    public Task UpdateAsync(Player player)
    {
        _players[player.Id] = player;
        return Task.CompletedTask;
    }
}