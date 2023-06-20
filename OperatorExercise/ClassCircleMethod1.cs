using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class ClassCircleMethod1
    {
        public static void AreaOfCircle(double radius)
        {
            double area;

            area = (Math.PI * radius * radius);

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
        }
    }
}
