using Zenject;

public class MobSpawner : ITickable
{
    readonly Mob.Factory _mobFactory;

    public MobSpawner(Mob.Factory mobFactory)
    {
        _mobFactory = mobFactory;
    }

    public void Tick()
    {
        var mob = _mobFactory.Create();
    }
}
