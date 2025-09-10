// Path: EnterpriseOrderProductApp.Web.App_Start.SimpleInjectorInitializer.cs
// Purpose: DI container’ı başlatır ve tüm bağımlılıkları çözümler
// SOLID: DIP – Controller’lar somut sınıfa değil interface’e bağımlı olur
// AOP Etkileşimi: Interceptor’lar burada tanımlanabilir

using System.Reflection;
using System.Web.Mvc;
using SimpleInjector;
using MVC_Pipeline_Kurumsal.Application.Services;
using MVC_Pipeline_Kurumsal.Infrastructure.Persistence;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using MVC_Pipeline_Kurumsal.App_Start;
// DOĞRU: Dosyanın en üstünde, namespace dışında
using WebActivatorEx;
using MVC_Pipeline_Kurumsal.Domain.Interfaces;

[assembly: PreApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]
namespace MVC_Pipeline_Kurumsal.App_Start
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // EF DbContext
            container.Register<AppDbContext>(Lifestyle.Scoped);

            // Repository kayıtları
            container.Register<ProductRepository>(Lifestyle.Scoped);
            container.Register<OrderRepository>(Lifestyle.Scoped);

            // Service kayıtları
            container.Register<ProductService>(Lifestyle.Scoped);
            container.Register<OrderService>(Lifestyle.Scoped);
            container.Register<ILog, LogService>(Lifestyle.Scoped); // varsa

            // Controller kayıtları
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            // Resolver
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            // var container = new Container();
            // container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            // // Register services
            // container.Register<AppDbContext>(Lifestyle.Scoped);
            // container.Register<ProductService>(Lifestyle.Scoped);
            // container.Register<OrderService>(Lifestyle.Scoped);

            // //container.Register<ProductRepository>(Lifestyle.Scoped);
            // container.Register<IProduct, ProductRepository>(Lifestyle.Scoped);

            // container.Register<OrderRepository>(Lifestyle.Scoped);
            //// container.Register<IOrderService, OrderRepository>(Lifestyle.Scoped);

            // // Register MVC controllers
            // container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            // // Set MVC Dependency Resolver
            // DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
