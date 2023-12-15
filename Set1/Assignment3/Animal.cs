namespace Assignment3
{
    public abstract class Animal
    {
        string? _name; /* added the nullable to supress a warning */

        public void setName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name!;
        }

        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog is Eating");
        }
    }

    static class AnimalTest
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.setName("Smeagol");
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}