using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSONserviceV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace JSONserviceV2.Services
{
    public interface IDataService
    {
        ActionResult SendData(SendData data);
        Dictionary<DateTime, int> RespondData();
    }
}
