using IdentityModel.Client;

namespace MKTFY.Models.ViewModels
{
    public class LoginReponseVM
    {
        public LoginReponseVM(TokenResponse tokenresponse, AppUserVM user)
        
        {
            AccessToken = tokenresponse.AccessToken;
            Expires = tokenresponse.ExpiresIn;
            User = user;
            
        }

        public string AccessToken { get; set; }

        public long  Expires { get; set; }

        public AppUserVM User { get; set; }
    }
}