using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name) : base(age, name)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = Gender.male;
        }


        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}\nGender: {2}\n", this.Name, this.Age, this.Gender);
            //return base.ToString("Name: " + this.Name + "\nAge: " + this.Age + "\nGender: " + this.Gender);
        }
    }
}