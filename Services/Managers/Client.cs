using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClient.Services.Managers
{
    public class Client
    {
        private IExecute _execute;

        internal IExecute Manager
        {
            set
            {
                _execute = value;
            }
        }

        public string POST(string ServiceUri, string JsonString)
        {
            return this._execute.Execute(ServiceUri, JsonString);
        }
    }
}