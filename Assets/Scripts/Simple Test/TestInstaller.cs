using UnityEngine;
using Zenject;

public class TestInstaller : MonoInstaller
{
    [SerializeField] private PlayerView playerViewPrefab;
    [SerializeField] private MobView mobViewPrefab;
    
    public override void InstallBindings()
    {
        BindPlayer();
        BindMob();
    }

    private void BindPlayer()
    {
        Container.Bind<PlayerConfig>()
            .FromScriptableObjectResource("PlayerConfig")
            .AsSingle();
        
       // var playerView = Container.InstantiatePrefabForComponent<PlayerView>(playerViewPrefab, new RectTransform());
       //Container.BindInterfacesAndSelfTo<PlayerView>()
        //    .FromInstance(playerView)
        //    .AsSingle();

        Container.BindInterfacesTo<PlayerSpawner>()
            .AsSingle();
        Container.BindFactory<PlayerController, PlayerController.Factory>()
            .FromComponentInNewPrefab(playerViewPrefab);

        
    }
    
    private void BindMob()
    {
        Container.Bind<MobConfig>()
            .FromScriptableObjectResource("MobConfig")
            .AsSingle();
       
        Container.BindInterfacesTo<MobSpawner>()
            .AsSingle();
        Container.BindFactory<Mob, Mob.Factory>()
            .FromComponentInNewPrefab(mobViewPrefab)
            .WithGameObjectName("Monster")
            .UnderTransformGroup("Monsters");
    }

}
