namespace AntiCheatService.Application.Commands.RecordPlayerAction;

using MediatR;
using System;

/// <summary>
/// Command to record a player action.
/// </summary>
public class RecordPlayerActionCommand : IRequest
{
    /// <summary>
    /// Gets or sets the player's unique identifier.
    /// </summary>
    public string PlayerId { get; set; }

    /// <summary>
    /// Gets or sets the type of action.
    /// </summary>
    public string ActionType { get; set; }

    /// <summary>
    /// Gets or sets the timestamp of the action.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Gets or sets additional data related to the action.
    /// </summary>
    public string Data { get; set; }
}