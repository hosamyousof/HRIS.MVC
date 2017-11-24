using System;
using System.Collections.Generic;

namespace Common
{
    public interface IMemoryCacheManager
    {
        System.Collections.Generic.IEnumerable<string> CacheList();

        void Clear();

        T Get<T>(MemoryCacheKey cacheKey, Func<T> acquire);

        T Get<T>(MemoryCacheKey cacheKey, object addKey, Func<T> acquire);

        bool IsSet(MemoryCacheKey key);

        bool IsSet(MemoryCacheKey key, object addKey);

        void Remove(MemoryCacheKey key);

        void Remove(MemoryCacheKey key, object addKey);

        void RemoveStartWith(MemoryCacheKey key);
    }
}