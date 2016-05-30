namespace ViewModel01.Users
{
    public class Post
    {
        public User_ User { get; set; }

        public class User_
        {
            public string Email { get; set; }

            public string UserName { get; set; }
        }
    }
}
