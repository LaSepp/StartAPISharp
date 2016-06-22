using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class QueryWhois : APIRequest
    {
        public QueryWhois(APISession session, String domain)
        {
            requestData["actionType"] = "querywhois";
            requestData["domain"] = domain;
            this.session = session;
        }
    }
}
