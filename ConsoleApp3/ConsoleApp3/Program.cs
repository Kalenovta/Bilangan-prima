using System;

namespace BilanganPrima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi");
            Console.WriteLine("List Bilangan Prima");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Nama:Kalenovta Khoirul Anwar");
            Console.WriteLine("No.Absen: 12");
            Console.WriteLine("Kelas: X PPLG");

            for (int num = 2; num <= 1000; num++)
            {
                bool isPrime = true;

                // Cek apakah bilangan prima atau bukan
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(num + " ");
                }
            }
        }
    }
}
