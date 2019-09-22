using System;
using System.Collections.Generic;

namespace ADECULT.ADECULT
{
    public partial class DirectorioHasCategoria
    {
        public int DirectorioIdCedula { get; set; }
        public int CategoriaIdCategoria { get; set; }
        public byte Individual { get; set; }

        public virtual Categoria CategoriaIdCategoriaNavigation { get; set; }
        public virtual Directorio DirectorioIdCedulaNavigation { get; set; }
    }
}
