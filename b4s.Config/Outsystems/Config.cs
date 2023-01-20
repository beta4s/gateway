using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4s.Config.Outsystems
{
    public static class Config
    {

        public static string BaseUrl
        {
            get { return "https://institutolaurafressatto-dev-buadwg8o3v.getoutsystems.com/LauraCare2_0/rest/b4s";}
        }

        public static string ClientId
        {
            get { return "user_api"; }
        } 

        public static string ClientSecret 
        { 
            get { return "dH%7mGbQoY8bdw";}
        }

        public static string RequestTenantsUrl
        {
            get { return "https://institutolaurafressatto-dev-buadwg8o3v.getoutsystems.com/LauraCare2_0/rest/b4s/GetTennants"; }
        }

    }
}
