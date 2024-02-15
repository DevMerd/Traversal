using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;

namespace Traversal.WebUI.ViewComponents.Comment
{
    public class _CommentListViewComponent : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListViewComponent(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var data = await _commentService.TGetDestinationById(id);
            return View(data);
        }
    }
}