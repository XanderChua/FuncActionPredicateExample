using System;

namespace FuncActionPredicateExample
{
    //Action => enter a number, it should display square of input
    //Function => return the perfect square(100) -> returns 10
    //Predicate => 100 -> 10 return true if perfect square.

    class Program
    {
        //public delegate void del();
        static void Main(string[] args)
        {
            //Func_Examples();
            //Action_Examples();
            //Predicate_Examples();

            Console.WriteLine("Enter perfect square input:");
            int a = Int32.Parse(Console.ReadLine());

            Action<int> action1 = (a) =>
            {
                Console.WriteLine("Action: SqRoot of " + a + " is: " + Math.Sqrt(a));
            };
            action1(a);

            Func<int, double> func1 = (a) =>
            {
                return Math.Sqrt(a);
            };
            Console.WriteLine("Function: SqRoot of " + a + " is: " + func1(a));

            Predicate<int> predicate1 = (a) =>
            {
                if ((Math.Sqrt(a) % 1) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            Console.WriteLine(predicate1(a));

        }
        private static void Predicate_Examples()
        {
            Predicate<string> predicate = (str) =>
            {
                if (str.Length > 10)
                {
                    return true;
                }
                return false;
            };
            Predicate<int> predicate1 = (a) =>
            {
                if (a < 0)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(predicate("str"));
            Console.WriteLine(predicate("thisisstringstr"));
            Console.WriteLine(predicate1(9));
        }
        private static void Action_Examples()
        {
            Action action = () => { Console.WriteLine("This is an empty action"); };
            Action<int, int> action1 = (a, b) =>
            {
                Console.WriteLine("Product of a and b is: " + (a * b));
            };
            Action<double, double> action2 = (a, b) =>
            {
                Console.WriteLine("Product of a and b is: " + (a * b));
            };

            action();
            action1(10, 20);
            action2(10.5, 11.9);
        }
        private static void Func_Examples()
        {
            Func<int, int, int> func = sum;
            Func<int> func1 = returnConstantValue;
            Func<int, int> func2 = (a) => { return a + 100; };
            Func<int, bool> isNegative = (a) =>
            {
                if (a < 0)
                {
                    return true;
                }
                return false;
            };

            Console.WriteLine(func(10, 20));
            Console.WriteLine(func1());
            Console.WriteLine(func2(10));
            Console.WriteLine(isNegative(10));
            Console.WriteLine(isNegative(-10));
        }
        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int returnConstantValue()
        {
            return 100;
        }
    }
}
