using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnetBluemix;
using IBM.WatsonDeveloperCloud.Conversation.v1;
using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

        //// GET: api/Home/5
        //[HttpGet("{id}", Name = "Get")]
        //public Object Get(string msg)
        //{
        //    ConversationHelper helper = new ConversationHelper("62a2a278-894d-42eb-999d-5aedaad8218d", "dcbf3a3f-2e0b-4ef5-943f-5923b98daa34", "RCKvyGkBkkj1");
        //    //var res = helper.GetResponse(msg).GetAwaiter().GetResult();
        //    //return res;

        //}
        
        // POST: api/Home
        [HttpPost]
        public string Post([FromBody] string input)
        {

            Console.WriteLine("########" + input);
            // ConversationHelper helper = new ConversationHelper("1758047a-5adf-413a-8d05-a367cf729fcb", "dcbf3a3f-2e0b-4ef5-943f-5923b98daa34", "RCKvyGkBkkj1");
            //var res = helper.GetResponse(value).GetAwaiter().GetResult();
            ConversationService conversationService = new ConversationService("dcbf3a3f-2e0b-4ef5-943f-5923b98daa34", "RCKvyGkBkkj1", ConversationService.CONVERSATION_VERSION_DATE_2017_05_26);





        
       
            MessageRequest messageRequest = new MessageRequest()
            {
                Input = new InputData()
                {
                    Text = input
                }
            };
            var result = conversationService.Message("1758047a-5adf-413a-8d05-a367cf729fcb", messageRequest);
            Console.WriteLine(string.Format("result: {0}", JsonConvert.SerializeObject(result, Formatting.Indented)));
            return JsonConvert.SerializeObject(result, Formatting.Indented);

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
