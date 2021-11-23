using ApiProject.Data.Abstract;
using ApiProject.Data.Concrete;
using ApiProject.Data.Concrete.EntityFramework.Contexts;
using ApiProject.Services.Abstract;
using ApiProject.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApiProjectContext>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>(); // biri senden IunitOfWork isterse sen ona UnitOfWork ver
            serviceCollection.AddScoped<IPhotoService, PhotoManager>();
            return serviceCollection;
        }
    }
}
