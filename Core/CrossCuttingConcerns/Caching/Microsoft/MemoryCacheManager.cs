using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        ICacheManager _cacheManager;
        public MemoryCacheManager()
        {
            //_cacheManager = ServiceTool.ServiceProvider.GetService();
        }
        public void Add(string key, object value, int duration)
        {
            
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public object Get(string key)
        {
            throw new NotImplementedException();
        }

        public bool isAdd()
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveByPattern(string pattern)
        {
            throw new NotImplementedException();
        }
    }
}
