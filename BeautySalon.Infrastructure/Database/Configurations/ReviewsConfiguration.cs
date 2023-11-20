﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using BeautySalon.Infrastructure;
using BeautySalon.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

#nullable disable

namespace BeautySalon.Infrastructure.Database.Configurations
{
    public partial class ReviewsConfiguration : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> entity)
        {
            entity.HasKey(e => e.Id).HasName("PK__Reviews__3213E83F699345AD");

            entity.HasOne(d => d.Client).WithMany(p => p.Reviews)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__Reviews__client___5070F446");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Reviews> entity);
    }
}
