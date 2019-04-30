using MyDiary.Models;
using MyDiary.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDiary.Controllers
{
    public class TestController : Controller
    {
        private ITestService _testService;
        public TestController(ITestService studentService)
        {
            this._testService = studentService;
        }
        // GET: Test
        public ActionResult Index()
        {
            IEnumerable<Test> allEmployee = _testService.GetEmployees();
            //var data = _testService.TestMethod();
            return View(allEmployee);
        }
    }
}