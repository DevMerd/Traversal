﻿using Microsoft.AspNetCore.Mvc;

namespace Traversal.WebUI.ViewComponents.Comments
{
    public class _CommentList : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
