using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name) : base(age, name)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = Gender.female;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nGender: {2}\n", this.Name, this.Age, this.Gender);
            //return base.ToString("Name: " + this.Name + "\nAge: " + this.Age + "\nGender: " + this.Gender);
        }
    }
}