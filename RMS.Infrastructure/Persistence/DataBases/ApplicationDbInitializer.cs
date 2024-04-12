using Microsoft.EntityFrameworkCore;
using RMS.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Infrastructure.Persistence.DataBases
{
    public class ApplicationDbIntializer : IApplicationDbInitializer
    {
        private readonly ApplicationDbContext _context;

        public ApplicationDbIntializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            if (_context.Database.IsRelational())
                _context.Database.Migrate();
        }
    }
}