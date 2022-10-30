using MediatR;
using Test.Cqrs.WebApi.Models.Requests;
using Test.Cqrs.WebApi.Models.Responses;

namespace Test.Cqrs.WebApi.Implementation.Handlers
{
    public class GetPostQueryHandler : IRequestHandler<GetPostRequestModel, GetPostResponseModel>
    {
        public async Task<GetPostResponseModel> Handle(GetPostRequestModel request, CancellationToken cancellationToken)
        {
            // your logic get post...

            return new GetPostResponseModel()
            {
                Body = "It is a long established fact that a reader will...",
                Id = Guid.Parse("556b8afa-5617-425c-87af-381f278ccf90"),
                Title = "What is Lorem Ipsum?",
                UserId = Guid.Parse("40cea88f-9cdb-4509-a8bd-a307d149daf0")
            };
        }
    }
}
