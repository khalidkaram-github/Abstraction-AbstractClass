namespace Abstraction_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();        // Output: Woof!
            myDog.Sleep();            // Output: The dog is sleeping in its kennel.

            Cat myCat = new Cat();
            myCat.MakeSound();        // Output: Meow!
            myCat.Sleep();            // Output: The animal is sleeping in a default way.
        }
    }
    public abstract class Animal
    {
        // Abstract method (no implementation)
        public abstract void MakeSound();

        // Virtual method (with default implementation)
        public virtual void Sleep()
        {
            Console.WriteLine("The animal is sleeping in a default way.");
        }
    }

    public class Dog : Animal
    {
        // Provide implementation for the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        // Override the virtual method to provide custom behavior
        public override void Sleep()
        {
            Console.WriteLine("The dog is sleeping in its kennel.");
        }
    }

    public class Cat : Animal
    {
        // Provide implementation for the abstract method
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        // Use the default sleep method (no need to override)
    }

}
