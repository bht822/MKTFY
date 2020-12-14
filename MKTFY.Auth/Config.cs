using System.Collections.Generic;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace MKTFY.Auth
{
   

    // static class , dont need an object to use it . Dont need instance of config 
    public static class Config
    {

        // define the scopes
        public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
        {
            new ApiScope("MKTFYapi.scope","Api For MKTFY")
        };

        public static IEnumerable<Client> Clients =>
        new List<Client>
        {
            new Client 
            {
                ClientId = "mobile",
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                ClientSecrets = 
                {
                    new Secret("3nn4Uq8LZ4ilUWfcHzWEjVvLvSouvwPy".Sha256())
                },
                AllowedScopes = {"MKTFYapi.scope"}

            }
            
        };

        public static List<TestUser> Users =>
        new List<TestUser>
        {
            new TestUser 
            {
                SubjectId = "1",
                Username = "alice",
                Password = "password"
            },
             new TestUser 
            {
                SubjectId = "2",
                Username = "bob",
                Password = "password"
            }
            
        };

        
        
    }
}