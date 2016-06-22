using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class QueryValidatedEmails : APIRequest
    {
        public QueryValidatedEmails(APISession session)
        {
            requestData["actionType"] = "queryvalidatedemails";
            this.session = session;
        }

    }
}
