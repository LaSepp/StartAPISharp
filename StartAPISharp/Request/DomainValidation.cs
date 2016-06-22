using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class DomainValidation : APIRequest
    {
        public DomainValidation(APISession session, String domain, String authenEmail, String authcode)
        {
            requestData["actionType"] = "DomainValidation";
            requestData["domain"] = domain;
            requestData["authenEmail"] = authenEmail;
            requestData["authcode"] = authcode;
            this.session = session;
        }
    }
}
