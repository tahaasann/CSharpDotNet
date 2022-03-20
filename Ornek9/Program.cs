using System; //Girilen 3 basamakli bir sayinin basamaklarinin kupleri toplami sayinin kendine esit olup olmadigini bulan uygulama 371

namespace Ornek9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 basamakli bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            
            //Console.WriteLine(Basamak(sayi));
            if(Basamak(sayi))
            {
                int _sayi = sayi;
                double kupToplam = 0;
                while (true)
                {
                    int basamak = _sayi % 10;
                    _sayi /= 10;

                    kupToplam += Math.Pow(basamak,3);

                    if(_sayi <10)
                    {
                        basamak = _sayi % 10;
                        kupToplam += Math.Pow(basamak,3);
                        break;
                    }
                        

                    
                }
                if(kupToplam==sayi)
                    Console.WriteLine("Esittir");

                else
                    Console.WriteLine("Esit Degildir");
            }

        }
        static bool Basamak(int sayi)
        {
            int basamakSayisi = 1;
            while (true)
            {
                basamakSayisi++;
                sayi /= 10;

                if(sayi<10)
                    break;
            }
            return basamakSayisi == 3 ? true : false;
        }
    }
}
