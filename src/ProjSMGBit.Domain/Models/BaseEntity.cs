using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjSMGBit.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }
    }
}