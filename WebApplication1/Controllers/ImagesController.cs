using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
       
        public async Task<HttpResponseMessage> GetImage()
        {
            Uri uri = new Uri("https://img-lcwaikiki.mncdn.com/mnresize/1024/-/pim/productimages/20202/4353414/l_20202-0w9011z8-hrz_a.jpg", UriKind.Absolute);
            using HttpClient client = new HttpClient();
            return await client.GetAsync(uri);
        }
    }
}
