using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace WebClient.DTOs
{
    public class BaseDTO
    {
        private int _id = 0;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _createdDate = (DateTime)SqlDateTime.MinValue;

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        private DateTime _modifiedDate = (DateTime)SqlDateTime.MinValue;

        public DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set { _modifiedDate = value; }
        }
    }
}