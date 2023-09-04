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
    private int _hp;

    [Inject]
    private void Construct(MobConfig mobConfig)
    {
        HP = mobConfig.HP;
        Debug.Log("Mob created with " + HP + " HP");
        gameObject.transform.position = new Vector3(Random.Range(-10.0f, 10.0f),Random.Range(-10.0f, 10.0f),Random.Range(-10.0f, 10.0f));
    }
}
