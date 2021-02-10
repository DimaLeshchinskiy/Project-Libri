using Microsoft.AspNetCore.Mvc;
using ProjectLibri.Models;
using ProjectLibri.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectLibri.Components
{
    public class NotificationsViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            NotificationService service = new NotificationService();
            var notifications = service.getAll();

            return View(notifications);
        }

    }
}
