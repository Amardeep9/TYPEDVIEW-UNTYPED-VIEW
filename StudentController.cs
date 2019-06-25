using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TypedandUntypedView.Models;

namespace TypedandUntypedView.Controllers
{
    public class StudentController : Controller
    {
        
        // GET: Student
        public ActionResult Typed()
        {
            Student objstu = new Student();
            objstu.StudentID = 1001;
            objstu.Name = "Amardeep Kumar";
            objstu.MobileNo = 9974223439;
            objstu.Address = "Vapi";
            objstu.Image= "F:/Practicals/TypedViewandUntypedView/TypedandUntypedView/Image/jio.jpg";
            return View(objstu);
        }

        public ActionResult ListTyped()
        {
            List<Student> lststu = new List<Student>();
            Student objstu = new Student();
            objstu.StudentID = 1001;
            objstu.Name = "Amardeep Kumar";
            objstu.MobileNo = 9974223439;
            objstu.Address = "Vapi";
            //return View(objstu);
            lststu.Add(objstu);
            return  View(lststu);
        }


        public ActionResult ListUnTyped()
        {
            List<Student> lststu = new List<Student>();
            Student objstu = new Student();
            objstu.StudentID = 1001;
            objstu.Name = "Amardeep Kumar";
            objstu.MobileNo = 9974223439;
            objstu.Address = "Vapi";
            //return View(objstu);
            lststu.Add(objstu);
            ViewBag.StuLst = lststu;
            return View(lststu);
        }



        public ActionResult ListUnTypedViewData()
        {
            List<Student> lststu = new List<Student>();
            Student objstu = new Student();
            objstu.StudentID = 1001;
            objstu.Name = "Amardeep Kumar";
            objstu.MobileNo = 9974223439;
            objstu.Address = "Vapi";
            //return View(objstu);
            lststu.Add(objstu);
            ViewData["Students"] = lststu;
            return View(lststu);
        }



        public ActionResult Strongly()
        {
            Student objstu = new Student();
            objstu.StudentID = 1001;
            objstu.Name = "Amardeep Kumar";
            objstu.MobileNo = 9974223439;
            objstu.Address = "Vapi";
            return View(objstu);
        }


        public ActionResult Untyped()
        {
            Student objstu = new Student();
            objstu.StudentID = 1001;
            objstu.Name = "Amardeep Kumar";
            objstu.MobileNo = 9974223439;
            objstu.Address = "Vapi";

             ViewBag.Logo = @"C:\Users\admin\Pictures\New folder\jio.png";
            // ViewBag.Logo = Server.MapPath("~") + @"C:\Users\admin\Pictures\New folder\jio.png";
            //ViewBag.Logo = Url.Content("C:/Users/admin/Pictures/New folder/jio.png");

            ViewBag.Stud = objstu;
            return View();
        }


    }
}