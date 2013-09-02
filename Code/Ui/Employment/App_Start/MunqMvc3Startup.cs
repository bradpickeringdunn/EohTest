using System.Web.Mvc;
using Munq.MVC3;

[assembly: WebActivator.PreApplicationStartMethod(
	typeof(EohTest.Ui.Employment.App_Start.MunqMvc3Startup), "PreStart")]

namespace EohTest.Ui.Employment.App_Start {
	public static class MunqMvc3Startup {
		public static void PreStart() {
			DependencyResolver.SetResolver(new MunqDependencyResolver());

			// TODO: Register Dependencies in Global.asax Application_Start
			// var ioc = MunqDependencyResolver.Container;
			// Munq.Configuration.ConfigurationLoader.FindAndRegisterDependencies(ioc); // Optional
			// ioc.Register<IMyRepository, MyRepository>();
			// ...
		}
	}
}
 
