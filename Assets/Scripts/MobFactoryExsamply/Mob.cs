using UnityEngine;
using Zenject;

public class Mob : MonoBehaviour
{
    readonly MobView _mobView;

    public Mob(MobView mobView)
    {
        _mobView = mobView;
    }

    public class Factory : PlaceholderFactory<Mob>
    {
    }
}
