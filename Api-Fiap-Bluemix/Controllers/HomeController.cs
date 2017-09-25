using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnetBluemix;

namespace Api_Fiap_Bluemix.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        // GET: api/Home
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Home/5
        [HttpGet("{id}", Name = "Get")]
        public Object Get(string msg)
        {
            ConversationHelper helper = new ConversationHelper("62a2a278-894d-42eb-999d-5aedaad8218d", "dcbf3a3f-2e0b-4ef5-943f-5923b98daa34", "RCKvyGkBkkj1");
            var res = helper.GetResponse(msg).GetAwaiter().GetResult();
            return res;

        }
        
        // POST: api/Home
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
