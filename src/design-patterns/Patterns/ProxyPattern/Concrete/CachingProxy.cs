using design_patterns.Patterns.ProxyPattern.Abstract;
using System.Runtime.Caching;

namespace design_patterns.Patterns.ProxyPattern.Concrete
{
    public class CachingProxy : ISubject
    {
        private ISubject _realSubject;
        private string _cacheKey { get;  } = "cacheKey";
        public CachingProxy(ISubject realSubject)
        {
            this._realSubject = realSubject;
        }
        public ICollection<string> Request()
        {
            Console.WriteLine("Calling the proxy!");
            ObjectCache cache = MemoryCache.Default;           
            if(cache.Get(_cacheKey) != null)
            {                
                return (ICollection<string>)cache.Get(_cacheKey);
            }
            
            ICollection<string> result = _realSubject.Request();            
            CacheItemPolicy  cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(1);
            cache.Add(_cacheKey, result, cacheItemPolicy);

            return result;
        }
    }
}
