namespace AntiCheatService.Domain.Interfaces;

using AntiCheatService.Domain.Aggregates;

/// <summary>
/// Interface for cheat detection services.
/// </summary>
public interface ICheatDetector
{
    /// <summary>
    /// Analyzes a player's actions to detect cheating.
    /// </summary>
    /// <param name="player">The player to analyze.</param>
    void Analyze(Player player);
}