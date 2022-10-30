using MediatR;
using Microsoft.AspNetCore.Mvc;
using Test.Cqrs.WebApi.Models.Requests;

namespace Test.Cqrs.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "postDetails")]
        public IActionResult Get([FromQuery] GetPostRequestModel request)
        {
            var response = _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost(Name = "addPost")]
        public IActionResult Post([FromBody] AddPostRequestModel request)
        {
            var response = _mediator.Send(request);
            return Ok(response);
        }
    }
}
