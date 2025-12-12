namespace EShop.Presentation.MVC.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            /*Before*/
            var startTime = DateTime.Now;
            _logger.LogInformation($"**** Request Started --- {startTime} --- {context.Request.Path} ***");

            context.Response.Headers.Add("Name", "Salam");

            await _next(context);

            /*After*/
            var endTime = DateTime.Now;
            var duration = endTime - startTime;
            _logger.LogInformation($"**** Request Finished --- {endTime} --- with duration {duration} ms ***");
        }
    }
}
