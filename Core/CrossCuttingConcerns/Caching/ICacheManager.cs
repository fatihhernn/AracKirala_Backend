using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);

        //cache'de var mı kontrolu sağlar
        bool IsAdd(string key);
        void Remove(string key);

        //içinde get olanları uçur
        void RemoveByPattern(string pattern);
    }
}
