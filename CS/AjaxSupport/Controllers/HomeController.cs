using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;
using MVCxGridViewDataBinding.Models;

namespace AjaxSupport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new MyModel(0));
        }
        [ValidateInput(false)]
        public ActionResult CaptchaPartial()
        {
            return PartialView("_CaptchaPartial");
        }
        public ActionResult Index2(MyModel model)
        {
            if (CaptchaExtension.GetIsValid("Captcha") && ModelState.IsValid)
            {
                ViewData["Key"] = "Successfull";
                return PartialView();
            }
            return PartialView("EditFormPartial", model);
        }
    }
}