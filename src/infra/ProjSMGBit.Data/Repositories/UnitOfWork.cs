using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Interfaces;
using ProjSMGBit.Data.Context;

namespace ProjSMGBit.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork (AppDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}