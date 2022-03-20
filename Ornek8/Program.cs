using System; //Girilen pozitif sayının kaç basamaklı olduğunu söyleyen uygulama

namespace Ornek8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            float sayi = float.Parse(Console.ReadLine());

            int sayac = 0;

            for (; sayi >= 10; )
            {
                sayi /= 10;
                sayac++;
            }
            sayac++;
            Console.WriteLine($"{sayi} sayisinin basamak degeri {sayac}");
            */
            /*
            Console.WriteLine("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int ilkSayi = sayi;
            int sayac = 0;
            for (;;)
            {
                sayi /= 10;
                sayac++;
                if(sayi<10)
                    break;
            }
            sayac++;
            Console.WriteLine($"{ilkSayi} sayisi {sayac} basamaklidir.");
            */
            Console.WriteLine("Lutfen basamak sayisini ogrenmek istediginiz sayiyi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            
            int sayac = BasamakSayisi(sayi);
            sayac++;
            Console.WriteLine($"{sayi} sayisinin basamak sayisi {sayac}");

        }
        static public int BasamakSayisi(int sayi)
        {
            sayi /= 10;
            if(sayi >= 10)
                return 1 + BasamakSayisi(sayi);
            return 1;
        }
    }
}
