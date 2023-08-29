using Zenject;

public interface IEnemy
{
    public void Message();
    public class Factory : PlaceholderFactory<IEnemy> 
    {
    }
}