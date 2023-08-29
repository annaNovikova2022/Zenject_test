using UnityEngine;
using Zenject;

public class Dragon : IEnemy
{
    public Dragon()
    {
        Message();
    }
    public void Message()
    {
        Debug.Log("Raaaar!!!");
    }
}
