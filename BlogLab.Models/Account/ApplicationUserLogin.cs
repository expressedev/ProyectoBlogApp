using System;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
	public class ApplicationUserLogin
	{
		[Required(ErrorMessage = "Nombre de usuario es obligatorio")]
        [MinLength(5, ErrorMessage = "Nombre de usuario tiene que tener entre 5 y 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Nombre de usuario tiene que tener entre 5 y 20 caracteres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Contraseña es obligatoria")]
        [MinLength(5, ErrorMessage = "Contraseña tiene que tener entre 5 y 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Contraseña tiene que tener entre 5 y 20 caracteres")]
        public string Password { get; set; }


		

	}
}

