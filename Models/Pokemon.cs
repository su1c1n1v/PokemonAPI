using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public List<String> Effective { get; set; }

    }
}
