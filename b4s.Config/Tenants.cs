using b4s.Config.Models;
using b4s.Config.Outsystems;
using System.Net.Http.Headers;

namespace b4s.Config
{
    public class Tenants
    {

        private static List<Tennant>? tennants;

        //public async Task<List<ITennant>> GetTennants()
        public async Task<List<Tennant>> GetTennants()
        {

            if (tennants == null)
                tennants = await OutsystemsHelper.GetTennants();

            return tennants;

        }

        /// <summary>
        /// Reseta as configurações
        /// </summary>
        public static void ResetStaticConfig()
        { 
            tennants = null;
        }

    }
}