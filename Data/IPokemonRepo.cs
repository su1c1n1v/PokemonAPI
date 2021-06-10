using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Data
{
    public interface IPokemonRepo
    {
        //Get all pokemon in the application
        IEnumerable<Pokemon> GetAllPokemons();

        //Get a pokemon by it ID
        Pokemon GetPokemonById(int Id);


    }
}
