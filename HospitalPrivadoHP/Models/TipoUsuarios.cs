using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HospitalPrivadoHP.Models
{
	public class TipoUsuarios
	{
		[Key]
		public int Id_tipo_usuario { get; set; }
		[Required]
		public string tipo_usuario { get; set; }
	}
}