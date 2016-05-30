using System.Collections.Generic;

namespace ViewModel01.Users
{
    public class List
    {
        public IEnumerable<User_> Users { get; set; }

        public class User_
        {
            public string Id { get; set; }

            public string Email { get; set; }

            public string UserName { get; set; }
        }
    }
}
