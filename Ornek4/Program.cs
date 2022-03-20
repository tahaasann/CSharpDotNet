using System; //Dogum Tarihi verilen kisinin yasini hesaplayan uygulama

namespace Ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Lutfen dogum tarihinizi yaziniz: (ay.gun.yil seklinde) ");
            DateTime dogumTarihi = Convert.ToDateTime(Console.ReadLine());
            
            TimeSpan sonuc = DateTime.Now - dogumTarihi;

            Console.WriteLine(sonuc.Days / 365);
            */
            /*#region Cozum 2
            Console.WriteLine("Lutfen dogum tarihinizi yaziniz: (ay.gun.yil seklinde) ");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());
            DateTime bugun = DateTime.Now;

            int yas = bugun.Year - dogumTarihi.Year;
            if(dogumTarihi > bugun.AddYears(-yas))
                yas--;
            
            Console.WriteLine(yas);
            #endregion
            */

            
            Console.WriteLine("Lutfen dogum tarihinizi yaziniz: (ay.gun.yil seklinde) ");
            DateTime dogumTarihi = DateTime.Parse(Console.ReadLine());

            int gun = (DateTime.Now - dogumTarihi).Days;

            int yas = gun / 365;

            int kalan = gun %365;

            Console.WriteLine($"Yas : {yas} | {yas + 1 } yasiniza kalan gun sayisi: {365 + (yas * 1/4)-kalan}");
                
            

        }
    }
}
