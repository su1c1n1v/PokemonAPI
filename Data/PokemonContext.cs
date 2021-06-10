using Microsoft.EntityFrameworkCore;
using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Data
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> opt) : base(opt)
        {

        }

        //For each model that you want to send to DB you need to have a DbSet for the Model
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}
