using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Dog : Animals
    {
        public Dog(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void MakeASound()
        {
            Console.WriteLine("Woof woof!");
        }
    }
}