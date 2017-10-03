using IBM.WatsonDeveloperCloud.Conversation.v1;
using IBM.WatsonDeveloperCloud.Conversation.v1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace dotnetBluemix
{

    public class ConversationHelper
    {
        //private readonly string _Server;
       // private readonly NetworkCredential _NetCredential;
        public ConversationHelper(string workSpaceId, string userId, string password)
        {
            //_Server = string.Format("https://gateway.watsonplatform.net/conversation/api/v1/workspaces/{0}/message?version={1}", workSpaceId, DateTime.Today.ToString("yyyy-MM-dd"));
            //_NetCredential = new NetworkCredential(userId, password);
            ConversationService conversationService = new ConversationService(userId, password,ConversationService.CONVERSATION_VERSION_DATE_2017_05_26);
            

            MessageRequest messageRequest = new MessageRequest()
            {
                Input = new InputData()
                {
                    Text = "Oi"
                }
            };
            var result = conversationService.Message(workSpaceId, messageRequest);
            Console.WriteLine(string.Format("result: {0}", JsonConvert.SerializeObject(result,Formatting.Indented)));

        }
        //public async Task<string> GetResponse(string input, string context = null)
        //{
        //    input = "OI";
        //    string req = null;
        //    if (string.IsNullOrEmpty(context)) req = "{\"input\": {\"text\": \"" + input + "\"}, \"alternate_intents\": true}";
        //    else req = "{\"input\": {\"text\": \"" + input + "\"}, \"alternate_intents\": true}, \"context\": \"" + context + "\"";
        //    using (var handler = new HttpClientHandler
        //    {
        //        Credentials = _NetCredential
        //    })
        //    using (var client = new HttpClient(handler))
        //    {
        //        var cont = new HttpRequestMessage();
        //        cont.Content = new StringContent(req.ToString(), Encoding.UTF8, "application/json");
        //        Console.WriteLine("AQUI", req.ToString());
        //        var result = await client.PostAsync(_Server, cont.Content);
        //        //var stringResponse = await result.Content.ReadAsStringAsync();
        //        //var posts = JsonConvert.DeserializeObject<string>(stringResponse);
        //        //Console.WriteLine("AQUI", posts);
        //        return await result.Content.ReadAsStringAsync();
        //    }
        //}



    }
}
