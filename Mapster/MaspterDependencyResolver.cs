using FastExpressionCompiler;
using Mapster;
using MapsterMapper;

namespace NetCoreGraphQlLearn.Mapster
{
    public static class MapsterDependencyResolver
    {
        public static void AddCustomMapster(this IServiceCollection services)
        {
            var config = new TypeAdapterConfig();
            config.ListPlayerMapping();
            config.Compiler = exp => exp.CompileFast();
            config.Compile();
            services.AddSingleton(config);
            services.AddSingleton<IMapper, ServiceMapper>();
        }
    }
}
