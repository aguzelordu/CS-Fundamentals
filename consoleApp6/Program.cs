using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {

        static void parola_kontrol(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                throw new Exception("Parola 6-10 karakter aralığında olmalıdır.");
            }

            if (!password.Any(char.IsDigit))   // Rakam olup olmadığını kontrol eder.
            {
                throw new Exception("Parola en az bir rakam içermelidir.");
            }

            if (!password.Any(char.IsLetter))   // Rakam olup olmadığını kontrol eder.
            {
                throw new Exception("Parola en az bir harf içermelidir.");
            }
        }

        static void Main(string[] args)
        {
            // Array
            // int[] sayilar = new int[5];
            // sayilar[0] = 10;

            // Collections
            // non-generic collections  =>  ArrayList  =>  int, string   (dinamik)

            // generic collections  =>  int/string


            /*
            // ArrayList
            ArrayList liste = new ArrayList();     // List<object> liste = new List<object>();    şeklinde de tanımlanır.
            liste.Add(10);
            liste.Add("10");
            liste.Add(null);
            liste.Add(true);

            var liste2 = new ArrayList()
            {
                5,
                "ahmet",
                false,
                4.5,
                null
            };

            liste.AddRange(liste2);
            liste.AddRange(liste2);

            liste.Insert(2, "Utku");
            liste.Remove(null);
            liste.RemoveAt(3);
            liste.RemoveRange(2, 3);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Contains ve IndexOf da kullanılır.
            */

            /*
            // Generic List
            List<int> numbers = new List<int>();
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.AddRange(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }



            List<Product> urunler = new List<Product>();

            urunler.Add(new Product() { Id = 1, Title = "Iphone 14", Price = 40000 });
            urunler.Add(new Product() { Id = 2, Title = "Iphone 15", Price = 50000 });
            urunler.Add(new Product() { Id = 3, Title = "Iphone 16", Price = 60000 });

            urunler.Insert(urunler.Count, new Product() { Id = 4, Title = "Iphone 17", Price = 70000 });

            // urunler.RemoveAt(2);
            urunler.Remove(urunler[2]);

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Title + " => " + urun.Price + " TL");
            }
            */


            // Dictionary
            // Key-Value
            /*
            Dictionary<int, string> plakalar = new Dictionary<int, string>();
            plakalar.Add(34, "İstanbul");
            plakalar.Add(54, "Sakarya");
            plakalar.Add(44, "Malatya");

            Dictionary<int, string> sayilar = new Dictionary<int, string>()
            {
                { 1, "Bir"},
                { 2, "İki"},
                { 3, "Üç"},
                { 4, "Dört"}
            };

            Console.WriteLine(plakalar[34]);

            if (plakalar.ContainsKey(41))
            {
                Console.WriteLine(plakalar[41]);
            }

            foreach (KeyValuePair<int, string> plaka in plakalar)
            {
                Console.WriteLine(plaka.Key, +" " + plaka.Value);
            }

            // Update
            sayilar[1] = "one";
            sayilar.Clear();
            */


            // Exceptions
            /*
            // System.FormatExeption
            Console.Write("1. sayi: ");    // 10a gibi string içeren bir ifade-değer gelirse
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            //System.DividedByZeroException
            Console.Write("2. sayi: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            int sonuc = sayi1 / sayi2;    // sayi2 0 verilirse 0'a bölünemez hatası
            */
            /*
            // System.NullReferenceException
            Urun urun = null;
            Console.WriteLine(urun.UrunAdi);    //
            */


            /*
            // Exception Handling
            try
            {
                Console.Write("1. sayi: ");    // 10a gibi string içeren bir ifade-değer gelirse
                int sayi1 = Convert.ToInt32(Console.ReadLine());


                Console.Write("2. sayi: ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());  // TryParse

                int sonuc = sayi1 / sayi2;    // sayi2 0 verilirse 0'a bölünemez hatası
            }
            catch (FormatException)
            {
                Console.WriteLine("Sayısal bilgileri düzgün giriniz.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("2. Sayı 0 olmamalıdır.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu");
                Console.WriteLine(ex.Message);
            }
            */

            /*
            // Exception Throw
            int sayi = 10;

            if (sayi > 5) ;
            {
                throw new Exception("Sayı 5 ten büyük olamaz.");
            }

            Console.Write("Parola: ");
            string parola = ConsoleApp6.ReadLine();

            try
            {
                parola_kontrol(parola);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            // Debug
            var sayi1 = 10;
            var sayi2 = 20;
            var sonuc = Toplam(sayi1, sayi2);

            static int Toplam(int a, int b)
            {
                var toplam = a + b;
                return toplam;
            }


        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
    }
    class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Price { get; set; }

    }
}
