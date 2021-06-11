using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Data;
using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Controllers
{
    //[Route("Pokemon")] or
    [Route("[controller]")] //The route call this controller
    [ApiController] //Declaretion of the controller to be a API Controller
    public class PokemonController : ControllerBase
    {

        private readonly IPokemonRepo _repository;

        public PokemonController(IPokemonRepo repository)
        {
            _repository = repository;

        }

        //GET Pokemon
        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var pokemonsItems = _repository.GetAllPokemons();
            return Ok(pokemonsItems);
        }

        //GET Pokemon/{id}
        [HttpGet("{id}")]
        public ActionResult<Pokemon> GetPokemonById(int id)
        {
            var pokemonItem = _repository.GetPokemonById(id);
            return Ok(pokemonItem);
        }
    }
}
