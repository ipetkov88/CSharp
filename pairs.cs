using System;

class Pairs
{
    static void Main()
    {
        string[] Input = Console.ReadLine().Split(' ');
        int tempvalue=0;
        int prevValue=0;
        int value=0;
        int maxxdif = 0;
        int curMaxxdif = 0;

        bool OutputYesNo = true;

        if (Input.Length == 2)
        {
            OutputYesNo = true;
            prevValue = int.Parse(Input[0]) + int.Parse(Input[1]);
        }
        else
        {
            for (int i = 0; i < Input.Length; i++)
            {
                tempvalue += int.Parse(Input[i]);
                if (i > 1)
                {
                    if (i % 2 == 0)
                    {
                        prevValue = int.Parse(Input[i - 2]) + int.Parse(Input[i - 1]);
                    }
                }
                else
                {
                    prevValue = tempvalue;
                }


                if (i % 2 == 1)
                {
                    if (tempvalue != prevValue)
                    {
                        OutputYesNo = false;
                        curMaxxdif = Math.Abs(tempvalue - prevValue);
                        if (curMaxxdif > maxxdif)
                        {
                            maxxdif = curMaxxdif;
                        }
                    }
                    tempvalue = 0;
                }

            } 
        }
        

        Console.Write(OutputYesNo ? "Yes" : "No");
        if (OutputYesNo)
        {
            Console.WriteLine(", value={0}", prevValue);
        }
        else
        {
            Console.WriteLine(", maxdiff={0}", maxxdif);
        }
        
    }
}
