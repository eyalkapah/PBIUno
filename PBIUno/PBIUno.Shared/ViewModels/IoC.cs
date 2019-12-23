using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace PBIUno.Shared.ViewModels
{
    public class IoC
    {
        private static IServiceProvider _provider;

        public static void SetServiceProvider(IServiceProvider provider)
        {
            _provider = provider;
        }

        public static T Resolve<T>() where T : class
        {
            return _provider.GetService<T>();
        }

        public static Type Resolve(Type type)
        {
            return (Type)_provider.GetService(type);
        }
    }
}