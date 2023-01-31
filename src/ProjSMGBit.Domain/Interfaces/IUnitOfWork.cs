using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjSMGBit.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}