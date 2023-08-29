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
    
    public class Factory : PlaceholderFactory<Dragon> //Можно ли это прописать где-то 1 раз?
    {
    }
}
