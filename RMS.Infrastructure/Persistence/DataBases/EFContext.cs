using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RMS.Domain.Abstract;
using RMS.Infrastructure.Persistence.TablesConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.DataBases;

public class EFContext : DbContext
{
    public EFContext(DbContextOptions<EFContext> options) : base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=RMS;Username=postgres;Password=7878_Postgresql");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Ignore<EntityBase>();
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MenuItemConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderItemConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OrderItemConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PaymentConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReservationConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReservationTableConfiguration).Assembly);

        modelBuilder.Entity<IdentityUser>().ToTable("Users");
        modelBuilder.Entity<IdentityRole>().ToTable("Roles").HasNoKey();
        modelBuilder.Entity<IdentityUserRole<string>>().ToTable("UserRoles").HasNoKey();
        modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims").HasNoKey();
        modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins").HasNoKey();
        modelBuilder.Entity<IdentityUserToken<string>>().ToTable("UserTokens").HasNoKey();
        modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims").HasNoKey();
    }
}
