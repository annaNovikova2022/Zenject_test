using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolObjectFactory : MonoBehaviour
{ 
    readonly CubeObjectPoolFactory.Factory _cubeObjectFactory;
    readonly List<CubeObjectPoolFactory> _cubes = new List<CubeObjectPoolFactory>();

    public PoolObjectFactory(CubeObjectPoolFactory.Factory cubeObjectFactory)
    {
        _cubeObjectFactory = cubeObjectFactory;
    }

    public void AddFoo()
    {
        float maxSpeed = 10.0f;
        float minSpeed = 1.0f;

        var cube = _cubeObjectFactory.Create(
            Random.onUnitSphere * Random.Range(minSpeed, maxSpeed));

        cube.transform.SetParent(null);

        _cubes.Add(cube);
    }

    public void RemoveFoo()
    {
        if (_cubes.Any())
        {
            var cube = _cubes[0];
            cube.Dispose();
            _cubes.Remove(cube);
        }
    }
}