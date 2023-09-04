using Project;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<EnemyPool>().AsSingle();
        
        Container.BindMemoryPool<Project.Enemy, Project.Enemy.Pool>()
            .WithInitialSize(2)
            .FromComponentInNewPrefabResource("Dragon")
            .UnderTransformGroup("Enemy");
        
        Container.BindMemoryPool<Project.Enemy, Project.Enemy.Pool>()
            .WithInitialSize(3)
            .FromComponentInNewPrefabResource("Murloc")
            .UnderTransformGroup("Enemy");
    }
}