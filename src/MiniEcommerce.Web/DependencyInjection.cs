using MiniEcommerce.Infrastructure.Data.Contexts;
using System.Collections.Generic;

namespace MiniEcommerce.Web
{
    public static class DependencyInjection
    {
        public static void AddWebServices(this IHostApplicationBuilder builder)
        {
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddEndpointsApiExplorer();
        }
    }
}
