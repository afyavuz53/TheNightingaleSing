using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.DAL.Concrete.EntityTypeConfiguration
{
    class GenreMapping : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre");
            builder.HasKey(g => g.ID);
            builder.Property(g => g.ID).UseIdentityAlwaysColumn();
            builder.Property(g => g.Name).HasMaxLength(100).IsRequired();
            builder.Property(g => g.Description).HasMaxLength(500).IsRequired();
        }
    }
}
