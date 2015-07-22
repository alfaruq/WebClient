using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebClient.ServiceCaller
{
    public class Caller
    {
        /// <summary>
        /// Calling Web Service (with Scripting enabled)
        /// </summary>
        /// <param name="ServiceUri">Valid key in web.config, where the value should be valid Uri for the web service call</param>
        /// <param name="Object">Object, this object will be serialized by Newtonsoft JsonConvert.</param>
        /// <returns></returns>
        public static string CallPOSTWebService(string ServiceUri, object Object)
        {
            string result = string.Empty;

            try
            {
                var url = ConfigurationManager.AppSettings[ServiceUri];

                if (string.IsNullOrEmpty(url))
                    throw new NullReferenceException(string.Format("{0} configuration does not exist in web.config", ServiceUri));

                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                httpWebRequest.ContentType = "application/json; charset=utf-8";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(Object);

                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var temp = streamReader.ReadToEnd();
                    
                    if (temp.Contains("{\"d\":\""))
                    {
                        result = temp.Substring(6, temp.Length - 8);                        
                    }                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result.RemoveSpecialCharacters(); //TODO: find a better way to stringify this string. Special characters fucks deserialization
        }
    }
}