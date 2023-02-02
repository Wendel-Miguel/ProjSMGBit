using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Enums;

namespace ProjSMGBit.Domain.Models
{
    public class Travel : BaseEntity
    {
        public DateTime TravelDate { get; private set; }

        public int TravelId { get; private set; }

        public string Driver { get; private set;} = string.Empty;

        public string Plate { get; private set; } = string.Empty;

        public TruckType VehicleType { get; private set; }

        public Operation Origin { get; private set; }

        public string Destination { get; private set; } = string.Empty;

        public int LoadedBoxes { get; private set; }

        public int Deliveries { get; private set; }

        public int Mileage { get; private set; }

        public TravelType Type { get; private set; }

        public double Price { get; private set; }
    }
}