using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        // 3. Rename Class1 to BasicComputation. After that, create four (4) static methods that return the results
        // of Addition, Subtraction, Multiplication, and Division, wherein the data type is a float data type.
        public static float Add(int a, int b)
        {
            return a + b;
        }
        public static float Subtract(int a, int b)
        {
            return a - b;
        }
        public static float Multiply(int a, int b)
        {
            return a * b;
        }
        public static float Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return (float)a / b;
        }
    }
}
