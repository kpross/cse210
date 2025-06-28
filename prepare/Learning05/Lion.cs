// visibility type name : ParentClass
public class Lion : Animal
{
    // because we defined a constructor in the parent class we don't get the free class constructor in the child class so we have to define it ourselves
    //base means go up a level kind of like ..\ in R
    public Lion(string name) : base(name)
    {
    }

    // we use override here to say we don't want the default option (has to be defined as virtual in the parent class)
    public override void MakeSound()
    {
        Console.WriteLine("Roar");
    }
}