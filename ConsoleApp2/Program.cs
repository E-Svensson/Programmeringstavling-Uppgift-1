using System;

namespace Tävling
{
    class Program
    {
        static void Main(string[] args)
        {
            int AntalMorötter = 40;

            int Loop = 1;

            int TorsAntal = 0;
            int MorsAntal = 0;

            Console.Write("Tors tid?: "); int TorsTid = int.Parse(Console.ReadLine());
            Console.Write("Mors tid?: "); int MorsTid = int.Parse(Console.ReadLine());

            while (AntalMorötter >= 1)
            {
                if (AntalMorötter == 1 && Loop % TorsTid == 0 && Loop % MorsTid == 0)
                {
                    AntalMorötter--;
                }
                else if (Loop % TorsTid == 0 && Loop % MorsTid == 0)
                {
                    TorsAntal++;
                    AntalMorötter--;
                    MorsAntal++;
                    AntalMorötter--;
                }
                else if (Loop % TorsTid == 0)
                {
                    TorsAntal++;
                    AntalMorötter--;
                }
                else if (Loop % MorsTid == 0)
                {
                    MorsAntal++;
                    AntalMorötter--;
                }

                Loop++;
            }

            Console.WriteLine($"Svar:\n- Tor: {TorsAntal}\n- Mor: {MorsAntal}");
        }
    }
}
