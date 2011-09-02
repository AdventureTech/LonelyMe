using System.Collections.Generic;

namespace LonelyMe.Domain
{
    public class Account
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> SocialAccounts { get; set; }

    }
}
