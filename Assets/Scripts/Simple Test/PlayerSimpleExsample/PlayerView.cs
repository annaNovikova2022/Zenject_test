using UnityEngine;
using Zenject;

public class PlayerView : MonoBehaviour
{
    public int HP
    {
        get => _hp;
        set
        {
            _hp = value;
        }
    }

    public Transform Transform => transform;

    private int _hp;

    [Inject]
    private void Construct(PlayerConfig playerConfig)
    {
        HP = playerConfig.HP;
        Debug.Log("Player's HP is " + HP);
    }
}