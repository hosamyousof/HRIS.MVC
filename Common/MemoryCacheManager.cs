using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MemoryCacheManager : IMemoryCacheManager
    {
        private static readonly object _syncObject = new object();

        protected ObjectCache Cache
        {
            get
            {
                return MemoryCache.Default;
            }
        }

        public IEnumerable<string> CacheList()
        {
            return Cache.Select(x => x.Key).Where(x => !(x ?? "").StartsWith("MetadataPrototypes")).OrderBy(x => x).ToList();
        }

        public void Clear()
        {
            foreach (var item in Cache)
                Remove(item.Key);
        }

        public T Get<T>(MemoryCacheKey cacheKey, Func<T> acquire)
        {
            return Get(cacheKey, "", 60, acquire);
        }

        public T Get<T>(MemoryCacheKey cacheKey, object addKey, Func<T> acquire)
        {
            return Get(cacheKey, addKey, 60, acquire);
        }

        private T Get<T>(MemoryCacheKey cacheKey, object addKey, int cacheTime, Func<T> acquire)
        {
            string str_addKey = addKey == null ? "" : addKey.ToString();
            string key = cacheKey.ToString() + (!string.IsNullOrEmpty(str_addKey) ? "-" + str_addKey : "");

            lock (_syncObject)
            {
                if (this.IsSet(cacheKey, addKey))
                {
                    return this.Get<T>(key);
                }

                var result = acquire();
                if (cacheTime > 0)
                    this.Set(key, result, cacheTime);
                return result;
            }
        }

        public bool IsSet(MemoryCacheKey key)
        {
            return IsSet(key, "");
        }

        public bool IsSet(MemoryCacheKey key, object addKey)
        {
            string str_addKey = addKey == null ? "" : addKey.ToString();
            string allKey = key.ToString() + (!string.IsNullOrEmpty(str_addKey) ? "-" + str_addKey : "");
            return (Cache.Contains(allKey));
        }

        public void Remove(MemoryCacheKey key)
        {
            this.Remove(key.ToString());
        }

        public void RemoveStartWith(MemoryCacheKey key)
        {
            string _key = key.ToString();
            var list = this.CacheList().Where(x=> x.StartsWith(_key)).ToList();
            foreach (var item in list)
            {
                this.Remove(item);
            }
        }

        public void Remove(MemoryCacheKey key, object addKey)
        {
            string str_addKey = addKey == null ? "" : addKey.ToString();
            string allKey = key.ToString() + (!string.IsNullOrEmpty(str_addKey) ? "-" + str_addKey : "");
            this.Remove(allKey);
        }

        private T Get<T>(string key)
        {
            return (T)Cache[key];
        }

        private void Remove(string key)
        {
            Cache.Remove(key);
        }

        private void Set(string key, object data, int cacheTime)
        {
            if (data == null)
                return;

            var policy = new CacheItemPolicy();
            policy.AbsoluteExpiration = DateTime.Now + TimeSpan.FromMinutes(cacheTime);
            Cache.Add(new CacheItem(key, data), policy);
        }
    }
}