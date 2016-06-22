using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class QueryUserInfo : APIRequest
    {
        public QueryUserInfo(APISession session)
        {
            requestData["actionType"] = "QueryUserInfo";
            this.session = session;
        }
    }
}
