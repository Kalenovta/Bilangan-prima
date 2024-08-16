using System;

namespace BilanganPrima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikasi ");
            Console.WriteLine(" List Bilangan Prima");
            Console.WriteLine("--------------------------------------------------------------------------------:");
            Console.WriteLine("Nama:Kalenovta Khoirul Anwar");
            Console.WriteLine("No.Absen:12");
            Console.WriteLine("Kelas:X PPLG");

            for (int bilangan = 2; bilangan <= 1000; bilangan++)//Menetapkan bilangan prima menjadi isPrimme dan membuat isPrime menjadi true
            {
                bool isPrima = true;//Menetapkan bilangan prima menjadi isPrimme dan membuat isPrime menjadi true

                for (int pembagi = 2; pembagi <= Math.Sqrt(bilangan); pembagi++)//Melakukan loop dari 2 hingga ke akar kuadrat dari num
                {
                    if (bilangan % pembagi == 0)//Jika num habis dibagi oleh angka di dalam loop
                    {
                        isPrima = false;//Maka isPrime diatur menjadi false
                        break;//Maka akan di berhentikan
                    }
                }

                if (isPrima)//Jika setelah melakukan loop isPrime masih true
                {
                    Console.WriteLine(bilangan + " ");//Maka num yang telah di filter akan ditampilkan ke dalam list bilangan prima pada console
                }
            }
        }
    }
}