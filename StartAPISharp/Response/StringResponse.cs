using Rainwork.API.StartAPI.Response.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Response
{
    public class StringResponse : APIResponse
    {

        public StringResponse(string jsonString) : base(jsonString)
        {
        }

        public String data { get { return respData.ContainsKey("data") ? respData[data].ToString() : null; } }
    }
}
