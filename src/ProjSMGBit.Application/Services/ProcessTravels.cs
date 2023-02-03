using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConvertCsvToJson;
using ProjSMGBit.Domain.Models;

namespace ProjSMGBit.Application.Services
{
    public class ProcessTravels
    {
        public IList<Travel> Travels { get; private set; }

        public ProcessTravels(string csvPath)
        {
            var travelsJson = ConvertCsvFileToJsonObject(csvPath);

            try
            {
                Travels = JsonConvert.DeserializeObject<IList<Travel>>(travelsJson);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}