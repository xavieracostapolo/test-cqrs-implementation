using System;
using MediatR;
using Test.Cqrs.WebApi.Models.Responses;

namespace Test.Cqrs.WebApi.Models.Requests
{
    public class AddPostRequestModel : IRequest<AddPostResponseModel>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
