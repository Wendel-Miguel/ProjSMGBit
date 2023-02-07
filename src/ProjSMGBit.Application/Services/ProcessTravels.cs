using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Models;
using ProjSMGBit.Application.Mapping;
using CsvHelper;

namespace ProjSMGBit.Application.Services
{
    public class ProcessTravels
    {
        public IEnumerable<Travel> Travels { get; private set; }

        public ProcessTravels(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<TravelMap>();
                Travels = csv.GetRecords<Travel>().ToList();
            }
        }
    }
}