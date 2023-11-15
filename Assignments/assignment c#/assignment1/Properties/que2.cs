using System;
using static System.Console;

namespace assignment1
{
    class que2
    {
        static void Main (string []args)
        {
            int a = Convert.ToInt32 (ReadLine());
            if (a > 0)
            {
                WriteLine("+ve");
                return;

            }
            else if (a < 0)
            {
                WriteLine("-ve");
                return;
            }
            

        }
    }
}
