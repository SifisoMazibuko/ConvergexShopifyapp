using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ConvergexShopifyapp.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConvergexShopifyapp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetAccessToken([FromBody]Access_Token_RQ model)
        {
            var url = "https://convergexdmstore.myshopify.com/admin/oauth/access_token";
            HttpResponseMessage response;
            string req_body = JsonConvert.SerializeObject(model);
            string res_body;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri();
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {}");

                response = await client.PostAsync(url, new StringContent(res_body, Encoding.UTF8, "application/json"));
            }
            res_body = await response.Content.ReadAsStringAsync();

            return Ok(JsonConvert.DeserializeObject<Access_Token_RS>(res_body));
        }
    }
}
