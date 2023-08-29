using Zenject;

public class EnemyInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<GameController>()
            .AsSingle();
        Container.BindFactory<IEnemy, EnemyFactory>()
        .FromFactory<CustomEnemyFactory>();
    }
}