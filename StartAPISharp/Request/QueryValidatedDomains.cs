﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class QueryValidatedDomains : APIRequest
    {

        public QueryValidatedDomains(APISession session)
        {
            requestData["actionType"] = "queryvalidateddomains";
            this.session = session;
        }
        
    }
}
