using AITech.DataAccess.Context;
using AITech.DataAccess.Interceptors;
using AITech.DataAccess.Repositories.AboutItemRepositories;
using AITech.DataAccess.Repositories.AboutRepositories;
using AITech.DataAccess.Repositories.BannerRepositories;
using AITech.DataAccess.Repositories.CategoryRepositories;
using AITech.DataAccess.Repositories.ChooseRepositories;
using AITech.DataAccess.Repositories.FaqRepositories;
using AITech.DataAccess.Repositories.FeatureRepositories;
using AITech.DataAccess.Repositories.ProjectRepositories;
using AITech.DataAccess.Repositories.SocialRepositories;
using AITech.DataAccess.Repositories.TestimonialRepositories;
using AITech.DataAccess.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.DataAccess.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IBannerRepository, BannerRepository>();
            services.AddScoped<IAboutRepository, AboutRepository>();
            services.AddScoped<IAboutItemRepository, AboutItemRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<IFaqRepository, FaqRepository>();
            services.AddScoped<ISocialRepository, SocialRepository>();
            services.AddScoped<IChooseRepository, ChooseRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
        }
    }
}
