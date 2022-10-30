using System;
using Test.Cqrs.WebApi.Models.Requests;
using Test.Cqrs.WebApi.Models.Responses;

namespace Test.Cqrs.WebApi.Contracts.Handlers
{
    public interface IGetPostQueryHandler
    {
        GetPostResponseModel GetPost(GetPostRequestModel request);
    }
}
