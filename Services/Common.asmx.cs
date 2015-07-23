using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using WebClient.Services.Managers;

namespace WebClient.Services
{
    /// <summary>
    /// Summary description for Common
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Common : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Call(string CatalogName, string JsonString)
        {
            string result = JsonConvert.SerializeObject(string.Empty);

            var client = new Client();

            switch(CatalogName)
            {
                case "InsertPeopleService":
                    client.Manager = new PeopleInsertManager();
                    result = client.POST(CatalogName, JsonString);
                    break;
            }

            return result;
        }
    }
}
