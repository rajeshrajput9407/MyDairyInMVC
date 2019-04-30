using MyDiary.Repository.IRepository;
using MyDiary.Repository.Repository;
using MyDiary.Services.IServices;
using MyDiary.Services.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MyDiary
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<ITestRepository, TestRepository>();
            container.RegisterType<ITestService, TestService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}