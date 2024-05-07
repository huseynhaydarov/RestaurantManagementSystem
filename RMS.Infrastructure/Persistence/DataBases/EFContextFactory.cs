using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.DataBases;

public class EFContextFactory : IDesignTimeDbContextFactory<EFContext>
{
    public EFContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<EFContext>();
        optionBuilder.UseNpgsql("Host=localhost;Port=5433;Database=RMS;Username=postgres;Password=7878_Postgresql");
        return new EFContext(optionBuilder.Options);
    }
}
