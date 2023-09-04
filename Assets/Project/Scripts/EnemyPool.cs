using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Project
{
    public class EnemyPool: MemoryPool<Enemy>
    {
        readonly Enemy.Pool _enemyPool;
        readonly List<Enemy> _enemies = new List<Enemy>();

        public EnemyPool(Enemy.Pool enemyPool)
        {
            _enemyPool = enemyPool;
        }

        public void AddFoo()
        {
            _enemies.Add(_enemyPool.Spawn(Vector3.one));
        }

        public void RemoveFoo()
        {
            var foo = _enemies[0];
            _enemyPool.Despawn(foo);
            _enemies.Remove(foo);
        }
    }
}
