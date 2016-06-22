using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Request
{
    public class ApplyDomainVerification : APIRequest
    {
        public ApplyDomainVerification(APISession session, String domain, String authenEmail)
        {
            requestData["actionType"] = "ApplyDomainVerification";
            requestData["domain"] = domain;
            requestData["authenEmail"] = authenEmail;
            this.session = session;
        }
    }
}
