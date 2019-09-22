using ADECULT.Logic;
using ADECULT.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADECULT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
       

        // GET api/Categories
        [HttpGet]
        public ActionResult<List<CategoriaMod>> Get()
        {
            var categoryLogic = new CategoriaLogic();
            var cats = categoryLogic.GetCategorias();
            Console.WriteLine(cats);
            return cats;
        }

        // GET api/Categories/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

    }
}
