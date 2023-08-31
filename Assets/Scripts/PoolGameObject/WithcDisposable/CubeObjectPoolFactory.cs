using System;
using UnityEngine;
using Zenject;

public class CubeObjectPoolFactory : MonoBehaviour, IPoolable<Vector3, IMemoryPool>, IDisposable
{
    Vector3 _velocity;
    IMemoryPool _pool;

    public void Dispose()
    {
        _pool.Despawn(this);
    }

    public void Update()
    {
        transform.position += _velocity * Time.deltaTime;
    }

    public void OnDespawned()
    {
        _pool = null;
        _velocity = Vector3.zero;
    }

    public void OnSpawned(Vector3 velocity, IMemoryPool pool)
    {
        transform.position = Vector3.zero;
        _pool = pool;
        _velocity = velocity;
    }

    public class Factory : PlaceholderFactory<Vector3, CubeObjectPoolFactory>
    {
    }
}
