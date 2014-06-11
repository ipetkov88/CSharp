using System;

class House
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        string dots = "";
        string dotsInside = "";
        string asteriks = "";
        
        for (int i = 0; i <= N / 2; i++)
        {
            dots = new string('.', N / 2 - i);
            if (i == 0)
            {
                asteriks = new string('*', 1);
                dotsInside = "";
                Console.WriteLine(dots + asteriks + dots);
            }
            else if (i > 0 && i < N / 2)
            {
                asteriks = new string('*', 1);
                dotsInside = new string('.', (2 * i) - 1);
                Console.WriteLine(dots + asteriks + dotsInside + asteriks + dots);
            }
            else
            {
                asteriks = new string('*', N);
                Console.WriteLine(asteriks);
            }
        }

        dots = "";
        dotsInside = "";
        asteriks = "";

        for (int i = 1; i <= N / 2; i++)
        {
            if (i >= 1 && i < N / 2)
            {
                dots = new string('.', N / 4);
                dotsInside = new string('.', N - 2*(N/4) - 2);
                asteriks = new string('*', 1);
                Console.WriteLine(dots + asteriks + dotsInside + asteriks + dots);
            }
            else //last row
            {
                dots = new string('.', N / 4);
                asteriks = new string('*', N - 2 * (N / 4));
                Console.WriteLine(dots + asteriks + dots);
            }
            {

            }
        }

    }
}
