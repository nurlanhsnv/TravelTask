using BusinessT.Abstract;
using EntitiesT.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;
        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        [HttpPost("addBlogPost")]
        public IActionResult Add(BlogPost blog)
        {
            
            var result = _blogPostService.Add(blog);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpPost("deletePost")]
        public IActionResult Delete(int id)
        {
            var result = _blogPostService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpPut("updateBlog")]
        public IActionResult Update(BlogPost blog)
        {
            var result = _blogPostService.Update(blog);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpGet("GetAllBlogs")]
        public IActionResult GetBlogs()
        {

            var result = _blogPostService.GetAllBlogs();
            
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpGet("GetBlogById")]
        public IActionResult Get(int id)
        {
            var result = _blogPostService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
    }
}
