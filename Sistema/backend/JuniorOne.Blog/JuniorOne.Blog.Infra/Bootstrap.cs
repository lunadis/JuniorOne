using JuniorOne.Blog.Aplication.Aplication;
using JuniorOne.Blog.Aplication.Interface;
using JuniorOne.Blog.data;
using JuniorOne.Blog.Data.Repositories;
using JuniorOne.Blog.Domain.Interfaces;
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

            service.AddScoped(typeof(IRepositorieBase<>), typeof(RepositoriesBase<>));
            service.AddScoped<ICategoryRepositorie, CantegoryRepositories>();
            service.AddScoped<IPostsCategoriesRepositories, PostsCategoriesRepositories>();
            service.AddScoped<IPostRepositories, PostRepositories>();
            service.AddScoped<IPostsTagsReporitoires, PostsTagsRepositories>();
            service.AddScoped<ITagRepositorie, TagRepositories>();
            service.AddScoped<IUserRepositorie, UserRepositores>();

            service.AddScoped<ICategoryAplication, CategoryAplication>();
            service.AddScoped<IPostsCategoriesAplication, PostsCategoriesAplication>();
            service.AddScoped<IPostAplication, PostAplication>();
            service.AddScoped<IPostsTagsAplication, PostsTagsAplication>();
            service.AddScoped<ITagsAplication, TagsAplication>();
            service.AddScoped<IUserAplication, UserAplication>();
        }
    }
}