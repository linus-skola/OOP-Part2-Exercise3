using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CATS
            List<Cat> cats = new List<Cat>()
            {
                new Cat(10, "Linus", Gender.male),
                new Cat(15, "Pelle")
            };


            //DOGS
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(5, "Danne", Gender.male),
                new Dog(1, "Adam")
            };


            //FROGS
            List<Frog> frogs = new List<Frog>()
            {
                new Frog(2, "Jenne", Gender.female)
            };


            //KITTENS
            List<Kitten> kittens = new List<Kitten>()
            {
                new Kitten(3, "Bitte"),
                new Kitten(1, "Helle")
            };


            //TOMCATS
            Tomcat[] tomcats =
            {
                new Tomcat(100, "Sten"),
                new Tomcat(20, "Plura")
            };

            tomcats[0].MakeASound();

            Console.WriteLine("*** CATS ***");
            cats.ForEach(Console.WriteLine);

            Console.WriteLine("*** DOGS ***");
            dogs.ForEach(Console.WriteLine);

            Console.WriteLine("*** FROGS ***");
            frogs.ForEach(Console.WriteLine);

            Console.WriteLine("*** KITTENS ***");
            kittens.ForEach(Console.WriteLine);

            Console.WriteLine("*** TOMCATS ***");
            foreach(object item in tomcats)
            {
                Console.WriteLine(item);
                tomcats[0].MakeASound();
            }

            Console.ReadKey();
        }
    }
}
