using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.DAL.Concrete.EntityTypeConfiguration
{
    class AlbumMapping : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album");
            builder.HasKey(a => a.ID);
            builder.Property(u => u.ID).UseIdentityAlwaysColumn();
            builder.Property(u => u.Title).HasMaxLength(100).IsRequired();
            builder.Property(u => u.ArtUrl).HasMaxLength(250);
            builder.Property(u => u.Price).HasPrecision(6, 2);
        }
    }
}
