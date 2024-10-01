namespace AntiCheatService.Domain.Entities;

using System;
using AntiCheatService.Domain.Enums;

/// <summary>
/// Represents an action performed by a player.
/// </summary>
public class PlayerAction
{
    /// <summary>
    /// Gets the type of action.
    /// </summary>
    public ActionType ActionType { get; private set; }

    /// <summary>
    /// Gets the timestamp when the action was performed.
    /// </summary>
    public DateTime Timestamp { get; private set; }

    /// <summary>
    /// Gets additional data related to the action.
    /// </summary>
    public string Data { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PlayerAction"/> class.
    /// </summary>
    /// <param name="actionType">The type of action.</param>
    /// <param name="timestamp">The timestamp when the action was performed.</param>
    /// <param name="data">Additional data related to the action.</param>
    public PlayerAction(ActionType actionType, DateTime timestamp, string data)
    {
        ActionType = actionType;
        Timestamp = timestamp;
        Data = data;
    }
}