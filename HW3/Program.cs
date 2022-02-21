using System;

namespace HW3
{
    public class Program
    {
        public Class1 Class1 { get; set; }
        public Class2 Class2 { get; set; }

        public void Show(bool result)
        {
            Console.WriteLine(result);
        }

        private static void Main()
        {
            Program program = new Program();
            program.Class1 = new Class1();
            program.Class2 = new Class2();

            program.Class1.DelegateForShowMethod = program.Show;

            program.Class2.Calc(program.Class1.Multiply, 5, 8);

            program.Class1.DelegateForShowMethod(program.Class2.Result(5));
        }
    }
}
