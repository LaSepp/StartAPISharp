using Newtonsoft.Json;
using Rainwork.API.StartAPI.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public abstract class APIRequest
    {
        private static JsonSerializer serializer = new JsonSerializer();
        protected Dictionary<String, String> requestData = new Dictionary<string, string>();

        protected APISession session;
        public T getResponse<T>() where T:APIResponse
        {
            requestData["tokenID"] = session.apiToken;
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, requestData);
                return session.getResponse<T>(writer.ToString());
            }
        }
    }
}
