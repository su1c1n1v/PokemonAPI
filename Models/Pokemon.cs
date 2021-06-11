using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Models
{
    public class Pokemon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]       
        public String Name { get; set; }

        //public List<String> Type { get; set; }
        //public List<String> Effective { get; set; }
        [Required]
        public String Local { get; set; }
    }
}
