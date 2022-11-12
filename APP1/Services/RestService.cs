using APP1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace APP1.Services
{
    public class RestService : IRestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;


//        public RestService(IHttpsClientHandlerService service)
//        {
//#if DEBUG
//            _httpsClientHandlerService = service;
//            HttpMessageHandler handler = _httpsClientHandlerService.GetPlatformMessageHandler();
//            if (handler != null)
//                _client = new HttpClient(handler);
//            else
//                _client = new HttpClient();
//#else
//            _client = new HttpClient();
//#endif
//            _serializerOptions = new JsonSerializerOptions
//            {
//                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
//                WriteIndented = true
//            };
//        }

        public async Task SaveSignUpAsync(ToSignUp item)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                string json = JsonSerializer.Serialize<ToSignUp>(item, _serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                //if (isSuccess)
                //    response = await _client.PostAsync(uri, content);
                //else
                //    response = await _client.PutAsync(uri, content);
                
                response = await _client.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                    Debug.WriteLine(@"\tTodoItem successfully saved.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }


    }
}
