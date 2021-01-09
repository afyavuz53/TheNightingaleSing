using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TheNightingalesSing.Model.Entities;

namespace TheNightingalesSing.DAL.Concrete.EntityTypeConfiguration
{
    class OrderDetailMapping : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(od => new { od.AlbumID, od.OrderID });
            builder.Property(od => od.Price).HasPrecision(5, 2);
        }
    }
}
