using System;
using System.Collections.Generic;

#nullable disable

namespace ApiLibros.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Libros = new HashSet<Libro>();
        }

        public int Id { get; set; }
        public string Genero1 { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}
