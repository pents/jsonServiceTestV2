using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSONserviceV2.Models;
using JSONserviceV2.Services;
using Microsoft.AspNetCore.Mvc;

namespace JSONserviceV2.Controllers
{
    [Route("v2/")]
    [ApiController]
    public class ServiceController : Controller
    {
        private IDataService _dataService;

        public ServiceController(IDataService dataService)
        { 
            _dataService = dataService;
        }

        [HttpPost]
        [Route("SendServer")]
        public ActionResult PostData(SendData data)
        {
            return _dataService.SendData(data);
        }

        [HttpGet]
        [Route("GetRespond")]
        public ActionResult<Dictionary<DateTime, int>> GetRespond()
        {
            return _dataService.RespondData();
        }

    }
}