using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class EmailValidation : APIRequest
    {
        public EmailValidation(APISession session, String email, String authcode)
        {
            requestData["actionType"] = "emailvalidation";
            requestData["email"] = email;
            requestData["authcode"] = authcode;
            this.session = session;
        }
    }
}
