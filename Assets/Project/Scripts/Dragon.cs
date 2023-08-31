using UnityEngine;

namespace Project
{
    public class Dragon : MonoBehaviour, IEnemy
    {
        private IEnemy _enemyImplementation;

        public void WriteMessage()
        {
            Debug.Log("Raaar!");
        }
    }
}