using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebClient.Services.Managers
{
    interface IExecute
    {
        string Execute(string ServiceUri, string JsonString);
    }
}
