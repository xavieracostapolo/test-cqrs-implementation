using System;
using FluentValidation;

namespace Test.Cqrs.WebApi.Models.Requests
{
    public class AddPostCommandValidator : AbstractValidator<AddPostRequestModel>
    {
        public AddPostCommandValidator()
        {
            RuleFor(v => v.Title)
                .MaximumLength(200)
                .NotEmpty()
                .WithMessage("Title is empty.");

            /*...*/
        }
    }
}
