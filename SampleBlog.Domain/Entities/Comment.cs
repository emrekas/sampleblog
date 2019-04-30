using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBlog.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string ContentText { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Author { get; set; }
        public string Email { get; set; }
        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
