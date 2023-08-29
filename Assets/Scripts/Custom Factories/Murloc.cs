using UnityEngine;
using Zenject;

public class Murloc : IEnemy
{
    public Murloc()
    {
        Message();
    }
    public void Message()
    {
        Debug.Log("Mrglwglwlg!");
    }
    
    public class Factory : PlaceholderFactory<Murloc> //Можно ли это прописать где-то 1 раз?
    {
    }
}
