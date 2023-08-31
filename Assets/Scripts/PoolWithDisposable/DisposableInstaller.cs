using Zenject;

public class DisposableInstaller : MonoInstaller<DisposableInstaller>
{
    public override void InstallBindings()
    {
        Container.BindFactory<FooDisp, FooDisp.Factory>().
            FromPoolableMemoryPool(x => x.WithInitialSize(2));
    }
}

