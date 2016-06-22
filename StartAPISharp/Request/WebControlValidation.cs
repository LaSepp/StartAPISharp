using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class WebControlValidation : APIRequest
    {
        public WebControlValidation(APISession session, String hostname)
        {
            requestData["actionType"] = "WebControlValidation";
            requestData["hostname"] = hostname;
            this.session = session;
        }
    }
}
