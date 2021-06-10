using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Data
{
    public class MockPokemonRepo : IPokemonRepo
    {
        public IEnumerable<Pokemon> GetAllPokemons()
        {
            var pokemons = new List<Pokemon>
            {
                new Pokemon { Id = 0, Name = "Pikachu", Type = new List<string> { "Eletric" }, Effective = new List<string> { "Water", "Flying" }, Local = "Kanto" },
                new Pokemon { Id = 1, Name = "Raichu", Type = new List<string> { "Eletric" }, Effective = new List<string> { "Water", "Flying" }, Local = "Kanto" },
                new Pokemon { Id = 2, Name = "Pichu", Type = new List<string> { "Eletric" }, Effective = new List<string> { "Water", "Flying" }, Local = "Kanto" }
            };
            return pokemons;
        }

        public Pokemon GetPokemonById(int Id)
        {
            return new Pokemon { Id = 0, Name = "Pikachu", Type = new List<string> { "Eletric" }, Effective = new List<string> { "Water", "Flying" }, Local = "Kanto" };
        }
    }
}
