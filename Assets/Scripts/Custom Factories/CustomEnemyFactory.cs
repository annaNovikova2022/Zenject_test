using UnityEngine;
using Zenject;

public class CustomEnemyFactory : IFactory<IEnemy>
{
    DiContainer _container;
    
    public CustomEnemyFactory(DiContainer container)
    {
        _container = container;
    }

    public IEnemy Create()
    {
        int rand = Random.Range(0, 10);
        if (rand > 7)
        {
            return _container.Instantiate<Dragon>();
        }

        return _container.Instantiate<Murloc>();
    }
}
