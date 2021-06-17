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

        //Create a new pokemon to the DB
        void CreatePokemon(Pokemon pkm);

        //Save the thinks added in the DB
        bool SaveChanges();

        //Update a atribute of the pokemon
        void UpdatePokemon(Pokemon pkm);
    }
}
