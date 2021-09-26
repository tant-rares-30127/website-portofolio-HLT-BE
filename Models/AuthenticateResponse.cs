using WebApi.Entities;

namespace PeoplePortal.Models
{
    public class AuthenticateResponse
    {
        public AuthenticateResponse(User user, string accessToken)
        {
            User = user;
            AccessToken = accessToken;
        }

        public User User { get; set; }
        public string AccessToken { get; set; }
    }
}
