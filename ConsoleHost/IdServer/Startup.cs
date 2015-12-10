using IdentityServer3.Core.Configuration;
using Owin;
using IdentityServer3.Core.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleHost.IdServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var options = new IdentityServerOptions
            {
                SigningCertificate = LoadCertificate(),

                Factory = new IdentityServerServiceFactory()
                                    .UseInMemoryClients(Clients.Get())
                                    .UseInMemoryScopes(Scopes.Get())
                                    .UseInMemoryUsers(Users.Get())
            };

            app.UseIdentityServer(options);
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2(
                string.Format(@"{0}\IdServer\idsrv3test.pfx", AppDomain.CurrentDomain.BaseDirectory), "idsrv3test");
        }
    }
}
