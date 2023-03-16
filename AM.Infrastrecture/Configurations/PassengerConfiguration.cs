﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastrecture.Configurations
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.OwnsOne(p => p.FullName, f =>
            {
                f.Property(h => h.FirstName).IsRequired().HasMaxLength(30);
                f.Property(h => h.LastName).IsRequired().HasMaxLength(30).HasColumnName("lastname");

            });
            builder.HasDiscriminator<int>("type").HasValue<Passenger>(0).HasValue<Staff>(2).HasValue<Traveller>(5);
        }
    }
}
