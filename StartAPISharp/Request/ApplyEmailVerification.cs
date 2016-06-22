using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class ApplyEmailVerification : APIRequest
    {
        public ApplyEmailVerification(APISession session, String email)
        {
            requestData["actionType"] = "applyemailverification";
            requestData["email"] = email;
            this.session = session;
        }
    }
}
