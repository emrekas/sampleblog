using System.Collections.Generic;

namespace SampleBlog.Domain.Entities
{
    public class User
    {
        public User()
        {
            Posts = new HashSet<Post>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ProfilePhoto { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
