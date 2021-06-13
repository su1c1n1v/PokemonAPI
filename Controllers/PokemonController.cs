using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Data;
using PokemonAPI.Dtos;
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
        private readonly IMapper _mapper;

        public PokemonController(IPokemonRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET Pokemon
        [HttpGet]
        public ActionResult<IEnumerable<PokemonReadDto>> GetAllPokemons()
        {
            var pokemonsItems = _repository.GetAllPokemons();
            var pokemonsDto = _mapper.Map<IEnumerable<PokemonReadDto>>(pokemonsItems);
            return Ok(pokemonsDto);
        }

        //GET /Pokemon/{id}
        [HttpGet("{id}")]
        public ActionResult<PokemonReadDto> GetPokemonById(int id)
        {
            var pokemonItem = _repository.GetPokemonById(id);
            if (pokemonItem != null)
            {
                return Ok(_mapper.Map<PokemonReadDto>(pokemonItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PokemonReadDto> CreatePokemon(PokemonCreateDto pokemonCreateDto)
        {
            var pokemonModel = _mapper.Map<Pokemon>(pokemonCreateDto);
            _repository.CreatePokemon(pokemonModel);
            _repository.SaveChanges();
            var pokemonReadDto = _mapper.Map<PokemonReadDto>(pokemonModel);

            return Ok(pokemonReadDto);
        }

    }
}
