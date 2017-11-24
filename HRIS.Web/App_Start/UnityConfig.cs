using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity.Configuration;
using HRIS.Data;
using System.Linq;
using System.Reflection;
using Common;
using Repository.Providers.EntityFramework;
using Repository;
using System.Web.Mvc;

namespace HRIS.Web.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IMemoryCacheManager, MemoryCacheManager>(new PerRequestLifetimeManager());
            container.RegisterType<IDataContext, HRISContext>(new PerRequestLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new PerRequestLifetimeManager());

            typeof(HRISContext)
                  .Assembly
                  .GetExportedTypes()
                  .Where(x => x.IsSubclassOf(typeof(EntityBase)))
                  .ToList()
                  .ForEach(x =>
                  {
                      container.RegisterType(
                        typeof(IRepository<>).MakeGenericType(x),
                        typeof(Repository<>).MakeGenericType(x),
                        new PerRequestLifetimeManager(),
                        new InjectionFactory(c =>
                        {
                            return Activator.CreateInstance(typeof(Repository<>).MakeGenericType(x), DependencyResolver.Current.GetService<IDataContext>());
                        }));
                  });

            typeof(Service.Attendance.IAttendanceService)
                .Assembly
                .GetExportedTypes()
                .Where(x => x.GetInterfaces().Any())
                .ToList()
                .ForEach(service =>
                {
                    var _interface = service.GetInterfaces().First();
                    container.RegisterType(_interface, service, new PerRequestLifetimeManager());
                });
        }
    }
}
