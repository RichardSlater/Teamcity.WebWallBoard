[assembly: WebActivator.PreApplicationStartMethod(typeof(WebWallBoard.AppStart_NinjectMVC3), "Start")]

namespace WebWallBoard 
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;

    public static class AppStart_NinjectMVC3 
	{
        public static void Start() 
		{
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpApplicationModule));
        }
    }
}
