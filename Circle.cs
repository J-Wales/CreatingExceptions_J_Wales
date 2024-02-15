using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions_J_Wales
{
    internal class Circle
    {
        double Radius { get; set; }

        public void SetRadius()
        {
            if (Radius <= 0)
            {
                throw new InvalidRadiusException;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
