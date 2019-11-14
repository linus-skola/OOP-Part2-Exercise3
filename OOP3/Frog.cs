using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Frog : Animals
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public override void MakeASound()
        {
            Console.WriteLine("Ribbit ribbit");
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nGender: {2}\n", this.Name, this.Age, this.Gender);
            //return base.ToString("Name: " + this.Name + "\nAge: " + this.Age + "\nGender: " + this.Gender);
        }
    }
}