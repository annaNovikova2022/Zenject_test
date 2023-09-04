using Zenject;

public class GameController : IInitializable
{
    readonly EnemyFactory _enemyFactory;

    public GameController(EnemyFactory enemyFactory)
    {
        _enemyFactory = enemyFactory;
    }

    public void Initialize()
    {
        var enemy = _enemyFactory.Create();
    }
}


