using System.Collections.Generic;
using UnityEngine;
using Zenject;



public class Bar
{
    readonly Foo.Pool _fooPool;
    readonly List<Foo> _foos = new List<Foo>();

    public Bar(Foo.Pool fooPool)
    {
        _fooPool = fooPool;
    }

    public void AddFoo()
    {
        float maxSpeed = 10.0f;
        float minSpeed = 1.0f;

        _foos.Add(_fooPool.Spawn(
            Random.onUnitSphere * Random.Range(minSpeed, maxSpeed)));
    }

    public void RemoveFoo()
    {
        var foo = _foos[0];
        _fooPool.Despawn(foo);
        _foos.Remove(foo);
    }
}

public class PoolInstaller : MonoInstaller<PoolInstaller>
{
    public GameObject FooPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Bar>().AsSingle();

        Container.BindMemoryPool<Foo, Foo.Pool>()
            .WithInitialSize(2)
            .FromComponentInNewPrefab(FooPrefab)
            .UnderTransformGroup("Foos");
    }
}