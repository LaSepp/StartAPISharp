using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class ApplyWebControl : APIRequest
    {
        public ApplyWebControl(APISession session, String hostname)
        {
            requestData["actionType"] = "ApplyWebControl";
            requestData["hostname"] = hostname;
            this.session = session;
        }
    }
}
