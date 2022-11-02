using System;
using MediatR;
using MediatR.Pipeline;

namespace Test.Cqrs.WebApi.Models.Behaviors
{
    public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<AppLoggingBehaviour<TRequest, TResponse>> _logger;

        public GenericRequestPostProcessor(ILogger<AppLoggingBehaviour<TRequest, TResponse>> logger)
        {
            _logger = logger;
        }

        public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
             _logger.LogInformation("- All Done");
        }
    }
}
