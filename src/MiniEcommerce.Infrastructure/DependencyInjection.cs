using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiniEcommerce.Application.Common.Interfaces.Repositories;
using MiniEcommerce.Infrastructure.Data.Contexts;
using MiniEcommerce.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniEcommerce.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IHostApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("MiniEcommerceDb");

            builder.Services.AddDbContext<MiniEcommerceDbContext>((sp, options) =>
            {
                options.UseNpgsql(connectionString);
                //options.UseSqlServer(connectionString);
            });

            builder.Services.AddScoped<IProductReadRepository, ProductReadRepository>();
            builder.Services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

        }
    }
}
