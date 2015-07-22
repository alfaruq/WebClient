using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.ServiceModels.PeopleServices
{
    /// <summary>
    /// The attributes similar to the parameters required to call the web service
    /// </summary>
    public class InsertPeople
    {
        private string _fullName = string.Empty;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private int _age = 0;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}