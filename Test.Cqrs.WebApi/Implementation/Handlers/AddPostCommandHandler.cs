using System;
using Test.Cqrs.WebApi.Contracts.Handlers;
using Test.Cqrs.WebApi.Models.Requests;
using Test.Cqrs.WebApi.Models.Responses;

namespace Test.Cqrs.WebApi.Implementation.Handlers
{
    public class AddPostCommandHandler : IAddPostCommandHandler
    {
        public AddPostResponseModel AddPost(AddPostRequestModel request)
        {
            // your logic add post...
            
            return new AddPostResponseModel()
            {
                PostId = Guid.NewGuid()
            };
        }
    }
}
