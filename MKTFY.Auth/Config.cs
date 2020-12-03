using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace MKTFY.Auth
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
        {
            new ApiScope("MKTFYapi,MKTFY API")
        };

        public static IEnumerable<Client> Clients =>
        new List<Client>
        {
            new Client {
                ClientID = "MKTFYapi",
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                
                ClientSecrets = {
                    
                }
            }
        }        
    }
}