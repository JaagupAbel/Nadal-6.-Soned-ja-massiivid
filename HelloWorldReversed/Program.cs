using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lause "Hello World!" tagurpidi. 
          
            string lauseHello = "Hello World!";
            

            for (int i = lauseHello.Length - 1; i >= 0; i--)
            {
                Console.Write(lauseHello[i]);
            }

        }
    }
}
