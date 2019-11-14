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
            Cat[] cats =
            {
                new Cat(10, "Linus", Gender.male),
                new Cat(15, "Pelle")
            };


            //DOGS
            Dog[] dogs =
            {
                new Dog(5, "Danne", Gender.male),
                new Dog(1, "Adam")
            };


            //FROGS
            Frog[] frogs =
            {
                new Frog(2, "Jenne", Gender.female)
            };


            //KITTENS
            Kitten[] kittens =
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


            Console.WriteLine("Animals");
            Console.WriteLine("_______________________________________\nCATS\n");
            PrintArray(cats);
            cats[0].MakeASound();

            Console.WriteLine("_______________________________________\nDOGS\n");
            PrintArray(dogs);
            dogs[0].MakeASound();

            Console.WriteLine("_______________________________________\nFROGS\n");
            PrintArray(frogs);
            frogs[0].MakeASound();

            Console.WriteLine("_______________________________________\nKITTENS\n");
            PrintArray(kittens);
            kittens[0].MakeASound();

            Console.WriteLine("_______________________________________\nTOMCATS\n");
            PrintArray(tomcats);
            tomcats[0].MakeASound();

            Console.ReadKey();
        }

        static void PrintArray(Object[] arr)
        {
            foreach(object item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
