namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($" add two numbers = {AddTwoNumbers(1, 1)}");
            Console.ReadKey();
        }


        public static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

    }
}