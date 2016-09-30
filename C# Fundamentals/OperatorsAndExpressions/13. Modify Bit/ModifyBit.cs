using System;

class ModifyBit
{
    static void Main(string[] args)
    {
        ulong N = ulong.Parse(Console.ReadLine());
        int P = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        if ((v == 0) && ((P >= 0) && (P < 64)))
        {
            ulong mask = (ulong)~(1 << P);
            ulong result = N & mask;
            Console.WriteLine(result);
        }
        else if (v == 1 && ((P >= 0) && (P < 64)))
        {
            ulong mask = (ulong)1 << P;
            ulong result = N | mask;
            Console.WriteLine(result);
        }
    }
}

