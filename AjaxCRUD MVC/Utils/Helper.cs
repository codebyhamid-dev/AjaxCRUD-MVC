using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

public static class Helper
{
    public static string RenderRazorViewToString(Controller controller, string viewName, object model = null)
    {
        controller.ViewData.Model = model;

        using (var sw = new StringWriter())
        {
            // Get the view engine
            var viewEngine = controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as ICompositeViewEngine;

            // Find the view
            var viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);
            if (!viewResult.Success)
            {
                throw new ArgumentNullException($"View '{viewName}' does not match any available view");
            }

            var viewContext = new ViewContext(
                controller.ControllerContext,
                viewResult.View,
                controller.ViewData,
                controller.TempData,
                sw,
                new HtmlHelperOptions()
            );

            // Render the view
            viewResult.View.RenderAsync(viewContext).GetAwaiter().GetResult();

            return sw.ToString();
        }
    }
}