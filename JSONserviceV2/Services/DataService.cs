using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSONserviceV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace JSONserviceV2.Services
{
    public class DataService : IDataService
    {
        private Dictionary<DateTime, int> _savedValues;

        public DataService()
        {
            _savedValues = new Dictionary<DateTime, int>();
        }

        public Dictionary<DateTime, int> RespondData()

        {
            return _savedValues;
        }

        public ActionResult SendData(SendData data)
        {
            if (_savedValues.ContainsKey(DateTime.Parse(DateTime.Now.ToString("g"))))
            {
                _savedValues[DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm"))] += data.Value;
            }
            else
            {
                _savedValues.Add(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm")), data.Value);
            }

            // send data to server
            return new OkResult();
        }
    }
}
