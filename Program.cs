# diziler
using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] ="mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // döngüler dizi kullanımı
            // klavyeden girilen n tane sayının ortalamasını hesaplayan program
            Console.WriteLine("lütfen dizinin eleman sayisini giriniz: ");
            int diziuzunluğu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunluğu];

            for (int i = 0; i < diziuzunluğu; i++)
            {
                Console.Write("lütfen {0}.sayısını giriniz",i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }

                int toplam=0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
                Console.WriteLine("ortalama :"+toplam/diziuzunluğu);
                
            }


            

        }
    }
}
