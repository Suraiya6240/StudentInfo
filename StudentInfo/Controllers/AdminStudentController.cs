using Microsoft.AspNetCore.Mvc;
using StudentInfo.Data;
using StudentInfo.Models.Domain;
using StudentInfo.Models.ViewModels;

namespace StudentInfo.Controllers
{
    public class AdminStudentController : Controller

    {
        private readonly StudentDbContext _studentDbContext;

        public AdminStudentController(StudentDbContext studentDbContext)
        {
            this._studentDbContext = studentDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddStudentRequest addStudentRequest)
        {
            var student = new Student
            {

                Name = addStudentRequest.Name,
                Department = addStudentRequest.Department,
                Session = addStudentRequest.session,
            };

            _studentDbContext.StudentInfo.Add(student);
            _studentDbContext.SaveChanges();
            return View();
        }
        [HttpGet]
        public IActionResult List()
        {
            var students = _studentDbContext.StudentInfo.ToList();
            return View(students);
        }
    }
}
