using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP3
{
    public class Frog : Animals, ISound
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {

        }
    }
}