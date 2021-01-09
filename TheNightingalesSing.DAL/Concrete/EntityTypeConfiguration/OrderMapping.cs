using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.DAL.Concrete.EntityTypeConfiguration
{
    class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID).UseIdentityAlwaysColumn();
            builder.Property(o => o.ShipAddress).HasMaxLength(250);
        }
    }
}
