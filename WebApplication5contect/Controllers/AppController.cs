using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApplication5contect.Models;

namespace WebApplication5contect.Controllers
{
    [RoutePrefix("api/Controller")]
    public class AppController : ApiController
    {
        contactEntities db = new contactEntities();
        [HttpPost]
        [Route("SaveContact/{data}")]
        public IHttpActionResult SaveContact(Table_1 data)
        {
            try
            {
                db.Table_1.Add(data);
                db.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
            return Ok(data);
        }

        [HttpGet]
        [Route("GetContacts")]
        public async Task<IEnumerable<Table_1>> GetContacts()
        {
            var data = await db.Set<Table_1>().ToListAsync();
            return data;
        }

        [HttpPost]
        [Route("SaveQoute/{data}")]
        public IHttpActionResult SaveQoute(Table_2 data)
        {
            try
            {
                db.Table_2.Add(data);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(data);
        }

        [HttpGet]
        [Route("GetQoutes")]
        public async Task<IEnumerable<Table_2>> GetQoutes()
        {
            var data = await db.Set<Table_2>().ToListAsync();
            return data;
        }
        [HttpPost]
        [Route("savecummint/{data}")]
        public IHttpActionResult savecummint(Table_3 data) 
        {
            try
            {
                db.Table_3.Add(data);
                db.SaveChanges();
            }
            catch (Exception)  
            {
                throw;
            }
            return Ok(data);
        }
        [HttpGet]
        [Route("getcummint")]
        public async Task<IEnumerable<Table_3>> getcummint()
        {
            var data = await db.Set<Table_3>().ToListAsync();
            return data;
        }
    }
}
