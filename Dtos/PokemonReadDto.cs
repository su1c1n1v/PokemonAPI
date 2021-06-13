using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Dtos
{
    public class PokemonReadDto
    {
            //This attribute will not be shown to the client
            //public int Id { get; set; }

            public String Name { get; set; }

            public String Local { get; set; }
    }
}
