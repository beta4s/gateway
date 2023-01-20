using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b4s.Config.Models
{
    public class Tennant : ITennant
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }
}
