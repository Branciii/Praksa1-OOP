using System;
using System.Collections.Generic;

//PascalCase for namespaces 
namespace Animals
{
    // use letter "I" as prefix with name of interface. After letter I, use PascalCase.
    public interface ISpecies {
        //PascalCase for method names
	    String GetClassification()
        /*{Console.Write("interface");} */
        ;
    }

    public interface IHabitat {

        String GetHabitat();
    }

    public interface IEating {
        String GetEatingHabits();
    }

    // PascalCase for class names
    abstract public class Animal : ISpecies, IEating {

        public string Habitat;
        public string Name;
        public string Eating;

        abstract public String GetClassification();

	    abstract public String GetName();

        abstract public String GetEatingHabits();

    }

    public class Shark<T>: Animal, IHabitat {
        public T Size;
        public string EatingHabit;

        public override String GetClassification()
        {
            return "Shark";
        }

        public override String GetName()
        {
            return Name;
        }

        public String GetHabitat()
        {
            return "Water";
        }

        public override String GetEatingHabits()
        {
            return EatingHabit;
        }

    }

    public class Dog : Animal {

        //use camelCase terminology prefix with underscore ( _ ) for private variables
        private double _size;

        public override String GetClassification(){
            return "Dog";
        }

        public override String GetName()
        {
            return Name;
        }

        public override String GetEatingHabits()
        {
            return "Omnivore";
        }

        //camelCase with method arguments
        public void SetSize(double s)
        {
            _size = s;
        } 
    }

    public class Main_method
    {
        static void Main()
        {
            // Animal A = new Animal();

            Shark<int> S = new Shark<int>();
            S.Size = 6;
            S.Name = "Hammerhead";
            S.EatingHabit = "Carnivore";
            
            Console.WriteLine(S.GetName());
            Console.WriteLine(S.GetClassification());
            Console.WriteLine(S.GetHabitat());
            Console.WriteLine(S.GetEatingHabits());
            Console.WriteLine(S.Size);

            Shark<string> S2 = new Shark<string>();
            S2.Size = "0.6096 - 1.524 meters";
            S2.Name = "Bonnethead";
            S2.EatingHabit = "Omnivore";

            Console.WriteLine(S2.GetName());
            Console.WriteLine(S2.GetClassification());
            Console.WriteLine(S2.GetHabitat());
            Console.WriteLine(S2.GetEatingHabits());
            Console.WriteLine(S2.Size);

            Dog D = new Dog();
            D.Name = "Pekingese";
            //D.Size = 0.4; - inaccessible
            D.SetSize(0.4);

            Console.WriteLine(D.GetName());
            Console.WriteLine(D.GetClassification());
            Console.WriteLine(D.GetEatingHabits());
        }
    }
}