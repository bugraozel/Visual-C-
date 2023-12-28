using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü sayıyı girin: ");
        int sayi3 = Convert.ToInt32(Console.ReadLine());

        int enBuyuk = EnBuyukBul(sayi1, sayi2, sayi3);

        Console.WriteLine("En büyük sayı: " + enBuyuk);

       
        Console.ReadLine();
    }

    static int EnBuyukBul(int sayi1, int sayi2, int sayi3)
    {
        int enBuyuk = sayi1;

        if (sayi2 > enBuyuk)
        {
            enBuyuk = sayi2;
        }

        if (sayi3 > enBuyuk)
        {
            enBuyuk = sayi3;
        }

        return enBuyuk;
    }
}
