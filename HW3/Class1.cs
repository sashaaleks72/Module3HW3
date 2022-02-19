using System;

namespace HW3
{
    public class Class1
    {
        public Action<bool> DelegateForShowMethod { get; set; }

        public int Multiply(int value1, int value2) => value1 * value2;
    }
}
