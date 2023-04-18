using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Circle:Figure
    {
        private double _radius;
        public Circle(double radius) 
        {
            _radius= radius;
        }

        public override double CalcSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);    
        }
    }
}
