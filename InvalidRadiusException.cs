using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions
{
    internal class InvalidRadiusException : Exception
    {
        // Create the InvalidRadiusException() which accepts no arguments. Print message that the radius is greater than 0.
        public InvalidRadiusException() : base("Radius is greater than 0.")
        {
        }

        // Create the InvalidRadiusException() which accepts a radius argument. Print message that the radius is invalid.
        public InvalidRadiusException(double radius) : base($"Radius {radius} is invalid")
        {
        }
    }
}
