using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.AppService
{
    public class Tools
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}