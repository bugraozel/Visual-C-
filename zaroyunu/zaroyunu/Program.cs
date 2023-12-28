using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace zaroyunu
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Zar Oyununa Hoş Geldiniz!");

            while (true)
            {
                Console.WriteLine("Zar atmak için Enter tuşuna basın...");
                Console.ReadLine();

                int toplam = ZarAt();

                if (toplam == 7 || toplam == 11)
                {
                    Console.WriteLine($"Kazandınız! Toplam: {toplam}");
                }
                else if (toplam == 2 || toplam == 3 || toplam == 12)
                {
                    Console.WriteLine($"Kaybettiniz! Craps! Toplam: {toplam}");
                }
                else
                {
                    Console.WriteLine($"Puanınız {toplam} olarak belirlendi.");

                    while (true)
                    {
                        Console.WriteLine("Zar atmak için Enter tuşuna basın...");
                        Console.ReadLine();

                        int yeniToplam = ZarAt();

                        if (yeniToplam == toplam)
                        {
                            Console.WriteLine($"Kazandınız! Puanınızı yakaladınız: {toplam}");
                            break;
                        }
                        else if (yeniToplam == 7)
                        {
                            Console.WriteLine($"Kaybettiniz! Puanınızı yakalamadan 7 attınız. Toplam: {yeniToplam}");
                            break;
                        }
                    }
                }
            }
        }

        static int ZarAt()
        {
            Random random = new Random();
            int zar1 = random.Next(1, 7);
            int zar2 = random.Next(1, 7);

            int toplam = zar1 + zar2;

            Console.WriteLine($"Zar 1: {zar1}, Zar 2: {zar2}, Toplam: {toplam}");

            return toplam;
        }
    }
}
