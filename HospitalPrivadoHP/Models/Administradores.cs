using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalPrivadoHP.Models
{
	public class Administradores
	{
		[Key]
		public int Id_administrador { get; set; }
		[Required]
		public string nombre { get; set; }
		[Required]
		public string apellido_paterno { get; set; }
		[Required]
		public string apellido_materno { get; set; }
		[Required]
		public int edad { get; set; }
		[Required]
		public string correo_electronico { get; set; }
		[Required]
		public string contrasena { get; set; }
		[Required]
		public List<TipoUsuarios> id_tipo_usuario { get; set; }
	}
}