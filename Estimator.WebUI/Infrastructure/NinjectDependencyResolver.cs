﻿using Estimator.Model.Abstract;
using Estimator.Repository.Concrete;
using System;
using System.Collections.Generic;
using Ninject;
using System.Web.Mvc;
using Estimator.WebUI.Infrastructure.Abstract;
using Estimator.WebUI.Infrastructure.Concrete;


namespace Estimator.WebUI.Infrastructure
{
	public class NinjectDependencyResolver : IDependencyResolver
	{
		private IKernel kernel;

		public NinjectDependencyResolver(IKernel kernelParam)
		{
			kernel = kernelParam;
			AddBindings();
		}

		public object GetService(Type serviceType)
		{
			return kernel.TryGet(serviceType);
		}

		public IEnumerable<object> GetServices(Type serviceType)
		{
			return kernel.GetAll(serviceType);
		}


		private void AddBindings()
		{
			kernel.Bind<IUserRepository>().To<UserRepository>().InSingletonScope();
			kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
		
		}
	}
}