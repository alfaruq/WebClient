using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WebClient
{
    public static class Extensions
    {
        public static string RemoveSpecialCharacters(this string temp)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in temp)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == '"' || c == '{' || c == '}' || c == ':' || c == ',' || c == ' ' || c == '-' || c == '+')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}