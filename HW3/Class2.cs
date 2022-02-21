using System;

namespace HW3
{
    public class Class2
    {
        private int ResultValue { get; set; }

        public Predicate<int> Calc(Func<int, int, int> delegateForMultipleMethod, int value1, int value2)
        {
            ResultValue = delegateForMultipleMethod(value1, value2);

            return new Predicate<int>(Result);
        }

        public bool Result(int value)
        {
            return ResultValue % value == 0;
        }
    }
}
