using System; //1'den 10'a kadar olan sayıların kuplerinin toplamını bulan uygulama

namespace Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplamSonucu = 0;
            /*for(int i =  1 ; i <= 10 ; i++)
            {
                toplamSonucu += Math.Pow(i,3); 
            }
            */
            int sayac=1;
            /*
            while(true){
                toplamSonucu += Math.Pow(sayac,3);
                if(sayac==10)
                break;
                sayac++;
            }
            */
            do
            {
                toplamSonucu += Math.Pow(sayac,3);
                sayac++;
            }while(sayac <= 10);
            Console.WriteLine(toplamSonucu);
        }
    }
}
