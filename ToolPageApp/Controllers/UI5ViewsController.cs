using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Farmacovigilancia.Controllers
{
    /// <summary>
    /// Controller that returns UI5 views
    /// </summary>
    public class UI5ViewsController : Controller
    {
        public IActionResult GetStaticView(string viewName, string viewFolder)
        {
            Response.ContentType = System.Net.Mime.MediaTypeNames.Text.Xml;
            string prefix = "~/Views/UI5";
            if (viewFolder != null) {
                return View($"{prefix}/{viewFolder}/{viewName}.xml");
            } else {
                return View($"{prefix}/{viewName}.xml");
            }
        }

        // we can add more methods to return dynamic views that are generated at runtime based on data using razor
    }
}