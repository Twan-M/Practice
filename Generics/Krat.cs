namespace OefenOpdracht4;

public class Krat<T> where T : Fruit
{
    private List<T> fruits = new List<T>();

    public void AddFruit(T fruit)
    {
        fruits.Add(fruit);
    }

    public int AantalFruits()
    {
        return fruits.Count;
    }
}