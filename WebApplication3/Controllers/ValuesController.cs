using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class ValuesController : ApiController
    {

        [Route("images")]
        public async Task<HttpResponseMessage> GetImage()
        {
            Uri uri = new Uri("https://img-lcwaikiki.mncdn.com/mnresize/1024/-/pim/productimages/20202/4353414/l_20202-0w9011z8-hrz_a.jpg", UriKind.Absolute);
            using (HttpClient client = new HttpClient())
            {
                return await client.GetAsync(uri);
            }
        }
    }
}
