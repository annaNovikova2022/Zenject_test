using UnityEngine;
using Zenject;

public class PoolInstaller : MonoInstaller<PoolInstaller>
{
    public GameObject FooPrefab;

    public override void InstallBindings()
    {
        Container.BindMemoryPool<Foo, Foo.Pool>()
            .WithInitialSize(2)
            .FromComponentInNewPrefab(FooPrefab)
            .UnderTransformGroup("Foos");
    }
}