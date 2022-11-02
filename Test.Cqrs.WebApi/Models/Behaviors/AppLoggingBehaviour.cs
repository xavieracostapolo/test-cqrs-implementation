using System.Diagnostics;
using MediatR;

namespace Test.Cqrs.WebApi.Models.Behaviors
{
    public class AppLoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<AppLoggingBehaviour<TRequest, TResponse>> _logger;

        public AppLoggingBehaviour(ILogger<AppLoggingBehaviour<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }


        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            string requestName = typeof(TRequest).Name;
            string unqiueId = Guid.NewGuid().ToString();
            _logger.LogInformation($"Begin Request Id:{unqiueId}, request name:{requestName}");
            var timer = new Stopwatch();
            timer.Start();
            var response = await next();
            timer.Stop();
            _logger.LogInformation($"End Request Id:{unqiueId}, request name:{requestName}, total request time:{timer.ElapsedMilliseconds}");
            return response;
        }
    }
}
