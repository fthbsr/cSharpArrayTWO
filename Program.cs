using System;

namespace diziler_sinif_metotlari 
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {12,45,23,44,65,89,56,34,21};

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

           //Siralama 
           Console.WriteLine("Sirali Dizi");
          Array.Sort(sayiDizisi);

          foreach (var sayi in sayiDizisi)
          { 
              
              Console.WriteLine(sayi);
          }


          //Clear

          Console.WriteLine("****Clear Islemi *****");

          Array.Clear(sayiDizisi,2,4);

           foreach (var sayi in sayiDizisi)
          { 
              
              Console.WriteLine(sayi);
          }


          //reverse

          Console.WriteLine("^^^^^Reverse^^^^^");

          Array.Reverse(sayiDizisi);

           foreach (var sayi in sayiDizisi)
          { 
              
              Console.WriteLine(sayi);
          }

          Console.WriteLine("^^^^^IndexOf^^^^^");

          Console.WriteLine(Array.IndexOf(sayiDizisi , 45));

          Console.WriteLine("^^^^^Resize^^^^^");

          Array.Resize<int>(ref sayiDizisi , 12);
          sayiDizisi[11] = 56;
          Console.WriteLine(sayiDizisi[11]);

        }
    }
}