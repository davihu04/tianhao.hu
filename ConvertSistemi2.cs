using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = new bool[] {true,true,false,false};
            int[] dp=new int[] {1,2,3,4};
            int numero=3775;
            Console.WriteLine(Convert_Binario_To_Intero(ref b));
            Console.WriteLine(Convert_Decimale_Puntato_To_Intero(dp));
            foreach(int n in Convert_Binario_To_Decimale_Puntato(ref b)) 
            {
                Console.Write($"{n}.");
            }
            Console.WriteLine();
            foreach(bool n in Convert_Decimale_Puntato_To_Binario(dp))
            {
                Console.Write($"{Convert.ToInt32(n)}.");
            }
            Console.WriteLine();
            foreach (int n in Convert_Numero_Decimale_To_Decimale_Puntato(numero))
            {
                Console.Write($"{n}.");
            }
            Console.WriteLine();
            foreach (bool n in Convert_Numero_Decimale_To_Binario(numero))
            {
                Console.Write($"{Convert.ToInt32(n)}.");
            }
            Console.ReadLine();
        }
        static int Convert_Binario_To_Intero(ref bool[] b)
        {
            int decimale=0,esponente=b.Length-1;
            for (int i=0;i<b.Length;i++)
            {
                decimale = decimale + Convert.ToInt32(Convert.ToInt32(b[i]) * Math.Pow(2,esponente));
                esponente--;
            }
            return decimale;
        }
        static int Convert_Decimale_Puntato_To_Intero(int[] dp)
        {
            int decimale = 0,esponente=dp.Length-1;
            for(int i = 0; i < dp.Length; i++)
            { 
                decimale=decimale + Convert.ToInt32(dp[esponente]*Math.Pow(256,i));
                esponente--;
            }
            return decimale;
        }
        static int[] Convert_Binario_To_Decimale_Puntato(ref bool[] b)
        {
            int[] decimaleP=new int[4];
            int decimale;
            decimale = Convert_Binario_To_Intero(ref b);
            for(int i = 0; i < b.Length; i++)
            {
                decimaleP[3 - i] = decimale % 256;
                decimale = decimale / 256;
            }
            return decimaleP;
        }
        static bool[] Convert_Decimale_Puntato_To_Binario(int[] dp)
        {
            bool[] binario = new bool[32];
            int decimale;
            decimale = Convert_Decimale_Puntato_To_Intero(dp);
            for(int i = 0; i < binario.Length; i++)
            {
                binario[31 - i] = Convert.ToBoolean(decimale % 2);
                decimale = decimale / 2;
            }
            return binario;
        }
        static int[] Convert_Numero_Decimale_To_Decimale_Puntato(int numero)
        {
            int[] decimaleP= new int[4];
            for (int i = 0; i < decimaleP.Length; i++)
            {
                decimaleP[3 - i] = numero % 256;
                numero = numero / 256;
            }
            return decimaleP;

        }
        static bool[] Convert_Numero_Decimale_To_Binario(int numero)
        {
            bool[] binario = new bool[32];
            for (int i = 0; i < binario.Length; i++)
            {
                binario[31 - i] = Convert.ToBoolean(numero % 2);
                numero = numero / 2;
            }
            return binario;
        }

    }
}
