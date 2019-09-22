using ADECULT.ADECULT;
using ADECULT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADECULT.Logic
{
    public class DirectorioLogic
    {
        public List<DirectorioMod> GetDirectorios()
        {
            var db = new ADECULTContext();
            List<DirectorioMod> directorioList = new List<DirectorioMod>();
            foreach (Directorio cat in db.Directorio.ToList())
            {

                directorioList.Add(new DirectorioMod
                {
                    IdCedula = cat.IdCedula,
                    Nombre = cat.Nombre,
                    PrimerApellido = cat.PrimerApellido,
                    SegundoApellido = cat.SegundoApellido,
                    Email = cat.Email,
                    Telefono = cat.Telefono,
                    Caserio = cat.Caserio,
                    Poblado = cat.Poblado,
                    Senas = cat.Senas,
                    Espublico = cat.Espublico
                }) ;
            }
            return directorioList;
        }

    }
}
