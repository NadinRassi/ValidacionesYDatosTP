using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiControlStack.Data;
using WebApiControlStack.Models;


namespace WebApiControlStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly DBControlContext context;
        public ProductoController(DBControlContext context)
        {
            this.context = context;
        }




        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
            var resultado = context.Productos.Include(x => x.Categoria).ToList();
            return resultado;

        }


        [HttpPost]
        public ActionResult Post(Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Productos.Add(producto);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Producto> Delete(int id)
        {
            var producto = (from a in context.Productos
                         where a.Id == id
                         select a).SingleOrDefault();
            if (producto == null)
            {
                return NotFound();
            }
            context.Productos.Remove(producto);
            context.SaveChanges();
            return producto;
        }

    }
}
