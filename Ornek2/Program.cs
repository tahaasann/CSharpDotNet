using System;//Kullanicinin girdigi iki sayinin karelerinin toplami

namespace Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. yontem
            Console.WriteLine("Kareleri alinacak 2 sayiyi giriniz");
            Console.WriteLine("1. sayiyi giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayiyi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi1*sayi1 + sayi2*sayi2);

            //2.Yontem

            //Math.Pow(2,3); 2'nin 3. kuvveti. Pow double doner

            double sonuc = Math.Pow(sayi1,2) + Math.Pow(sayi2,2);

            Console.WriteLine(sonuc);
            */
            //3. Yontem

            Console.WriteLine("Lutfen 1. ve 2. sayiyi giriniz: ");

            double sonuc = Math.Pow(int.Parse(Console.ReadLine()),2) + Math.Pow(int.Parse(Console.ReadLine()),2);

            Console.WriteLine(sonuc);
        }
    }
}
