using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Ecommerce.CORE.Repository;
using System.Web.Mvc;
using Autofac.Integration.Mvc;

namespace Ecommerce.UI
{
    public static class Bootstrapper
    {
        public static void RunConfig()
        {
            BuildAutofac();
        }

        private static void BuildAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<CashPayment>().As<IPayment>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}