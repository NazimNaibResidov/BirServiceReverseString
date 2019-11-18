using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web.AppService
{
  
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class ReverseService : System.Web.Services.WebService
    {

        [WebMethod]
        public string ReverseString(string word)
        {
            string newSoz = Tools.ReverseString(word);
            return newSoz;
        }
    }
}
