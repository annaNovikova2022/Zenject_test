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
}
