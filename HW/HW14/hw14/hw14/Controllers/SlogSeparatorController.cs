using hw14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hw14.Controllers
{
    public class SlogSeparatorController : Controller
    {
        // GET: SlogSeparator
        [HttpGet]
        public ActionResult EnterText()
        {
            ViewBag.SeparetedText = new string[0];
            return View();
        }
        [HttpPost]
        public ActionResult EnterText(TextViewModel viewModel)
        {
            ViewBag.SeparetedText = SlogParser.GetSlogs(viewModel.UserText);
            return View(viewModel);
        }
    }
}