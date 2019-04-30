using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBlog.Domain.Entities {
    public class TagPost {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int PostId { get; set; }

        public Tag Tag { get; set; }
        public Post Post { get; set; }
    }
}