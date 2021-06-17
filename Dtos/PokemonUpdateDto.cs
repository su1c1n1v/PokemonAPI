using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Dtos
{
    public class PokemonUpdateDto
    {
        /*[Required]
        [MaxLength(100)]*/
        [Required]
        public String Name { get; set; }

        [Required]
        public String Local { get; set; }
    }
}
