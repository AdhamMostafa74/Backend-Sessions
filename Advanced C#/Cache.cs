
namespace Advanced_C_;

public class Cache<TKey, TValue>
{
    private class CacheItem
    {
        public TValue Value { get; set; }
        public DateTime Expiration { get; set; }
    }

    private Dictionary<TKey, CacheItem> _cache = new();

    public void Add(TKey key, TValue value, TimeSpan duration)
    {
        _cache[key] = new CacheItem
        {
            Value = value,
            Expiration = DateTime.Now.Add(duration)
        };
    }

    public TValue Get(TKey key)
    {
        if (!_cache.ContainsKey(key))
            return default;

        var item = _cache[key];

        if (DateTime.Now > item.Expiration)
        {
            _cache.Remove(key);
            return default;
        }

        return item.Value;
    }

    public bool Contains(TKey key)
    {
        if (!_cache.ContainsKey(key))
            return false;

        if (DateTime.Now > _cache[key].Expiration)
        {
            _cache.Remove(key);
            return false;
        }

        return true;
    }

    public void Remove(TKey key)
    {
        _cache.Remove(key);
    }
}