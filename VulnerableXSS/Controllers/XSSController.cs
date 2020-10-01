using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VulnerableXSS.Models;
using System.Text.Encodings.Web;

namespace VulnerableXSS.Controllers
{
    public class XSSController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SimpleReflected()
        {
            XssBasicFields model = new XssBasicFields
            {
                NameVulnerable = " ",
                NameFixed = " "
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult SimpleReflected(XssBasicFields model)
        {
            if(model.NameFixed == null)
            {
                model.NameFixed = " ";
            }
            if (model.NameVulnerable == null)
            {
                model.NameVulnerable = " ";
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult JavaScriptContext()
        {
            XssBasicFields model = new XssBasicFields
            {
                NameVulnerable = " ",
                NameFixed = " "
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult JavaScriptContext(XssBasicFields model)
        {
            if (model.NameFixed == null)
            {
                model.NameFixed = " ";
            }
            if (model.NameVulnerable == null)
            {
                model.NameVulnerable = " ";
            }
            return View(model);
        }
    }
}