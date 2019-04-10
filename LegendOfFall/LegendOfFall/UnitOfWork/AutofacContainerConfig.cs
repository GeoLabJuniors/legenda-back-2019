using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegendOfFall.UnitOfWork
{
    public class AutofacContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            //builder.RegisterType<Application>().As<IApplication>();
            //builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            //builder.RegisterType<DataAccess>().As<IDataAccess>();
            //builder.RegisterType<Logger>().As<ILogger>();

            return builder.Build();
        }
    }
}