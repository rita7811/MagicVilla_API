﻿using System;
using AutoMapper;
using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dto;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MagicVilla_Web.Controllers
{
	public class VillaController : Controller
	{
		private readonly IVillaService _villaService;
		private readonly IMapper _mapping;

        public VillaController(IVillaService villaService, IMapper mapping)
        {
            _villaService = villaService;
            _mapping = mapping;
        }

        public async Task<IActionResult> IndexVilla()
		{
			List<VillaDTO> list = new();

			var response = await _villaService.GetAllAsync<APIResponse>();
			if (response != null && response.IsSuccess)
			{
				list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
			}

			return View(list);
		}
	}
}

