using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }

        public int? ParentBlogCommentId { get; set; }

        public int BlogId { get; set; }

        [Required(ErrorMessage = "Contenido es obligatorio")]
        [MinLength(10, ErrorMessage = "Contenido tiene que tener entre 10 y 300 caracteres")]
        [MaxLength(300, ErrorMessage = "Contenido tiene que tener entre 10 y 300 caracteres\"")]
        public string Content { get; set; }
    }
}