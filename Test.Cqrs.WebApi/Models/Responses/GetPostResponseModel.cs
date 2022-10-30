using System;

namespace Test.Cqrs.WebApi.Models.Responses
{
    public class GetPostResponseModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
