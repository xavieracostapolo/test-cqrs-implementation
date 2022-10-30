using System;
using FluentValidation;

namespace Test.Cqrs.WebApi.Models.Requests
{
    public class GetPostQueryValidator : AbstractValidator<GetPostRequestModel>
    {
        public GetPostQueryValidator()
        {
            /*...*/

            RuleFor(x => x.PostId)
                .Must(ValidateGuid)
                .WithErrorCode("Not a guid");
            RuleFor(x => x.PostId).NotEmpty().WithErrorCode("001").WithMessage("No puede ser nulo");
        }

        private bool ValidateGuid(Guid arg)
        {
            return Guid.TryParse(arg.ToString(), out var result);
        }
    }
}
