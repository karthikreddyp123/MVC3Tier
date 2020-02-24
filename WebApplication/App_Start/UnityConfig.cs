using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using BusinessObjects;
using BusinessLogic;
using DataAccess;
namespace WebApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IStudentBL,StudentBL>();
            container.RegisterType<IStudentBO, StudentBO>();
            container.RegisterType<IStudentDAL, StudentsDAL>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}