using AntiCheatService.Domain.Entities;
using AntiCheatService.Domain.Events;

namespace AntiCheatService.Domain.Aggregates;

/// <summary>
/// Represents a player aggregate root.
/// </summary>
public class Player
{
    /// <summary>
    /// Gets the player's unique identifier.
    /// </summary>
    public string Id { get; private set; }

    /// <summary>
    /// Gets the collection of actions performed by the player.
    /// </summary>
    public List<PlayerAction> Actions { get; private set; }

    /// <summary>
    /// Gets the collection of detected anomalies.
    /// </summary>
    public List<string> Anomalies { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class.
    /// </summary>
    /// <param name="id">The unique identifier of the player.</param>
    public Player(string id)
    {
        Id = id;
        Actions = new List<PlayerAction>();
        Anomalies = new List<string>();
    }

    /// <summary>
    /// Records a new action performed by the player.
    /// </summary>
    /// <param name="action">The action to record.</param>
    public void RecordAction(PlayerAction action)
    {
        Actions.Add(action);

        // Raise domain event (can be used to notify other parts of the system)
        var @event = new PlayerActionRecordedEvent(this, action);
        // Event handling logic (omitted for brevity)

        // Detect anomalies based on custom business logic
        DetectAnomalies(action);
    }

    /// <summary>
    /// Detects anomalies in player actions.
    /// </summary>
    /// <param name="action">The latest action to consider.</param>
    private void DetectAnomalies(PlayerAction action)
    {
        // Example: Detect rapid-fire anomalies
        if (action.ActionType == Enums.ActionType.Shoot)
        {
            var recentShots = Actions.FindAll(a =>
                a.ActionType == Enums.ActionType.Shoot &&
                (action.Timestamp - a.Timestamp).TotalSeconds <= 1);

            if (recentShots.Count > 5)
            {
                Anomalies.Add($"Rapid fire detected at {action.Timestamp}");
            }
        }
        // Additional anomaly detection logic can be added here
    }
}