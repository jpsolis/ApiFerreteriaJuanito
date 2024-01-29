﻿using ApiFerreteriaJuanito.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiFerreteriaJuanito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;
        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<Usuario>>> AddUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return Ok(await _context.Usuarios.ToListAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetAllUsuarios()
        {
            return Ok(await _context.Usuarios.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var user = await _context.Usuarios.FindAsync(id);
            if (user == null)
            {
                return BadRequest("Usuario no encontrado.");
            }
            return Ok(user);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Usuario>> DeleteUsuario(int id)
        {
            var usuario = new Usuario() { idUsuario = id };
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Usuario>> UpdateUsuario(Usuario usuarioModelo)
        {
            Usuario user = _context.Usuarios.Find(usuarioModelo.idUsuario);

            if (user == null)
            {
                return BadRequest("No encontrado");
            }

            try
            {
                user.nombreUsuario = usuarioModelo.nombreUsuario is null ? user.nombreUsuario : usuarioModelo.nombreUsuario;
                user.rangoUsuario = usuarioModelo.rangoUsuario is null ? user.rangoUsuario : usuarioModelo.rangoUsuario;
                user.passUsuario = usuarioModelo.passUsuario is null ? user.passUsuario : usuarioModelo.passUsuario;


                _context.Attach(user);

                //_dbcontext.TabAgregados.Update(objeto);
                _context.Entry(user).State = EntityState.Modified;
                _context.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = "ok" });
            }           

        }
    }
}
