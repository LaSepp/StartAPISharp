using Rainwork.API.StartAPI.Response.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Rainwork.API.StartAPI.Response
{
    public class UserInfoResponse : APIResponse
    {
        private Dictionary<String, Object> userData;
        public UserInfo userInfo { get; set; }
        public OrgInfo orgInfo { get; set; }
        public UserInfoResponse(string jsonString) : base(jsonString)
        {
            if (respData.ContainsKey("data"))
            {
                using (StringReader reader = new StringReader(respData["data"].ToString()))
                {
                    userData = serializer.Deserialize(reader, typeof(Dictionary<string, object>)) as Dictionary<string, object>;
                }
                if (userData.ContainsKey("userInfo") && userData["userInfo"] != null)
                {
                    using (StringReader reader = new StringReader(userData["userInfo"].ToString()))
                    {
                        userInfo = serializer.Deserialize(reader, typeof(UserInfo)) as UserInfo;
                    }
                }
                if (userData.ContainsKey("orgInfo") && userData["orgInfo"] != null)
                {
                    using (StringReader reader = new StringReader(userData["orgInfo"].ToString()))
                    {
                        orgInfo = serializer.Deserialize(reader, typeof(OrgInfo)) as OrgInfo;
                    }
                }
            }
        }
        public int currentLevel { get { return userData.ContainsKey("currentLevel") ? Int32.Parse(userData["currentLevel"].ToString()) : 0; } }
    }
}
