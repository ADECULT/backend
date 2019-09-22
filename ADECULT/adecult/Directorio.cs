using System;
using System.Collections.Generic;

namespace ADECULT.ADECULT
{
    public partial class Directorio
    {
        public Directorio()
        {
            DirectorioHasCategoria = new HashSet<DirectorioHasCategoria>();
        }

        public int IdCedula { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Caserio { get; set; }
        public string Poblado { get; set; }
        public string Senas { get; set; }
        public byte Espublico { get; set; }

        public virtual ICollection<DirectorioHasCategoria> DirectorioHasCategoria { get; set; }
    }
}
