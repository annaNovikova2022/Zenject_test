using UnityEngine;
using Zenject;

public class ObjectPoolInstaller : MonoInstaller
{
    public GameObject FooPrefab;

    public override void InstallBindings()
    {
        Container.Bind<PoolObject>().AsSingle();

        Container.BindMemoryPool<CubeObject, CubeObject.Pool>()
            .WithInitialSize(2)
            .FromComponentInNewPrefab(FooPrefab)
            .UnderTransformGroup("Foos");
    }
}