using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController:Controller
{
    public IActionResult CourseList()
  {
return View("CourseList",Repository.Courses);
  }
  public IActionResult Details(int? id)
    {
        if (id == null)
        {
            return Redirect("/Course/CourseList");
        }
        var kurs = Repository.GetById(id);
        return View(kurs);
    }
}