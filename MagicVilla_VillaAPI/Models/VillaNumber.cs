﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
	public class VillaNumber
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]  //provided by the user
		public int VillaNo { get; set; }
		public string SpecialDetails { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}

