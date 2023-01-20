using b4s.Config.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4s.Config.Outsystems
{
    internal class OutsystemsHelper
    {

        internal static async Task<List<Tennant>> GetTennants()
        {
            var tennants = new List<Tennant>();
            var client = b4s.Tools.Http.HeadersBasicAuth(Config.BaseUrl, Config.ClientId, Config.ClientSecret);
            HttpResponseMessage response = await client.GetAsync(Config.RequestTenantsUrl);

            if (response.IsSuccessStatusCode)
            {
                var tenantsJason = await response.Content.ReadAsStringAsync();
                tennants = JsonConvert.DeserializeObject<List<Tennant>>(tenantsJason) ?? new List<Tennant>();
            }
            else
            {
                throw new Exception(response.ToString());
            }

            return tennants;
        }

    }
}
