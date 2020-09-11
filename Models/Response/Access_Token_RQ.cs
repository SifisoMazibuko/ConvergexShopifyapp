using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvergexShopifyapp.Models.Response
{

    public class Access_Token_RQ
    {
        [JsonProperty("access_token")]
        public string access_token { get; set; }
        [JsonProperty("scope")]
        public string scope { get; set; }
        [JsonProperty("expires_in")]
        public string expires_in { get; set; }
    }

    [JsonObject(Title = "Associated_User")]
    public class Associated_User 
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("first_name")]
        public string first_name { get; set; }
        [JsonProperty("last_name")]
        public string last_name { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("email_verified")]
        public Boolean email_verified { get; set; }
        [JsonProperty("account_owner")]
        public string account_owner { get; set; }
        [JsonProperty("locale")]
        public string locale { get; set; }
        [JsonProperty("collaborator")]
        public Boolean collaborator { get; set; }

    }
}


/*{
    "access_token": "f85632530bf277ec9ac6f649fc327f17",
  "scope": "write_orders,read_customers",
  "expires_in": 86399,
  "associated_user_scope": "write_orders",
  "associated_user": {
        "id": 902541635,
    "first_name": "John",
    "last_name": "Smith",
    "email": "john@example.com",
    "email_verified": true,
    "account_owner": true,
    "locale": "en",
    "collaborator": false
  }
}*/