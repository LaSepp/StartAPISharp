using Rainwork.API.StartAPI.Request;
using Rainwork.API.StartAPI.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Rainwork.API.StartAPI
{
    public class APISession
    {
        public string apiToken;
        private X509Certificate cert;
        private bool testApi;

        public T getResponse<T>(String dataString) where T : APIResponse
        {
            byte[] data = Encoding.UTF8.GetBytes("RequestData=" + dataString);
            String url = "https://api.startssl.com";
            if (testApi) url = "https://apitest.startssl.com";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = data.Length;
            req.ClientCertificates.Add(cert);
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
            }
            using (HttpWebResponse resp = (HttpWebResponse)req.GetResponse())
            {
                using (StreamReader reader = new StreamReader(resp.GetResponseStream(), Encoding.UTF8))
                {
                    String jsonData = reader.ReadToEnd();
                    return Activator.CreateInstance(typeof(T), jsonData) as T;
                }
            }
        }

        public APISession(X509Certificate cert, String apiToken, Boolean testApi = false)
        {
            this.cert = cert;
            this.apiToken = apiToken;
            this.testApi = testApi;
        }

        public ListResponse QueryValidatedDomains()
        {
            return new QueryValidatedDomains(this).getResponse<ListResponse>();
        }
        public ListResponse QueryValidatedEmails()
        {
            return new QueryValidatedEmails(this).getResponse<ListResponse>();
        }
        public APIResponse ApplyEmailVerification(String email)
        {
            return new ApplyEmailVerification(this, email).getResponse<APIResponse>();
        }
        public APIResponse EmailValidation(String email, String authcode)
        {
            return new EmailValidation(this, email, authcode).getResponse<APIResponse>();
        }
        public ListResponse QueryWhois(String domain)
        {
            ListResponse r = new QueryWhois(this, domain).getResponse<ListResponse>();
            r.separator = '|';
            return r;
        }
        public APIResponse ApplyDomainVerification(String domain, String authenEmail)
        {
            return new ApplyDomainVerification(this, domain, authenEmail).getResponse<APIResponse>();
        }
        public APIResponse DomainValidation(String domain, String authenEmail, String authcode)
        {
            return new DomainValidation(this, domain, authenEmail, authenEmail).getResponse<APIResponse>();
        }
        public StringResponse ApplyWebControl(String hostname)
        {
            return new ApplyWebControl(this, hostname).getResponse<StringResponse>();
        }
        public APIResponse WebControlValidation(String hostname)
        {
            return new WebControlValidation(this, hostname).getResponse<APIResponse>();
        }
        public UserInfoResponse QueryUserInfo()
        {
            return new QueryUserInfo(this).getResponse<UserInfoResponse>();
        }
    }
}
