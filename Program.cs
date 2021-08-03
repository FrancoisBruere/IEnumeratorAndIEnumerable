using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumeratorAndIEnumerable
{

    public class Dog
    {
        public string Name { get; set; }

        public bool IsNaughtyDog { get; set; }


        public Dog(string name, bool isNaugtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaugtyDog;



        }

        public void GiveTreat(int numberOfTreats)
        {

            Console.WriteLine("Dog: {0} saif woof {1} times!",Name,numberOfTreats);

        }



    }


    public class DogShelter : IEnumerable<Dog>
    {

        public List<Dog> dogs;

        public DogShelter()
        {

            dogs = new List<Dog>()
            {
                new Dog("casper",false),
                new Dog("Oblix",true),
                new Dog("Jele",false)

            };


        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }
}
