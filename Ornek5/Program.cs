using System;  // Girilen sayinin faktoriyelini hesaplayan uygulama

namespace Ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Lutfen bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            for(int i = sayi; i > 0; i--)
            {
                sonuc *= i;    
            }
            Console.WriteLine(sonuc);
            */
            /*
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = 1;
            while(true)
            {
                sonuc *= sayi;
                if(sayi==1)
                break;
                
                sayi--;
            }
            Console.WriteLine(sonuc);
            */
            /*
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sonuc = 1;
            do
            {
                sonuc *= sayi;

                sayi--;
            }while(sayi >0);
            Console.WriteLine(sonuc);
            */
            /*
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            string _sonuc = "";
            while(sayi>0)
            {
                sonuc *= sayi;
                if(sayi !=1)
                _sonuc += $"{sayi} x ";
                else
                _sonuc += $"{sayi} = {sonuc}";
                sayi--;
            }
            Console.WriteLine(_sonuc);
            */
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktoriyel(sayi));
        }
        static int Faktoriyel(int sayi)
        {
            if(sayi>1)
                return sayi * Faktoriyel(--sayi);
            return sayi;
        }
    }
}
