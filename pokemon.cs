using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace json_pokedex
{
    class Pokemon
    {
        public string hp { get; set; }

        public string pName { get; set; }
      
        public string move { get; set; }

        public string type { get; set; }

        public string picture { get; set; }

    }
}
