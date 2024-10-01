using AntiCheatService.Domain.Enums;
using FluentValidation;

namespace AntiCheatService.Application.Commands.RecordPlayerAction
{
    /// <summary>
    /// Validator for <see cref="RecordPlayerActionCommand"/>.
    /// </summary>
    public class RecordPlayerActionCommandValidator : AbstractValidator<RecordPlayerActionCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordPlayerActionCommandValidator"/> class.
        /// </summary>
        public RecordPlayerActionCommandValidator()
        {
            RuleFor(x => x.PlayerId)
                .NotEmpty().WithMessage("Player ID is required.");

            RuleFor(x => x.ActionType)
                .NotEmpty().WithMessage("Action type is required.")
                .Must(actionType => Enum.IsDefined(typeof(ActionType), actionType))
                .WithMessage("Invalid action type.");

            RuleFor(x => x.Timestamp)
                .NotEmpty().WithMessage("Timestamp is required.");

            // Additional validation rules can be added here.
        }
    }
}