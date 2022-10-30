using System;
using Microsoft.AspNetCore.Mvc;
using Test.Cqrs.WebApi.Contracts.Handlers;
using Test.Cqrs.WebApi.Models.Requests;

namespace Test.Cqrs.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IAddPostCommandHandler _addPostCommandHandler;
        private readonly IGetPostQueryHandler _getPostQueryHandler;

        public PostController(IAddPostCommandHandler addPostCommandHandler, IGetPostQueryHandler getPostQueryHandler)
        {
            _addPostCommandHandler = addPostCommandHandler;
            _getPostQueryHandler = getPostQueryHandler;
        }

        [HttpGet(Name = "postDetails")]
        public IActionResult Get([FromQuery] GetPostRequestModel request)
        {
            var response = _getPostQueryHandler.GetPost(request);
            return Ok(response);
        }

        [HttpPost(Name = "addPost")]
        public IActionResult Post([FromBody] AddPostRequestModel request)
        {
            var response = _addPostCommandHandler.AddPost(request);
            return Ok(response);
        }
    }
}
