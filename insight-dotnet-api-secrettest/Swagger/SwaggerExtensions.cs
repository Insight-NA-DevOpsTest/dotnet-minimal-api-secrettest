using Microsoft.OpenApi.Models;

namespace insight_dotnet_api_secrettest.Swagger

{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwaggerWithAuthentication(this IServiceCollection services, IConfiguration config, ILogger logger)
        {

            services.AddSwaggerGen(options =>
            {



            });

            return services;
        }

        // Insert Swagger & its UI into the pipeline, prefill some auth info and title.
        public static WebApplication UseSwaggerWithOptions(this WebApplication app, IConfiguration config)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.DocumentTitle = "insight_dotnet_api_secrettest Swagger UI";

            });
            return app;
        }

    }
}