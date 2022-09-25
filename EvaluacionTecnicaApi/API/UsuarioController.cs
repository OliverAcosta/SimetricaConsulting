using Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace EvaluacionTecnicaApi.API
{
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        private EvaluacionTecnicaDbContext db = new EvaluacionTecnicaDbContext();

        [HttpGet()]
        [Route("all")]
        public async Task<IEnumerable<Usuario>> GetALL()
        {
            try
            {
                return await db.Usuario.ToArrayAsync();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<Usuario> Get(int id)
        {
            try
            {
                return await db.Usuario.FirstOrDefaultAsync(model => model.Id == id);
                
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }
        [HttpPost]
        public async Task<Usuario> Add(Usuario usuario)
        {
            try
            {
                usuario.Fecha_Transaccion = DateTime.Now;
                db.Usuario.Add(usuario);
                await db.SaveChangesAsync();
                return usuario;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        [HttpPut]
        public async Task<Usuario> Update(Usuario usuario)
        {
            try
            {
                if (usuario == null || usuario.Id == 0) return null;
                db.Usuario.Attach(usuario);
                await db.SaveChangesAsync();
                return usuario;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<Usuario> Delete( int id)
        {
            var usuario = await db.Usuario.Where(model => model.Id == id).FirstOrDefaultAsync();
            if (usuario != null)
            {
                db.Usuario.Remove(usuario);
                await db.SaveChangesAsync();
            }
            return usuario;
        }

        [HttpPost()]
        [Route("login")]
        public async Task<dynamic> Login(Usuario model)
        {
            try
            {
                var result = await db.Usuario.FirstOrDefaultAsync(models => models.Usuario_Nombre == model.Usuario_Nombre 
                && models.Contrasena == model.Contrasena);
                if (result != null)
                {
                    return new { Success = true, Message = "The user has authenticate correctly" };
                }
                return new { Success = false, Message = "The user has authenticate correctly" };
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
