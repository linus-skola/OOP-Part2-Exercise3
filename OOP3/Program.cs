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
            List<Cat> cats = new List<Cat>()
            {
                new Cat(10, "Linus", Gender.male)
            };
        }
    }
}
