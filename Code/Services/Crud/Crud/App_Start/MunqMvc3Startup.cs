using EOHTest.Data.Crud;
using EOHTest.Data.Crud.Interfaces;
using EOHTest.Service.Crud.Classes;
using Munq.MVC3;
using System.Web.Mvc;

[assembly: WebActivator.PreApplicationStartMethod(
	typeof(EOHTest.Service.Crud.App_Start.MunqMvc3Startup), "PreStart")]

namespace EOHTest.Service.Crud.App_Start {
	public static class MunqMvc3Startup {
		public static void PreStart() {
			DependencyResolver.SetResolver(new MunqDependencyResolver());

			// TODO: Register Dependencies in Global.asax Application_Start
			 var ioc = MunqDependencyResolver.Container;
			// Munq.Configuration.ConfigurationLoader.FindAndRegisterDependencies(ioc); // Optional
             ioc.Register<IUnitOfWork, CrudDbContext>();
             ioc.Register<IGetEmployee, GetEmployee>();
             ioc.Register<IAddEmployee, AddEmployee>();
             ioc.Register<IAddPerson, AddPerson>();
             ioc.Register<IGetPerson, GetPerson>();
             ioc.Register<IDeletePerson, DeletePerson>();
             ioc.Register<IUpdateEmployee, UpdateEmployee>();
             ioc.Register<IDismissEmployee, DismissEmployee>();
			// ...
		}
	}
}
 

