using System;
using Zenject;

public class FooDisp : IPoolable<IMemoryPool>, IDisposable
{
    IMemoryPool _pool;
    Foo objectFoo;

    public void Dispose()
    {
        _pool.Despawn(this);
    }

    public void OnDespawned()
    {
        _pool = null;
    }

    public void OnSpawned(IMemoryPool pool)
    {
        _pool = pool;
    }

    public class Factory : PlaceholderFactory<FooDisp>
    {
    }
}