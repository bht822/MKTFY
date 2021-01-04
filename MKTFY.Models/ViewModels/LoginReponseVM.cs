using IdentityModel.Client;

namespace MKTFY.Models.ViewModels
{
    public class LoginReponseVM
    {
        public LoginReponseVM(TokenResponse tokenresponse, AppUserVM user)
        
        {
            AccessToken = tokenresponse.AccessToken;
            Expires = tokenresponse.ExpiresIn;
            TokenType = tokenresponse.TokenType;
            TokenType2 = tokenresponse.IssuedTokenType;
            User = user;
            
        }

        public string AccessToken { get; set; }

        public long  Expires { get; set; }
     public string TokenType { get; set; }

        public string  TokenType2 { get; set; }

        public AppUserVM User { get; set; }


    }
}