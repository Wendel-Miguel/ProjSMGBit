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
using Pomelo.EntityFrameworkCore.MySql;

namespace ProjSMGBit.Application.DI
{
    public class Initializer
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<AppDbContext> (options => options.UseMySql(connection,
                     Microsoft.EntityFrameworkCore.ServerVersion.AutoDetect(connection)));

            services.AddScoped(typeof(IRepository<Travel>), typeof(TravelRepository));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddScopped(typeof (TravelService));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}