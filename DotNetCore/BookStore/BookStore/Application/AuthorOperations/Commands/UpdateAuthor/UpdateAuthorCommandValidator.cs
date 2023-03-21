using FluentValidation;

namespace BookStore.Application.AuthorOperations.UpdateAuthor
{
    public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorCommandValidator()
        {
            //RuleFor(command => command.Model.Name).MinimumLength(4).When(x => x.Model.Name != string.Empty);
            
            RuleFor(command=> command.Model.Name).NotEmpty().MinimumLength(4);
            RuleFor(command=> command.Model.Surname).NotEmpty().MinimumLength(4);

        }


    }
}
