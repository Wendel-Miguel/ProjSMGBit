using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjSMGBit.Application.Services;
using ProjSMGBit.Domain.Models;

namespace ProjSMGBit.Web.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class TravelController : ControllerBase
    {
        private readonly ILogger<TravelController> _logger;

        public TravelController (ILogger<TravelController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{csvPath}")]
        [Route("StartProcessTravel")]
        public IEnumerable<Travel> StartProcessTravel(string csvPath)
        {
            _logger.LogInformation("[TravelController - StartProcessTravel] {0}", csvPath);
            ProcessTravels processTravels = new ProcessTravels(csvPath);
            return processTravels.Travels;
        }
    }
