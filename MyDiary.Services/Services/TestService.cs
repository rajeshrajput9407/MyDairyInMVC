using MyDiary.Models;
using MyDiary.Repository.IRepository;
using MyDiary.Repository.Repository;
using MyDiary.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary.Services.Services
{
    public class TestService : ITestService
    {
        private ITestRepository _Repository;
        public TestService(ITestRepository testRepository)
        {
            _Repository = testRepository;
        }
        public int TestMethod()
        {
           return _Repository.TestMethod();
        }
        public IEnumerable<Test> GetEmployees()
        {
            return _Repository.GetEmployees();
        }
    }
}
