using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Animals
    {
        private int age = 0;
        private string name;
        private Gender gender;

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

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public virtual void MakeASound()
        {
            
        }
    }
}