using JuniorOne.Blog.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JuniorOne.Blog.Infra
{
    public class Bootstrap
    {
        public static void RegisterServices(IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<Contexto>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("MinhaConexao")));
        }
    }
}