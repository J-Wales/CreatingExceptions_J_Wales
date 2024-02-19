using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions
{
    internal class Circle
    {
        // Create the Radius double.
        public double Radius;

        // Create the SetRadius() method.
        public void SetRadius(double radius)
        {
            // Check if the value of Radius is less than or equal to 0.
            if (radius <= 0)
            {
                // Throw the InvalidRadiusException constructor which accepts an argument.
                throw new InvalidRadiusException(radius);
            }
            // Otherwise (if the value of Radius is greater than 0).
            else
            {
                // Throw the InvalidRadiusException constructor which accepts no arguments.
                Radius = radius;
                throw new InvalidRadiusException();
            }
        }

        // Create the ToString() method.
        public override string ToString()
        {
            // Return the radius of the object.
            return $"Radius: {Radius}";
        }
    }
}
