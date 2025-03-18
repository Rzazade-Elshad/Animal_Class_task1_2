using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass
{
    public class Bird : Animal
    {
        public bool CanSwim;
        public string Fly()
        {
            return "fly";
        }
    }
}
