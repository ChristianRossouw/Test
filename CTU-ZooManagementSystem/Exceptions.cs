using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTU_ZooManagementSystem
{
    public class InvalidAnimalTypeException : Exception
    {
        public InvalidAnimalTypeException()
        {
        }

        public InvalidAnimalTypeException(string message)
            : base(message)
        {
        }

        public InvalidAnimalTypeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
