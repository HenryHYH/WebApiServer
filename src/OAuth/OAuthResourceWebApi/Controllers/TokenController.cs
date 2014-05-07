using DotNetOpenAuth.OAuth2;
using OAuthResourceWebApi.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace OAuthResourceWebApi.Controllers
{
    public class TokenController : ApiController
    {
        public Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            var authServer = new AuthorizationServer(new AuthorizationServerHost());
            return authServer.HandleTokenRequestAsync(request);
        }
    }
}
