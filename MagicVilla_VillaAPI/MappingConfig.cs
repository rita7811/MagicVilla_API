using System;
using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI
{
	public class MappingConfig : Profile
	{
		public MappingConfig()
		{
			CreateMap<VillaNumber, VillaDTO>();
			CreateMap<VillaDTO, VillaNumber>();

			CreateMap<VillaNumber, VillaCreateDTO>().ReverseMap();
			CreateMap<VillaNumber, VillaUpdateDTO>().ReverseMap();

			CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();
			CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
			CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
		}
	}
}

