using Microsoft.AspNetCore.Mvc;
using ProjectLibri.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProjectLibri.Components
{
    public class ExampleViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(String param)
        {

            Debug.WriteLine("test " + param);

            Example ex = new Example();
            ex.value = "default";
            ex.param = param;

            return View(ex);
        }

    }
}
