using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Data
{
    public class SqlPokemonRepo : IPokemonRepo
    {
        private readonly PokemonContext _context;

        public SqlPokemonRepo(PokemonContext context)
        {
            _context = context;
        }

        public void CreatePokemon(Pokemon pkm)
        {
            if(pkm == null)
            {
                throw new ArgumentNullException(nameof(pkm));
            }

            _context.Pokemons.Add(pkm);
        }

        public IEnumerable<Pokemon> GetAllPokemons()
        {
            return _context.Pokemons.ToList();
        }

        public Pokemon GetPokemonById(int Id)
        {
            return _context.Pokemons.FirstOrDefault(temp => temp.Id.Equals(Id));
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
