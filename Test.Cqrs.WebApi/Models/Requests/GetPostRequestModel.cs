using System;
using MediatR;
using Test.Cqrs.WebApi.Models.Responses;

namespace Test.Cqrs.WebApi.Models.Requests
{
    public class GetPostRequestModel : IRequest<GetPostResponseModel>
    {
        public Guid PostId { get; set; }
    }
}
