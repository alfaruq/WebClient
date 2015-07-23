using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebClient.ServiceCaller;
using WebClient.ServiceModels.PeopleServices;

namespace WebClient.Services.Managers
{
    public class PeopleInsertManager : IExecute
    {
        public string Execute(string ServiceUri, string JsonString)
        {
            var objJson = JsonConvert.DeserializeObject<InsertPeople>(JsonString);

            return Caller.CallPOSTWebService(ServiceUri, objJson);
        }
    }
}