using System;
using System.Collections.Generic;

namespace ADECULT.adecult
{
    public partial class Categoria
    {
        public Categoria()
        {
            DirectorioHasCategoria = new HashSet<DirectorioHasCategoria>();
            InverseCategoriaIdCategoriaNavigation = new HashSet<Categoria>();
        }

        public int IdCategoria { get; set; }
        public string NombreCaegoria { get; set; }
        public int CategoriaIdCategoria { get; set; }

        public virtual Categoria CategoriaIdCategoriaNavigation { get; set; }
        public virtual ICollection<DirectorioHasCategoria> DirectorioHasCategoria { get; set; }
        public virtual ICollection<Categoria> InverseCategoriaIdCategoriaNavigation { get; set; }
    }
}
