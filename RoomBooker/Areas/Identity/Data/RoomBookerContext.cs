﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RoomBooker.Areas.Identity.Data;

namespace RoomBooker.Areas.Identity.Data;

public class RoomBookerContext : IdentityDbContext<RoomBookerUser>
{
    public RoomBookerContext(DbContextOptions<RoomBookerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<RoomBookerUser>
{
    public void Configure(EntityTypeBuilder<RoomBookerUser> builder)
    {
        builder.Property(u => u.Email).HasMaxLength(256).IsRequired();
        builder.Property(x => x.Password).IsRequired();
    }
}
