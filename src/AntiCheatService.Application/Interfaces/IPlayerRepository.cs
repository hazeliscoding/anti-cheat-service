using AntiCheatService.Domain.Aggregates;

namespace AntiCheatService.Application.Interfaces;

/// <summary>
/// Defines the repository interface for players.
/// </summary>
public interface IPlayerRepository
{
    /// <summary>
    /// Gets a player by their unique identifier.
    /// </summary>
    /// <param name="playerId">The player's unique identifier.</param>
    /// <returns>The player aggregate.</returns>
    Task<Player?> GetByIdAsync(string playerId);

    /// <summary>
    /// Adds a new player.
    /// </summary>
    /// <param name="player">The player to add.</param>
    Task AddAsync(Player player);

    /// <summary>
    /// Updates an existing player.
    /// </summary>
    /// <param name="player">The player to update.</param>
    Task UpdateAsync(Player player);
}