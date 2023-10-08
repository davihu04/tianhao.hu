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
            Console.WriteLine(Convert_Binario_To_Intero(ref b));
            Console.WriteLine(Convert_Decimale_Puntato_To_Intero(dp));
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
    }
}
