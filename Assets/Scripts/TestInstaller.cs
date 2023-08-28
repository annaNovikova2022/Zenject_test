using UnityEngine;
using Zenject;

public class TestInstaller : MonoInstaller
{
    [SerializeField] private PlayerView playerViewPrefab;
    [SerializeField] private PlayerConfig _playerConfig;
        
    [SerializeField] private MobView mobViewPrefab;
    [SerializeField] private MobConfig _mobConfig;
    
    public override void InstallBindings()
    {
        BindPlayer();
        BindMob();
    }

    private void BindPlayer()
    {
        Container.Bind<PlayerConfig>()
            .FromInstance(_playerConfig);
        var playerView = Container.InstantiatePrefabForComponent<PlayerView>(playerViewPrefab, new RectTransform());
        Container.BindInterfacesAndSelfTo<PlayerView>()
            .FromInstance(playerView)
            .AsSingle();
    }
    
    private void BindMob()
    {
        Container.Bind<MobConfig>().FromInstance(_mobConfig);
        
        Container.BindInterfacesTo<MobSpawner>()
            .AsSingle();
        Container.BindFactory<Mob, Mob.Factory>()
            .FromComponentInNewPrefab(mobViewPrefab)
            .WithGameObjectName("Monster")
            .UnderTransformGroup("Monsters");
    }

}
