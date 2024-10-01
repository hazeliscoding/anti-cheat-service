using AntiCheatService.Domain.Aggregates;
using AntiCheatService.Domain.Entities;

namespace AntiCheatService.Domain.Events;

/// <summary>
/// Event raised when a player action is recorded.
/// </summary>
public class PlayerActionRecordedEvent
{
    /// <summary>
    /// Gets the player associated with the event.
    /// </summary>
    public Player Player { get; }

    /// <summary>
    /// Gets the action that was recorded.
    /// </summary>
    public PlayerAction Action { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PlayerActionRecordedEvent"/> class.
    /// </summary>
    /// <param name="player">The player who performed the action.</param>
    /// <param name="action">The action that was recorded.</param>
    public PlayerActionRecordedEvent(Player player, PlayerAction action)
    {
        Player = player;
        Action = action;
    }
}