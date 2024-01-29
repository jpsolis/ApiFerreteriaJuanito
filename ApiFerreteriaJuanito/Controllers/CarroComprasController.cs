using ApiFerreteriaJuanito.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiFerreteriaJuanito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroComprasController : ControllerBase
    {
        private readonly DataContext _context;
        public CarroComprasController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<CarroCompras>>> AddCarroCompra(CarroCompras carro)
        {


            _context.CarroCompras.Add(carro);
            await _context.SaveChangesAsync();

            return Ok(await _context.CarroCompras.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<CarroCompras>>> GetAllCarroCompras()
        {
            return Ok(await _context.CarroCompras.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CarroCompras>> GetCarroCompra(int id)
        {
            var carro = await _context.CarroCompras.FindAsync(id);
            if (carro == null)
            {
                return BadRequest("Producto no encontrado.");
            }
            return Ok(carro);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CarroCompras>> DeleteCarroCompra(int id)
        {
            var carro = new CarroCompras() { idCarro = id };
            _context.CarroCompras.Remove(carro);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<CarroCompras>> UpdateCarroCompras(CarroCompras carroModelo)
        {
            CarroCompras carro = _context.CarroCompras.Find(carroModelo.idCarro);

            if (carro == null)
            {
                return BadRequest("No encontrado");
            }

            try
            {
                carro.listaProductos = carroModelo.listaProductos is null ? carro.listaProductos : carroModelo.listaProductos;
              


                _context.Attach(carro);

                //_dbcontext.TabAgregados.Update(objeto);
                _context.Entry(carro).State = EntityState.Modified;
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }


            //var producto = await _context.Productos.FindAsync(prodId);

            //if (producto != null)
            //{
            //    producto.descripcion = prodModelo.descripcion;
            //    producto.precio = prodModelo.precio;

            //    await _context.SaveChangesAsync();
            //}
            //else
            //{
            //    return NotFound();
            //}

            //return Ok();

        }
    }
}
