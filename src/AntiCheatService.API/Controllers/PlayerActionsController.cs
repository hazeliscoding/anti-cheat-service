using AntiCheatService.Application.Commands.RecordPlayerAction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AntiCheatService.API.Controllers;

/// <summary>
/// Controller for handling player actions.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PlayerActionsController : ControllerBase
{
    private readonly IMediator _mediator;

    /// <summary>
    /// Initializes a new instance of the <see cref="PlayerActionsController"/> class.
    /// </summary>
    /// <param name="mediator">The mediator.</param>
    public PlayerActionsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Records a new player action.
    /// </summary>
    /// <param name="command">The command containing the action details.</param>
    /// <returns>An asynchronous operation.</returns>
    [HttpPost]
    public async Task<IActionResult> RecordAction([FromBody] RecordPlayerActionCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}