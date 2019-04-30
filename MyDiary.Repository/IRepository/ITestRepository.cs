using MyDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Repository.IRepository
{
  public interface ITestRepository
    {
        int TestMethod();

        void InsertEmployee(Test Employee); // C

        IEnumerable<Test> GetEmployees(); // R

        Test GetEmployeeByID(int EmployeeId); // R

        void UpdateEmployee(Test Employee); //U

        void DeleteEmployee(int EmployeeId); //D

        void Save();
    }
}
