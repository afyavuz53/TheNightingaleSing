using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.DAL.Abstract;
using TheNightingalesSing.DAL.Concrete.Repository;

namespace TheNightingalesSing.DAL.Concrete.DependencyInjection
{
    public static class EfContextDAL
    {
        public static void AddScopeDAL(this IServiceCollection services)
        {
            services.AddScoped<IAlbumDAL, AlbumRepository>();
            services.AddScoped<IArtistDAL, ArtistRepository>();
            services.AddScoped<IGenreDAL, GenreRepository>();
            services.AddScoped<IOrderDAL, OrderRepository>();
            services.AddScoped<IUserDAL, UserRepository>();
        }
    }
}
