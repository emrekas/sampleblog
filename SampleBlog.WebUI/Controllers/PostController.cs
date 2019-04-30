using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleBlog.Application.Posts.Commands;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SampleBlog.WebUI.Controllers
{
    public class PostController : BaseController
    {
        // GET: /<controller>/
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> Create([FromBody]CreatePostCommand createPostCommand)
        {
            await Mediator.Send(createPostCommand);
            return View();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult("accept");
        }
    }
}
