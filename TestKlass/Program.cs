using System;

namespace TestKlass
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFootball mainBall = new TestFootball();
            TestFootball sideBall = new TestFootball();

            mainBall.x = 50;
            mainBall.y = 30;
            mainBall.z = 0;
            
            System.Console.WriteLine(sideBall.x);
            Console.ReadLine();

        }
    }
}
