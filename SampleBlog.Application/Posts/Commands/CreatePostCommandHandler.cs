using MediatR;
using SampleBlog.Domain.Entities;
using SampleBlog.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleBlog.Application.Posts.Commands
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, int>
    {
        private readonly SampleBlogDbContext _context;
        public CreatePostCommandHandler(SampleBlogDbContext sampleBlogDbContext)
        {
            _context = sampleBlogDbContext;
        }

        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var entity = new Post
            {
                ContentText = request.ContentText,
                Title = request.Title,
                CreatedDate = DateTime.Now,
                Status = request.Status,
                //TagPosts = request.TagPosts
            };
            _context.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
