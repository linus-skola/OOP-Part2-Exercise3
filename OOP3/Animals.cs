using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Animals : ISound
    {
        private int age = 0;
        private string name;
        private Gender gender;


        public Animals()
        {

        }

        public Animals(int age, string name)
        {
            this.age = Age;
            this.name = Name;
            this.Gender = Gender.undefined;
        }


        public Animals(int age, string name, Gender gender) // : this(age, name)
        {
            this.age = Age;
            this.name = Name;
            this.gender = Gender;
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
            Console.WriteLine("Psss...");
        }

        protected string ToString(string option)
        {
            return string.Format("Name: {0} {1} {2}\n", this.name, this.age, this.gender);
        }
    }
}