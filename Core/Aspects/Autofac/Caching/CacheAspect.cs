using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        public CacheAspect(int duration = 60) //default olarak cache'de tutma süresi
        {
            _duration = duration;

            //bu ctor aspect olduğundan dolayı injection yapamıyoruz. dolayısıyla service tool kullanarak injecte edebiliriz=> hangi cacheManager kullandığım söylemeliyim

            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation) //methodInterceptiondan getirdik
        {
            //ReflectedType.FullName : Business.Concrete.IProductService.GetAll(parametre1,parametre2)
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}");//reflection konusundan

            //metod parametrelerini listeye çevir. ve metoda iave et parametre yoksa null geç
            var arguments = invocation.Arguments.ToList();

            string key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})";

            //böyle bir cache anahtarı var mı??
            if (_cacheManager.IsAdd(key))
            {
                //invocation.ReturnValue : metodu hiç çalıştırmadan geri döndür
                invocation.ReturnValue = _cacheManager.Get(key);
                return;
            }

            //yoksa metodu devam ettir
            invocation.Proceed();

            //daha önce birşey eklenmemiş olduğundan bunu cache ekle.
            _cacheManager.Add(key, invocation.ReturnValue, _duration);
        }
    }
}
