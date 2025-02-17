using System.Net;
using VillaCoupon.API.Models;

namespace VillaCoupon.API.Filters
{
    public class ParameterIDValidator : IEndpointFilter
    {
        private ILogger<ParameterIDValidator> _logger;
        public ParameterIDValidator(ILogger<ParameterIDValidator> logger)
        {
            _logger = logger;
        }
        public async ValueTask<object> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            var id = context.Arguments.SingleOrDefault(x => x?.GetType() == typeof(int)) as int?;
            if (id == null || id == 0)
            {
                APIResponse response = new() { IsSuccess = false, StatusCode = HttpStatusCode.BadRequest };
                response.ErrorMessages.Add("Id cannot be zero.");
                _logger.Log(LogLevel.Error, "ID cannot be 0");
                return Results.BadRequest(response);
            }
            return await next(context);
        }
    }
}
