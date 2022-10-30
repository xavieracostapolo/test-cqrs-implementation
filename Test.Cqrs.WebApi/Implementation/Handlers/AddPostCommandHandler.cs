using MediatR;
using Test.Cqrs.WebApi.Models.Requests;
using Test.Cqrs.WebApi.Models.Responses;

namespace Test.Cqrs.WebApi.Implementation.Handlers
{
    public class AddPostCommandHandler : IRequestHandler<AddPostRequestModel, AddPostResponseModel>
    {
        public async Task<AddPostResponseModel> Handle(AddPostRequestModel request, CancellationToken cancellationToken)
        {
            // your logic add post...
            
            return new AddPostResponseModel()
            {
                PostId = Guid.NewGuid()
            };
        }
    }
}
