using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using BusinessObjects;
using BusinessLogic;
using DataAccess;
using Unity.Extension;

namespace BusinessLogic
{
    public class BusinessUnityConfig : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IStudentDAL, StudentsDAL>();
        }
    }
}
