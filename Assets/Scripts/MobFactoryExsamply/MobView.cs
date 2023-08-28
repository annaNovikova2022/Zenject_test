using UnityEngine;
using Zenject;

public class MobView : MonoBehaviour
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
    private void Construct(MobConfig mobConfig)
    {
        HP = mobConfig.HP;
        Debug.Log("Mob created with " + HP + " HP");
    }
}
