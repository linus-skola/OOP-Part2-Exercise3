using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Cat : Animals
    {
        public Cat(int age, string name, Gender gender) : base(age, name, gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender; 
        }

        public Cat(int age, string name) : base(age, name)
        {
            this.Age = age;
            this.Name = name;
        }

        public override void MakeASound()
        {
            Console.WriteLine("Meeeaaaooooooowwwww!");
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nGender: {2}\n\n", this.Name, this.Age, this.Gender);
        }
    }
}