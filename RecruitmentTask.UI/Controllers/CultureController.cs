using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecruitmentTask.UI.Controllers
{
    public class CultureController : BaseController
    {
        public ActionResult ChangeCurrentCulture(string lang)
        {
            Response.Cookies.Remove("Language");

            HttpCookie languageCookie = System.Web.HttpContext.Current.Request.Cookies["Language"];

            if (languageCookie == null) languageCookie = new HttpCookie("Language");

            languageCookie.Value = lang;

            languageCookie.Expires = DateTime.Now.AddDays(10);

            Response.SetCookie(languageCookie);

            return RedirectToAction("Create", "Form");

        }
    }
}