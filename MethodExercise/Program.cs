using System;

namespace MethodExercise
{
    class Program
    {
        //Step 2: Declare 5 Methods -----
        public static int Add(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Rem(int num1, int num2)
        {
            return num1 % num2;
        }
        //Main String -----
        static void Main(string[] args)
        {
            var answer = Add(2, 4);
            var loss = Sub(2, 4);
            var times = Mul(2, 4);
            var parts = Div(2, 4);
            var remain = Rem(2, 4);

            //Step 1: Input/Output Story -----
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, what is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"{color}? That's a nice choice. What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine($"Oh {animal}! I love those! Quick- what's your favorite band!?");
            string band = Console.ReadLine();

            Console.WriteLine($"... oh. {band} That's... interesting. I mean, I'm sure they sound good...");
        }
    }
}
