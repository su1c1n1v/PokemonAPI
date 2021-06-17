using AutoMapper;
using PokemonAPI.Dtos;
using PokemonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonAPI.Profiles
{
    public class PokemonsProfile : Profile
    {
        public PokemonsProfile()
        {
            CreateMap<Pokemon, PokemonReadDto>();
            CreateMap<PokemonCreateDto, Pokemon>();
            CreateMap<PokemonUpdateDto, Pokemon>();
            CreateMap<Pokemon, PokemonUpdateDto>();
        }
    }
}
