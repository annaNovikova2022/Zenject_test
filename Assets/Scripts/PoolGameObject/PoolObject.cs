using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    readonly CubeObject.Pool _cubeObjectPool;
    readonly List<CubeObject> _cubes = new List<CubeObject>();

    public PoolObject(CubeObject.Pool cubeObjectPool)
    {
        _cubeObjectPool = cubeObjectPool;
    }

    public void AddFoo()
    {
        float maxSpeed = 10.0f;
        float minSpeed = 1.0f;

        _cubes.Add(_cubeObjectPool.Spawn(
            Random.onUnitSphere * Random.Range(minSpeed, maxSpeed)));
    }

    public void RemoveFoo()
    {
        var foo = _cubes[0];
        _cubeObjectPool.Despawn(foo);
        _cubes.Remove(foo);
    }
}

