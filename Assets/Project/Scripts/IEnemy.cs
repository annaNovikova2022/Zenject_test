using UnityEngine;
using Zenject;

namespace Project
{
    public abstract class Enemy: MonoBehaviour
    {
        public abstract void WriteMessage();
        
        [Inject]
        public void Construct()
        {
            WriteMessage();
        }

        void Reset(Vector3 velocity)
        {
            transform.position = Vector3.zero;
        }

        public class Pool : MonoMemoryPool<Vector3, Enemy>
        {
            protected void Reinitialize(Vector3 velocity, Enemy enemy)
            {
                enemy.Reset(velocity);
            }
        }
    }
}
