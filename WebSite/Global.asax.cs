using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //创建autofac管理注册类的容器实例
            var builder = new ContainerBuilder();
            //下面就需要为这个容器注册它可以管理的类型
            //builder的Register方法可以通过多种方式注册类型,之前在控制台程序里面也演示了好几种方式了。
            builder.RegisterType<Sqlserver>().As<IDataSource>();

            //builder.RegisterType<DefaultController>().InstancePerDependency();
            //使用Autofac提供的RegisterControllers扩展方法来对程序集中所有的Controller一次性的完成注册
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //生成具体的实例
            var container = builder.Build();
            //下面就是使用MVC的扩展 更改了MVC中的注入方式.
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
    /// <summary>
    /// 数据源操作接口
    /// </summary>
    public interface IDataSource
    {
        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        string GetData();
    }
    /// <summary>
    /// SQLSERVER数据库
    /// </summary>
    class Sqlserver : IDataSource
    {
        public string GetData()
        {
            return "通过SQLSERVER获取数据";
        }
    }
    /// <summary>
    /// ORACLE数据库
    /// </summary>
    public class Oracle : IDataSource
    {
        public string GetData()
        {
            return "通过Oracle获取数据";
        }
    }
}
