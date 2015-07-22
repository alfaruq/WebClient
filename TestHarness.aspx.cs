using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.DTOs;
using WebClient.ServiceModels.PeopleServices;

namespace WebClient
{
    public partial class TestHarness : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {            
            var insertPeoplePrm = new InsertPeople();

            int age = 0;
            int.TryParse(txtAge.Text.Trim(), out age);

            insertPeoplePrm.FullName = txtFullName.Text.Trim();
            insertPeoplePrm.Age = age;

            var jsonResult = ServiceCaller.Caller.CallPOSTWebService("InsertPeopleService", insertPeoplePrm);

            txtResult.Text += jsonResult + System.Environment.NewLine;

            var obj = JsonConvert.DeserializeObject<People>(jsonResult);
        }
    }
}