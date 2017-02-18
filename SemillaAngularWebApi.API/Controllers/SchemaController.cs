using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SemillaAngularWebApi.API.DB;
using System.Reflection;
using SemillaAngularWebApi.API.DB.Schema_info;

namespace SemillaAngularWebApi.API.Controllers
{
    public class SchemaController : ApiController
    {
        // GET: api/Schema
        [Route("api/Schema/tablas")]
        public IEnumerable<Table_info> Get()
        {
            gestion_horariosEntities ctx = new gestion_horariosEntities();
            var tablas = ctx.Database.SqlQuery<Table_info>("SELECT * FROM information_schema.tables where table_schema='gestion_horarios'").ToList();
            
            return tablas;
        }

        [Route("api/Schema/tablas/{nombre_tabla}")]
        public IEnumerable<Column_info> Get(string nombre_tabla)
        {
            //SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'gestion_horarios' AND TABLE_NAME = 'alumno';
            gestion_horariosEntities ctx = new gestion_horariosEntities();
            var tabla = ctx.Database.SqlQuery<Column_info>("SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'gestion_horarios' AND TABLE_NAME = '"+ nombre_tabla + "'").ToList();

            return tabla;
        }

        // GET: api/Schema/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Schema
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Schema/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Schema/5
        public void Delete(int id)
        {
        }
    }
}
