using BusinessT.Abstract;
using EntitiesT.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpPost ("AddComment")]
        public IActionResult Add(Comment comment)
        {
            var result = _commentService.Add(comment);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpPost ("DeleteComment")]
        public IActionResult Delete(int id)
        {
            var result = _commentService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpPut("updateBlog")]
        public IActionResult Update(Comment comment)
        {
            var result = _commentService.Update(comment);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
        [HttpGet("GetAllComments")]
        public IActionResult GetComments()
        {

            var result = _commentService.GetAllComments();

            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }

        [HttpGet("GetCommentById")]
        public IActionResult Get(int id)
        {
            var result = _commentService.Get(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else return BadRequest(result);
        }
    }
}
