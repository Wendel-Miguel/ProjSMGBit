using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Interfaces;
using ProjSMGBit.Domain.Models;
using ProjSMGBit.Data.Context;

namespace ProjSMGBit.Data.Repositories
{
    public class TravelRepository : Repository<Travel>
    {
        public TravelRepository(AppDbContext context) : base(context)
        {}

        public override Travel GetById(int id)
        {
            var query = _context.Set<Travel>().Where(e => e.TravelId == id);

            if(query.Any())
                return query.FirstOrDefault();

            return null;
        }

        public override IEnumerable<Travel> GetAll()
        {
            var query = _context.Set<Travel>();

            return query.Any() ? query.ToList() : new List<Travel>();
        }

        public override void Save(Travel entity)
        {
            base.Save(entity);
        }
    }
}