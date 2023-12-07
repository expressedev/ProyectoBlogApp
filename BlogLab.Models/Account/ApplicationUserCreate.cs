using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
	public class ApplicationUserCreate: ApplicationUserLogin
	{
		[MinLength(5, ErrorMessage = "Nombre completo tiene que tener entre 5 y 30 caracteres" )]
		[MaxLength(30, ErrorMessage = "Nombre completo tiene que tener entre 5 y 30 caracteres")]
        public string Fullname { get; set; }

		[Required(ErrorMessage = "Email es obligatorio")]
        [MaxLength(30, ErrorMessage = "Email no puede ser mayor a 30 caracteres")]
		[EmailAddress(ErrorMessage = "Formato de email invalido")]
        public string Email { get; set; }
	}
}

