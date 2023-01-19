using DrugaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrugaMVC.Controllers
{
    public class StudentiController : Controller
    {
        // GET: Studenti
        public ActionResult Index()
        {
           var studentList = new List<Student>{
           new Student() { Id = 1, Ime = "John", Starost = 18 } ,
           new Student() { Id = 2, Ime = "Steve", Starost = 21 } ,
           new Student() { Id = 3, Ime = "Bill", Starost = 25 } ,
           new Student() { Id = 4, Ime = "Ram" , Starost = 20 } ,
           new Student() { Id = 5, Ime = "Ron" , Starost = 31 } ,
           new Student() { Id = 4, Ime = "Chris" , Starost = 17 } ,
           new Student() { Id = 4, Ime = "Rob" , Starost = 19 }
         };

            return View(studentList);
        }
    }
}