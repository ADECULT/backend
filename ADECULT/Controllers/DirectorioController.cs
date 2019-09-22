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
    public class DirectorioController : ControllerBase
    {
        // GET api/Directorio
        [HttpGet]
        public ActionResult<List<DirectorioMod>> Get()
        {
            var directorioLogic= new DirectorioLogic();
            var cats = directorioLogic.GetDirectorios() ;
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
