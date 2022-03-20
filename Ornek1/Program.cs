using System;

namespace Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //İki sayinin toplamini veren uygulama
            try
            {
                Console.WriteLine("Lutfen 1. sayiyi giriniz: ");
                //Console.ReadLine();//girilen değeri string tipinde aldığı için sayısal değere çevirmemiz gerekli
                int sayi1 = Convert.ToInt32(Console.ReadLine());//girilen string değeri int tipine çevirme yöntemi 1
                Console.WriteLine("Lutfen 2. sayiyi giriniz: ");
                int sayi2 = int.Parse(Console.ReadLine());// girilen string değeri int tipine çevirme yöntemi 2
            
                Console.WriteLine("Girilen 2 sayinin toplami: ");
                Console.WriteLine(sayi1 + sayi2);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Lutfen dogru bir sayi giriniz ");
                throw;
            }
            
        }
    }
}
