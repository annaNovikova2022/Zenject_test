using UnityEngine;using Zenject;

public class PlayerController: MonoBehaviour
{
    readonly PlayerView _playerView;

    public PlayerController(PlayerView playerView)
    {
        _playerView = playerView;
    }

    public class Factory : PlaceholderFactory<PlayerController>
    {
    }
}
