using ADECULT.adecult;
using ADECULT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADECULT.Logic
{
    public class CategoriaLogic
    {

        public List<CategoriaMod> GetCategorias()
        {
            var db = new addecultContext();
            List<CategoriaMod> categoryList = new List<CategoriaMod>();
            foreach (Categoria cat in db.Categoria.ToList())
            {
                categoryList.Add(new CategoriaMod
                {
                    IdCategoria = cat.IdCategoria,
                    NombreCaegoria = cat.NombreCaegoria,
                    CategoriaIdCategoria = cat.CategoriaIdCategoria
                }) ;
            }
            return categoryList;
        }
    }
}
