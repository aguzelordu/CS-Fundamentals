using System;     // System namespace adındaki methodlara da ulaşırım.

namespace ConsoleApp5     // namespace class'ları gruplayan bir kavram
{
    class Program
    {
        static void Main(string[] args)    // Projenin başlangıç yeridir burası
        {
            /*
            System.Console.WriteLine("Merhaba!!!");
            */


            /*
            // class => object (gor1, ogr2)

            Ogrenci ogr1 = new Ogrenci();
            ogr1.OgrenciNo = "200";
            ogr1.AdSoyad = "Ayça Yıldız";
            ogr1.Sube = "6/A";
            
            Ogrenci ogr2 = new Ogrenci();
            ogr2.OgrenciNo = "300";
            ogr2.AdSoyad = "Raşit Kalyon";
            ogr2.Sube = "7/B";
            
            Ogrenci ogr3 = new Ogrenci();
            ogr3.OgrenciNo = "400";
            ogr3.AdSoyad = "Jülide Kalkan";
            ogr3.Sube = "7/B";
            
            Ogrenci[] ogrenciler = new Ogrenci[3];
            ogrenciler[0] = ogr1;
            ogrenciler[1] = ogr2;
            ogrenciler[2] = ogr3;
            
            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine($"{ogr.OgrenciNo} numaralı öğrencinin {ogr.AdSoyad} ve şubesi {ogr.Sube}");
            }
            // Console.WriteLine($"{ogr1.OgrenciNo} numaralı öğrencinin {ogr1.AdSoyad} ve şubesi {ogr1.Sube}");
            // Console.WriteLine($"{ogr2.OgrenciNo} numaralı öğrencinin {ogr2.AdSoyad} ve şubesi {ogr2.Sube}");
            // Console.WriteLine($"{ogr3.OgrenciNo} numaralı öğrencinin {ogr3.AdSoyad} ve şubesi {ogr3.Sube}");
            */

            /*
            // Aynısı
            Ogrenci ogr1 = new Ogrenci() { OgrenciNo = "200", AdSoyad = "Ayça Yıldız", Sube = "6/A" };
            Ogrenci ogr2 = new Ogrenci() { OgrenciNo = "300", AdSoyad = "Raşit Kalyon", Sube = "7/B" };
            Ogrenci ogr3 = new Ogrenci() { OgrenciNo = "400", AdSoyad = "Jülide Kalkan", Sube = "7/B" };

            Ogrenci[] ogrenciler = new Ogrenci[3] { ogr1, ogr2, ogr3 };

            foreach (var ogr in ogrenciler)
            {
                ogr.BilgileriYazdir();
            }
            // ogr1.BilgileriYazdir();
            // ogr2.BilgileriYazdir();
            // ogr3.BilgileriYazdir();
            */


            /*
            // Soru Uygulamnası
            var soru1 = new Soru()
            {
                SoruMetni = "Hangisi programlama dili değildir?",
                Secenekler = new string[4] { "Python", "C#", "Java", "Markdown" },
                Cevap = "Markdown"
            };

            var soru2 = new Soru()
            {
                SoruMetni = "C# dilinde değişken tanımlarken hangi anahtar kelime kullanılır?",
                Secenekler = new string[4] { "define", "let", "var", "switch" },
                Cevap = "var"
            };

            var soru3 = new Soru(3)
            {
                SoruMetni = "Hangisi C#'ta bir koşul ifadesidir?",
                Secenekler = new string[4] { "if", "for", "while", "bool" },
                Cevap = "if"
            };

            var sorular = new Soru[] { soru1, soru2, soru3 };

            foreach (var soru in sorular)
            {
                Console.WriteLine(soru.SoruMetni);
                foreach (var secenek in soru.Secenekler)
                {
                    Console.WriteLine(secenek);
                }
                Console.WriteLine();

                // kullanıcıdan cevap alma
                Console.Write("Cevabınız: ");
                var cevap = Console.ReadLine();

                if (soru.CevapKontrol(cevap))
                {
                    Console.WriteLine("Doğru Cevap!");
                }
                else
                {
                    Console.WriteLine("Yanlış. Doğru cevap: "+ soru.Cevap);
                }
                Console.WriteLine("-----------------------------------------------------");

            }
            Console.WriteLine();
            */

            /*
            // Constructor ile soru tanımlama yapsaydık ve SoruId, SoruMetni, Secenekler, Cevap  private olarak tanımlansaydı.

            var soru1 = new Soru(1, "Hangisi programlama dili değildir?", new string[4] { "Python", "C#", "Java", "Markdown" }, "Markdown");
            var soru2 = new Soru(2, "C# dilinde değişken tanımlarken hangi anahtar kelime kullanılır?", new string[4] { "define", "let", "var", "switch" }, "var");
            var soru3 = new Soru(3, "Hangisi C#'ta bir koşul ifadesidir?", new string[4] { "if", "for", "while", "bool" }, "if");

            Console.WriteLine(soru1.SoruYazdir());
            Console.WriteLine(soru1.CevapKontrol("markdown"));
            */


            // Static Methods
            var sonuc = HelperMethods.KarakterDuzelt("ölçme ve değerlendirme");
            Console.WriteLine(sonuc);

        }
    }


    // "" protected, internal, protected internal, private protected "" ==> Kalıtımla alakalı konular.
    class Ogrenci  // namespace ile ulaşılan bir class
    {
        // Property
        public string OgrenciNo { get; set; }

        public string AdSoyad { get; set; }

        public string Sube { get; set; }


        // Methods
        public void BilgileriYazdir()
        {
            Console.WriteLine($"{this.OgrenciNo} numaralı öğrencinin {this.AdSoyad} ve şubesi {this.Sube}");
        }
    }

    class Soru
    {
        // Constructors
        public Soru()   // Constructor
        {
            this.SoruId = (new Random()).Next(11111, 99999);
            Console.WriteLine(SoruId + " ID'li soru nesnesi oluşturuldu");
        }
        public Soru(int soruId)   // Constructor
        {
            this.SoruId = soruId;
            Console.WriteLine(SoruId + ". soru nesnesi oluşturuldu");
        }
        public Soru(int soruId, string soruMetni, string[] secenekler, string cevap)
        {
            this.SoruId = soruId;
            this.SoruMetni = soruMetni;
            this.Secenekler = secenekler;
            this.Cevap = cevap;
        }
        // Properties
        private int SoruId { get; set; }    // Access Modifier   private - public
        public string SoruMetni { get; set; }

        public string[] Secenekler { get; set; }

        public string Cevap { get; set; }

        // Methods
        public bool CevapKontrol(string cevap)
        {
            return this.Cevap.ToLower() == cevap.ToLower();
        }

        public string SoruYazdir()
        {
            string soru = "";
            soru += this.SoruMetni + "\n";
            foreach (var secenek in this.Secenekler)
            {
                soru += secenek + "\n";
            }

            return soru;
        }

    }

    class HelperMethods
    {
        public static string KarakterDuzelt(string str)
        {
            return str.Replace("ö", "o")
            .Replace("ü", "u")
            .Replace("ı", "i")
            .Replace("ğ", "g")
            .Replace("ç", "c")
            .Replace(" ", "_");
        }
    }
}

// ConsoleApp5 => Program, Ogrenci, Soru
// System      => Console
// System.IO   => File, Directory, Path
