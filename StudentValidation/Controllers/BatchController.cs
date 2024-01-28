using Microsoft.AspNetCore.Mvc;
using StudentValidation.Models;

namespace StudentValidation.Controllers
{
    public class BatchController : Controller
    {
        public static List<Student> list = null;
        public BatchController()
        {
            if(list == null)
            {
                list = new List<Student>()
                {
                    new Student() { Id = 1, Name = "Animesh", Address = "Delhi", batch = "B001", Dob = DateTime.Parse("11/05/2005"), },
                    new Student() { Id = 2, Name = "Saurav", Address = "Delhi", batch = "B002", Dob = DateTime.Parse("11/05/2006"), },
                    new Student() { Id = 3, Name = "Chirag", Address = "Pune", batch = "B004", Dob = DateTime.Parse("11/05/2007"), }
                };
            }
        }

        public IActionResult Index()
        {
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            list.Add(student);
            //return View();
            return RedirectToAction("Index");

        }

        public IActionResult Display(int? id)
        {
            if (!id.HasValue)
            {
                ViewBag.msg = "Please provide a ID"; return View();
            }
            else
            {
                var student = list.Where(x => x.Id == id).FirstOrDefault();
                if (student == null)
                {
                    ViewBag.msg = "There is no record woth this ID";
                    return View();
                }
                else
                    return View(student);
            }


        }

        public IActionResult Delete(int? id)
        {
            if (!id.HasValue)
            {
                ViewBag.msg = "Please provide a ID"; return View();
            }
            else
            {
                var student = list.Where(x => x.Id == id).FirstOrDefault();
                if (student == null)
                {
                    ViewBag.msg = "There is no record woth this ID";
                    return View();
                }
                else
                    return View(student);
            }
        }

        [HttpPost]
        public IActionResult Delete(Student student, int id)
        {
            var temp = list.Where(x => x.Id == id).FirstOrDefault();
            if (temp != null)
                list.Remove(temp);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (!id.HasValue)
            {
                ViewBag.msg = "Please provide a ID"; return View();
            }
            else
            {
                var student = list.Where(x => x.Id == id).FirstOrDefault();
                if (student == null)
                {
                    ViewBag.msg = "There is no record woth this ID";
                    return View();
                }
                else
                    return View(student);
            }

        }

        [HttpPost]
        public IActionResult Edit(Student student, int id)
        {
            var temp = list.Where(x => x.Id == id).FirstOrDefault();
            if (temp != null)
            {
                foreach (Student stu in list)
                {
                    if (stu.Id == temp.Id)
                    {
                        stu.batch = student.batch;
                        stu.Address = student.Address;
                        stu.Name = student.Name;
                        break;
                    }
                }
            }
            return RedirectToAction("Index");

        }

    }
}
