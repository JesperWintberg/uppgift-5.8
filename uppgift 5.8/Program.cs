using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] siffror = { 12, 384, 36, 21, 46 };

            for(int i = 0; i < siffror.Length; i++)
            {

                string kråka = siffror[i].ToString();

                char[] fågel = kråka.ToCharArray();

                

                for(int j = 0; j < fågel.Length; j++)
                {
                    Thread.Sleep(500);
                    Console.Write(fågel[j]);   
                }
                Console.WriteLine();
                Thread.Sleep(1000);

            }


        }
    }
}

