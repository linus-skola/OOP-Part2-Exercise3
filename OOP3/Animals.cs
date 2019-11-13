using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Animals
    {
        int age = 0;
        string name;

        public Animals(int age, string name, Gender gender)
        {

        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name can not be empty");
                this.name = value;
            }
        }

        public int Gender
        {
            get => default;
            set
            {
            }
        }

        public void MakeASound()
        {
            
        }
    }
}