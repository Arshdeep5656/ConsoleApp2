using System;

namespace ConsoleApp5
{
    class Program
    {
        static int i = 0;
        static void Main(string[] args)
        {
            MethodA();
        }

        static void MethodA()
        {
            while (Peanut())
            {
                if (i > 10)
                {
                    return;
                }
            }
        }

        static bool Peanut()
        {
            i++;
            return true;

        }

    }
}