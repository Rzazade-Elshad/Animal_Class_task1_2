using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    public class Dog : Animal
    {
        public bool HasTail;
        public string Bark()
        {
            return "Dogs are barking";
        }
    }
}
