using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.BLL.Abstract;
using TheNightingalesSing.DAL.Concrete.DependencyInjection;

namespace TheNightingalesSing.BLL.Concrete.DependecyInjection
{
    public static class EfContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDAL();
            services.AddScoped<IAlbumBLL, AlbumService>();
            services.AddScoped<IArtistBLL, ArtistService>();
            services.AddScoped<IGenreBLL, GenreService>();
            services.AddScoped<IOrderBLL, OrderService>();
            services.AddScoped<IUserBLL, UserService>();
        }
    }
}
