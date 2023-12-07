using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
	public class BlogCreate
	{

		public int BlogId { get; set; }

        [Required(ErrorMessage = "Titulo es obligatorio")]
        [MinLength(10, ErrorMessage = "Titulo tiene que tener entre 10 y 50 caracteres")]
        [MaxLength(50, ErrorMessage = "Tiene que tener entre 10 y 50 caracteres")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Contenido es obligaotrio")]
        [MinLength(300, ErrorMessage = "Contenido tiene que tener entre 300 y 3000 caracteres")]
        [MaxLength(3000, ErrorMessage = "Contenido tiene que tener entre 300 y 3000 caracteres\"")]
        public string Content { get; set; }

		public int? PhotoId { get; set; }
	}
}

