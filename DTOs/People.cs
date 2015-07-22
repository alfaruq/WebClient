using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.DTOs
{
    public class People : BaseDTO
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