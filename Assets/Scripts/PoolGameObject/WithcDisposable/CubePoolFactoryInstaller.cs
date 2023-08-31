using UnityEngine;
using Zenject;

public class CubePoolFactoryInstaller : MonoInstaller
{
    public GameObject FooPrefab;

    public override void InstallBindings()
    {
        Container.Bind<PoolObjectFactory>().AsSingle();

        Container.BindFactory<Vector3, CubeObjectPoolFactory, CubeObjectPoolFactory.Factory>().FromMonoPoolableMemoryPool(
            x => x.WithInitialSize(2).FromComponentInNewPrefab(FooPrefab).UnderTransformGroup("FooPool"));
    }
}
