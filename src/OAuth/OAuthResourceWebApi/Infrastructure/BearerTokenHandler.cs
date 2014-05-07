using DotNetOpenAuth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace OAuthResourceWebApi.Infrastructure
{
    public class BearerTokenHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Authorization != null)
            {
                if (request.Headers.Authorization.Scheme == "Bearer")
                {
                    var resourceServer = new ResourceServer(new StandardAccessTokenAnalyzer(AuthorizationServerHost.HardCodedCryptoKeyStore));
                    var principal = await resourceServer.GetPrincipalAsync(request, cancellationToken);
                    HttpContext.Current.User = principal;
                    Thread.CurrentPrincipal = principal;
                }
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}