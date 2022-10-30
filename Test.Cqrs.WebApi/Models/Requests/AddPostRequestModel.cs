using System;

namespace Test.Cqrs.WebApi.Models.Requests
{
    public class AddPostRequestModel
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
    }
}
