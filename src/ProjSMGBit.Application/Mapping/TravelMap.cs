using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Models;
using CsvHelper.Configuration;

namespace ProjSMGBit.Application.Mapping
{
    public sealed class TravelMap : ClassMap<Travel>
    {
        public TravelMap ()
        {
            Map(m => m.TravelDate).Name("Data Viagem");
            Map(m => m.Driver).Name("Motorista");
            Map(m => m.Plate).Name("Placa");
            Map(m => m.VehicleType).Name("Tipo de Veículo");
            Map(m => m.Origin).Name("Operação");
            Map(m => m.Destination).Name("Destino");
            Map(m => m.LoadedBoxes).Name("Caixas");
            Map(m => m.Deliveries).Name("Paradas");
            Map(m => m.Mileage).Name("Km Rodado");
            Map(m => m.Type).Name("Tipo de Viagem");
        }
    }
}