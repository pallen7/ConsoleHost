using IdentityServer3.Core.Models;
using System.Collections.Generic;

namespace ConsoleHost
{
    static class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                // No user involved at the moment
                new Client
                {
                    ClientName = "The Client",                      
                    ClientId = "theclient",                         // However we want to identify our client
                    Enabled = true,

                    Flow = Flows.Implicit,                          // Read up on Flows

                    RedirectUris = new List<string>                 // This is where the respons is sent.. (Not a user redirection)
                    {
                        "http://localhost:1387"
                    },

                    AllowAccessToAllScopes = true

                    //AccessTokenType = AccessTokenType.Reference,    // Need to read up on this.

                    //ClientSecrets = new List<Secret>
                    //{
                    //    new Secret("F621F470-9731-4A25-80EF-67A6F7C5F4B8".Sha256())
                    //},

                    //AllowedScopes = new List<string>
                    //{
                    //    "theapi"
                    //}
                }

                //// User is involved in this request
                //new Client
                //{
                //    ClientName = "Silicon on behalf of Client",
                //    ClientId = "theclientuser",
                //    Enabled = true,
                //    AccessTokenType = AccessTokenType.Reference,

                //    Flow = Flows.ResourceOwner,

                //    ClientSecrets = new List<Secret>
                //    {
                //        new Secret("21B5F798-BE55-42BC-8AA8-0025B903DC3B".Sha256())
                //    },

                //    AllowedScopes = new List<string>
                //    {
                //        "api1"
                //    }
                //}
            };
        }
    }
}
