using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjSMGBit.Domain.Interfaces;
using ProjSMGBit.Domain.Models;
using ProjSMGBit.Data.Context;
using ProjSMGBit.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ProjSMGBit.Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<AppDbContext> (options => options.UseMySql(connection));

            services.AddScopped(typeof(IRepository<Travel>), typeof(TravelRepository));
            services.AddScopped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScopped(typeof (TravelService));
            services.AddScopped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}