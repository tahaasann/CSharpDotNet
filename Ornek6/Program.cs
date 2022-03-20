using System; //Pozitif sayılarda çarpma işlemini toplama kullanarak bulan uygulamayı yazınız.

namespace Ornek6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("Lutfen 1. sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lutfen 2. sayiyi giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int carpmaSonucu = 0;

            for (int i = 0; i < sayi1; i++)
            {
                carpmaSonucu += sayi2;
            }
            Console.WriteLine($"{sayi1} x {sayi2} = {carpmaSonucu}");
            */

            #region Cozum2
            Console.WriteLine("Lutfen 1. sayiyi giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen 2. sayiyi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sayac= sayi2;
            int sonuc = 0;
            while (sayac>0)
            {
                sonuc += sayi1;
                sayac--;
            }
            Console.WriteLine($"{sayi1} x {sayi2} = {sonuc}");




            #endregion
        }

    }
}
