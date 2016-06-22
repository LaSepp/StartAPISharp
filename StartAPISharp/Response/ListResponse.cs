using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Response
{
    public class ListResponse : APIResponse
    {
        public char separator = ',';
        public ListResponse(string jsonString) : base(jsonString)
        {
        }
        public List<string> data { get { return respData.ContainsKey("data") ? new List<string>(respData["data"].ToString().Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries)) : null; } }
    }
}
