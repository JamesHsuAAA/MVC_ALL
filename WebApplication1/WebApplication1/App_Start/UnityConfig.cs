using System;
using System.Linq;
using Unity;
using Unity.Injection;
using Unity.RegistrationByConvention;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            //container.RegisterType<ITest, Test>();
            container.RegisterType<ITest, Test>("Test");
            container.RegisterType<ITest, Test2>("Test2");
            container.RegisterType<HomeController>(
                new InjectionConstructor(
                    new ResolvedParameter<ITest>("Test"),
                    new ResolvedParameter<ITest>("Test2")
            ));

            // container.RegisterTypes(
            // //針對所有class Service名稱後有做注入
            // AllClasses.FromLoadedAssemblies()
            ////.Where(t => t.Name.EndsWith("Service")),
            //.Where(t => t.Namespace == "WebApplication1.Models"),
            // //搜尋所有Interface做Mapping
            // WithMappings.FromAllInterfaces,
            // //可以定義註冊名稱
            // WithName.Default,
            // //指定註冊的生命週期 說明
            // WithLifetime.ContainerControlled);
        }
    }
}