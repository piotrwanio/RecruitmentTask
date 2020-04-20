using RecruitmentTask.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecruitmentTask.UI.Controllers
{
    public class FormController : BaseController
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Create (User user)
        {
            if (ModelState.IsValid)
            {
                return View("Created", user);
            }
            else
            {
                return View("Create");
            }
        }

        public ViewResult Created(User user)
        {
            return View(user);
        }
    }
}