using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumator_4bitowy_WR
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wejscie1_0=new int[4];
            int wynik = 0;
            var w= metody_bramki.dectobin(13);

            for (int i = 3; i>= 0; i--)
            {
                wejscie1_0[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("pierwsza liczba binarna to:");

            for (int j=3;j>=0;j--)
            {
                Console.Write(wejscie1_0[j]);
            }
            Console.WriteLine();
            int[] wejscie2_0 = new int[4];

            for (int k = 3; k >= 0; k--)
            {
                wejscie2_0[k] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("druga liczba binarna to:");

            for (int m= 3; m>=0; m--)
            {
                Console.Write(wejscie2_0[m]);
            }
            Console.WriteLine();

            metody_bramki metody1 = new metody_bramki();
            Console.WriteLine("a wiec pora je zsumowac...");

            int[] wyjscie = new int[5];
            wyjscie[0] = metody1.XOR(wejscie1_0[0], wejscie2_0[0]);
            wyjscie[1] = metody1.XOR(metody1.XOR(wejscie1_0[1], wejscie2_0[1]), metody1.AND(wejscie1_0[0], wejscie2_0[0]));
            wyjscie[2] = metody1.XOR(metody1.XOR(wejscie1_0[2],wejscie2_0[2]),metody1.NAND3(metody1.NAND(wejscie1_0[1],wejscie2_0[1]),metody1.NAND(metody1.AND(wejscie1_0[0],wejscie2_0[0]),wejscie1_0[1]),metody1.NAND(metody1.AND(wejscie1_0[0],wejscie2_0[0]),wejscie2_0[1])));
            int zmienna_nand3_1 = metody1.NAND3(metody1.NAND(wejscie1_0[1], wejscie2_0[1]), metody1.NAND(metody1.AND(wejscie1_0[0], wejscie2_0[0]), wejscie1_0[1]), metody1.NAND(metody1.AND(wejscie1_0[0], wejscie2_0[0]), wejscie2_0[1]));
            wyjscie[3] = metody1.XOR(metody1.XOR(wejscie1_0[3],wejscie2_0[3]),metody1.NAND3(metody1.NAND(wejscie1_0[2],wejscie2_0[2]),metody1.NAND(zmienna_nand3_1,wejscie1_0[2]),metody1.NAND(zmienna_nand3_1,wejscie2_0[2])));
            int zmienna_nand3_2 = metody1.NAND3(metody1.NAND(wejscie1_0[2], wejscie2_0[2]), metody1.NAND(zmienna_nand3_1, wejscie1_0[2]), metody1.NAND(zmienna_nand3_1, wejscie2_0[2]));
            wyjscie[4] = metody1.NAND3(metody1.NAND(wejscie1_0[3], wejscie2_0[3]),metody1.NAND(zmienna_nand3_2,wejscie1_0[3]),metody1.NAND(zmienna_nand3_2,wejscie2_0[3]));

            for(int n=4; n>=0;n--)
            {
                Console.Write(wyjscie[n]);
            }


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
