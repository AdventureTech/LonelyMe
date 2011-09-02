using System.Collections.Generic;

namespace LonelyMe.Domain
{
    public class Registration
    {

        public Account Register(string username, string password)
        {
            return new Account() { Username = username, Password = password, SocialAccounts = new List<string> {"Facebook", "Twitter"} };
        }

    }
}
