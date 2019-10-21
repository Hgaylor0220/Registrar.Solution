// using Microsoft.AspNetCore.Mvc;
// using Registrar.Models;
// using System.Collections.Generic;
// using System.Linq;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc.Rendering;

// namespace Registrar.Controllers
// {
//     public class StudentsController : Controller
//     {
//         private readonly RegistrarContext _db;

//         public StudentsController(RegistrarContext db)
//         {
//             _db = db;
//         }

//         public ActionResult Index()
//         {
//             return View(_db.Students.ToList());
//         }

//         //     public ActionResult Create()
//         //     {
//         //       ViewBag.CourseId = new SelectList(_db.Course, "CourseId", "Name");
//         //       return View();
//         //     }

//         //     [HttpPost]
//         //     public ActionResult Create(Item item)
//         //     {
//         //       _db.Students.Add(item);
//         //       _db.SaveChanges();
//         //       return RedirectToAction("Index");
//         //     }

//         public ActionResult Details(int id)
//         {
//             var thisItem = _db.Students
//             .Include(item => item.Courses)
//             .ThenInclude(join => join.Course)
//             .FirstOrDefault(item => item.ItemId == id);
//             return View(thisItem);
//         }
//         public ActionResult Create()
//         {
//             ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
//             return View();
//         }

//         [HttpPost]
//         public ActionResult Create(Item item, int CourseId)
//         {
//             _db.Students.Add(item);
//             if (CourseId != 0)
//             {
//                 _db.CourseItem.Add(new CourseItem() { CourseId = CourseId, ItemId = item.ItemId });
//             }
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }


//         public ActionResult Edit(int id)
//         {
//             var thisItem = _db.Students.FirstOrDefault(students => students.ItemId == id);
//             ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
//             return View(thisItem);
//         }

//         [HttpPost]
//         public ActionResult Edit(Student student, int CourseId)
//         {
//             if (CourseId != 0)
//             {
//                 _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.Studentd });
//             }
//             _db.Entry(student).State = EntityState.Modified;
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }

//         public ActionResult AddCourse(int id)
//         {
//             var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
//             ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
//             return View(thisStudent);
//         }
//         [HttpPost]
//         public ActionResult AddCourse(Student student, int CourseId)
//         {
//             if (CourseId != 0)
//             {
//                 _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
//             }
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }
//         public ActionResult Delete(int id)
//         {
//             var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
//             return View(thisStudent);
//         }

//         [HttpPost, ActionName("Delete")]
//         public ActionResult DeleteConfirmed(int id)
//         {
//             var thisStudent = _db.Students.FirstOrDefault(students => students.StudentId == id);
//             _db.Students.Remove(thisStudent);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }
//         [HttpPost]
//         public ActionResult DeleteCourse(int joinId)
//         {
//             var joinEntry = _db.CourseStudent.FirstOrDefault(entry => entry.CourseStudentId == joinId);
//             _db.CourseStudent.Remove(joinEntry);
//             _db.SaveChanges();
//             return RedirectToAction("Index");
//         }
//     }
// }