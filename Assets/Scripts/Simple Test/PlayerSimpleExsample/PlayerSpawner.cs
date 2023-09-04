using Zenject;

public class PlayerSpawner : IInitializable
{
    readonly PlayerController.Factory _playerFactory;

    public PlayerSpawner(PlayerController.Factory playerFactory)
    {
        _playerFactory = playerFactory;
    }
    
    public void Initialize()
    {
        var player = _playerFactory.Create();
    }
}
