using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.Entity.Concrete;

namespace Traversal.WebUI.ViewComponents.Comments
{
    public class _AddCommentViewComponent : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _AddCommentViewComponent(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }

        //public async Task<IViewComponentResult> InvokeAsync(Entity.Concrete.Comment comment)
        //{
        //    comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    comment.CommentState = true;
        //    await _commentService.TAdd(comment);
        //    return View();
        //}
    }
}
