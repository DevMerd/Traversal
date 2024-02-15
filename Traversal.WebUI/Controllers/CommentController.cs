using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<PartialViewResult> AddComment()
        {
            return PartialView();
        }  

        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;
            await _commentService.TAdd(comment);
            return RedirectToAction("Index","Destination");
        }
    }
}
