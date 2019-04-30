using MediatR;
using SampleBlog.Domain.Entities;
using System.Collections.Generic;

namespace SampleBlog.Application.Posts.Commands
{
    public class CreatePostCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string ContentText { get; set; }
        public int Status { get; set; }
        //public ICollection<TagPost> TagPosts { get; set; }
    }
}
