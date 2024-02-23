using System;
namespace ProcessingOfTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
                
            Console.WriteLine("Adding of two Numbers"+Numbers.Add(100,20));
            Console.WriteLine("Subtract OF TWO Number"+ Numbers.Subtract(100,20));
            Console.WriteLine("Multiply OF Two Number "+ Numbers.Multiply(100,20));
            Console.WriteLine("Division of Two Number "+ Numbers.Divide(100,20));
            Console.ReadKey();

            
        }
    }
}