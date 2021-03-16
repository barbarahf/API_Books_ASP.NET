using System;
using System.Collections.Generic;

#nullable disable

namespace ApiLibros.Models
{
    public partial class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public double Precio { get; set; }
        public int IdGenero { get; set; }
        public int IdEditorial { get; set; }
        public string Img { get; set; }

        public virtual Editorial IdEditorialNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
    }
}
