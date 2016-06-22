using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Rainwork.API.StartAPI.Response
{
    public class APIResponse
    {
        protected static JsonSerializer serializer = new JsonSerializer();
        protected Dictionary<string, object> respData;

        public APIResponse(string jsonString)
        {
            using (StringReader reader = new StringReader(jsonString))
            {
                respData = serializer.Deserialize(reader, typeof(Dictionary<string, object>)) as Dictionary<string, object>;
            }
        }

        public bool successs { get { return respData.ContainsKey("status") ? respData["status"].ToString() == "1" : false; } }
        public int errorCode { get { return respData.ContainsKey("errorCode") ? Int32.Parse(respData["errorCode"].ToString()) : -49; } }
        public string shortMsg { get { return respData.ContainsKey("shortMsg") ? respData["shortMsg"].ToString() : null; } }
    }
}