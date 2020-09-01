using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Web.Services.Description;

namespace netcoreCommon
{
    public interface IUser
    {
        string GetUser();
    }
    public class Class12 : IUser
    {
        public IHttpContextAccessor httpContextAccessor { get; private set; }
        public Class12(IHttpContextAccessor httpContext)
        {
            httpContextAccessor = httpContext;
        }
        public string GetUser()
        {
            var query = httpContextAccessor.HttpContext.Request.Query;
            return query["id"];
        }
    }
    public static class GetUser
    {
        public static ServiceProvider serviceProvider;
        public static IServiceCollection serviceCollection;
        public static void Get(IServiceCollection service)
        {
            serviceCollection = service;
        }
        public static T GetU<T>()
        {

            serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider.GetRequiredService<T>();
            
        }
    }

}
