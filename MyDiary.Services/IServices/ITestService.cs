using MyDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Services.IServices
{
   public interface ITestService
    {
        int TestMethod();
        IEnumerable<Test> GetEmployees();
    }
}
