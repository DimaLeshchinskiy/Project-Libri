using Microsoft.AspNetCore.Mvc;
using ProjectLibri.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectLibri.Components
{
    public class NotificationsViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }

    }
}
