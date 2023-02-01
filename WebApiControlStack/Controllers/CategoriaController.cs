using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiControlStack.Data;
using WebApiControlStack.Models;
using System.ComponentModel.DataAnnotations;

namespace WebApiControlStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly DBControlContext context;
        public CategoriaController(DBControlContext context)
        {
            this.context = context;
        }




        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {

            var result = context.Categorias.Include(X => X.Productos).ToList();
            return result;

        }

        
        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Categoria categoria)
        {
            if (id != categoria.Id)
            {
                return BadRequest();
            }
            context.Entry(categoria).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }



    }
}
