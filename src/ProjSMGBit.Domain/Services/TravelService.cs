using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Models;
using ProjSMGBit.Domain.Interfaces;

namespace ProjSMGBit.Domain.Services
{
    public class TravelService
    {
        private readonly IRepository<Travel> _travelRepository;

        public TravelService(IRepository<Travel> travelRepository)
        {
            _travelRepository = travelRepository;
        }
    }
}