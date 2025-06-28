public class Animal
{
    private string _name;

    // constructor
    public Animal(string name)
    {
        _name = name;
    }

    public virtual void MakeSound()
    {
        // Do Something
        Console.WriteLine("Hello World ");
    }
}