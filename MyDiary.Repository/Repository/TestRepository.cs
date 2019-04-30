using MyDiary.Models;
using MyDiary.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Repository.Repository
{
   public class TestRepository : ITestRepository
    {
        private MyDairyDBEntities _DBcontext;

        public TestRepository(MyDairyDBEntities myDairyDBEntities)
        {
            _DBcontext = myDairyDBEntities;
        }
        public int TestMethod()
        {
            return 10;
        }
        public void DeleteEmployee(int EmployeeId)
        {
            Test user = _DBcontext.Tests.Find(EmployeeId);
            _DBcontext.Tests.Remove(user);
        }

        public Test GetEmployeeByID(int EmployeeId)
        {
            return _DBcontext.Tests.Find(EmployeeId);
        }

        public IEnumerable<Test> GetEmployees()
        {
            return _DBcontext.Tests.ToList();
        }

        public void InsertEmployee(Test Employee)
        {
            _DBcontext.Tests.Add(Employee);

        }

        public void Save()
        {
            _DBcontext.SaveChanges();
        }

        public void UpdateEmployee(Test Employee)
        {
            _DBcontext.Entry(Employee).State = EntityState.Modified;
        }
    }
}
