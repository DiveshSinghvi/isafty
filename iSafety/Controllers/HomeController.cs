using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iSafety.Models;

namespace iSafety.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Global_CourseDetail()
        {
            List<CourseDetail> globals = new List<CourseDetail>();
            globals.Add(new CourseDetail() { CourseId = 1, Course = "Course1", Description = "Course1 Detail", NoOfClass = "2" });
            globals.Add(new CourseDetail() { CourseId = 2, Course = "Course2", Description = "Course2 Detail", NoOfClass = "2" });
            globals.Add(new CourseDetail() { CourseId = 3, Course = "Course3", Description = "Course3 Detail", NoOfClass = "2" });
            globals.Add(new CourseDetail() { CourseId = 4, Course = "Course4", Description = "Course4 Detail", NoOfClass = "2" });
            globals.Add(new CourseDetail() { CourseId = 5, Course = "Course5", Description = "Course5 Detail", NoOfClass = "2" });

            return Json(globals, JsonRequestBehavior.AllowGet);
        }

    }
}
