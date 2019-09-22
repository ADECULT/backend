using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADECULT.Models
{
    public class DirectorioMod
    {
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
    }
}
