using System; //Pozitif sayılarda bölme işlemini çıkarma işlemini kullanarak yapan uygulama

namespace Ornek7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Lutfen 1. sayiyi giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen 2. sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int _sayi1 = sayi1;
            
            int sonuc = 0;
            int kalan = 0;
           for (int i = 0; i < _sayi1; i++)
           {
                sayi1 -= sayi2;
                sonuc++;

                if(sayi1<sayi2)
                {
                    kalan = sayi1;
                    break;
                }
           }
           Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc} | Kalan = {kalan}");
            */
            Console.WriteLine("Lutfen 1. sayiyi giriniz");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen 2. sayiyi giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int sayac = sayi1;
            int _sayi1 = sayi1;
            int sonuc = 0, kalan = 0;
            while (true)
            {
                sayi1 -= sayi2;
                sonuc++;
                if(sayi1 < sayi2)
                {
                    kalan = sayi1;
                    break;
                }

                //sayac--;
            }
            Console.WriteLine($"{_sayi1} / {sayi2} = {sonuc} | Kalan = {kalan}");


        }
    }
}
