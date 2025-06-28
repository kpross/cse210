using System;


class Program
{
    static void Main(string[] args)
    {
        // Create a list with each shape in it
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle("red", 1));
        shapes.Add(new Square("pink", 3));
        shapes.Add(new Rectangle("green", 3, 4));

        // Cycle through each shape in the list and call each Get...()
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The shape is {color} and has an area of {area}");
        }









        //Console.WriteLine("Hello Learning05 World!");

        // All the Animal stuff is just in class practice
        //    List<Animal> animals = new List<Animal>();
        //    animals.Add(new Lion("Simba"));
        //    animals.Add(new Monkey("Rafiki"));

        //    foreach (Animal animal in animals)
        //    {
        //        animal.MakeSound();
        //    }



        //Lion lion = new Lion("Simba");
        //Monkey monkey = new Monkey("Rafiki");


        //lion.MakeSound();
        // monkey.MakeSound();

        //Lion sayWhat = new Lion("sayWhat");

        //sayWhat.MakeSound();
        //}
        //public void MakeAnimalSOund(Animal animal)
        //{
        //    animal.MakeSound();
        //}

        //public Animal getAnimal()
        //{
        //    return new Lion("Tom");
        //}

    }
}