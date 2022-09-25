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
    [RoutePrefix("api/roles")]
    public class RolesController : ApiController
    {
        private EvaluacionTecnicaDbContext db = new EvaluacionTecnicaDbContext();
        [HttpGet()]
        [Route("all")]
        public async Task<IEnumerable<Role>> GetALL()
        {
            try
            {
                return await db.Role.ToArrayAsync();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<Role> Get(int id)
        {
            try
            {
                return await db.Role.FirstOrDefaultAsync(model => model.Id == id);
                
            }
            catch (Exception ex)
            {

                return null;
            }
            
        }
        [HttpPost]
        public async Task<Role> Add(Role model)
        {
            try
            {
                db.Role.Add(model);
                await db.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        [HttpPut]
        public async Task<Role> Update(Role model)
        {
            try
            {
                if (model == null || model.Id == 0) return null;
                db.Role.Attach(model);
                db.Entry(model).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return model;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<Role> Delete( int id)
        {
            var rol = await db.Role.Where(model => model.Id == id).FirstOrDefaultAsync();
            if (rol != null)
            {
                db.Role.Remove(rol);
                await db.SaveChangesAsync();
            }
            return rol;
        }
    }
}
