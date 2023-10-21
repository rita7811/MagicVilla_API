using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
	public class VillaNumber
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.None)]  //provided by the user
		public int VillaNo { get; set; }

		[ForeignKey("Villa")]
		public int VillaId { get; set; }
		public Villa Villa { get; set; }  //A navigation property for the VillaId

		public string SpecialDetails { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}

