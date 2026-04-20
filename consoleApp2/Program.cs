
/*
// Diziler

var kursAdi = ".NET ile C# programlama dersleri";
var kursAdi2 = ".NET ile C# programlama dersi".Split(" ");

Console.WriteLine(kursAdi[13]);
Console.WriteLine(kursAdi2[2]);

string[] isimler = new string[5];

isimler[0] = "Ahmet";
isimler[1] = "Ali";
isimler[2] = "Canan";
isimler[3] = "Esin";
isimler[4] = "Kerem";


int[] numaralar = { 110, 220, 330, 440, 550};

Console.WriteLine($"{numaralar[2]} numaralı öğrencinin adı {isimler[2]}");
*/


/*
// Array Methods
string[] sehirler = {"İstanbul", "Rize", "Kocaeli" };
int[] plakalar = { 34, 54, 41 };

//sehirler[0] = "Sakarya";
sehirler.SetValue("Sakarya", 1);


Console.WriteLine(sehirler[1]);
Console.WriteLine(sehirler.GetValue(0));
Console.WriteLine(Array.IndexOf(sehirler, "İzmir"));

Array.Sort(sehirler);
Array.Sort(plakalar);    

Array.Reverse(plakalar);   // Diziyi ters çevirir

Array.Clear(plakalar);     // Diziyi null olarak temizler
Array.Clear(sehirler, 0, 1);     
*/

/*
//Array Slicing

string[] sehirler = {"İstanbul", "Kocaeli", "Bursa", "Edirne", "Tekirdağ", "Balıkesir", "Çanakkale" };

// var secim = sehirler[0..3];

foreach (var sehir in sehirler[..3])             //foreach (var sehir in secim)
{
    Console.WriteLine(sehir);
}

string il = "Diyarbakır";
Console.WriteLine(il[4..]);
*/

/*
// Diziler App
string[] ogrenciler = new string[3];
int[] notlar = new int[3];

Console.Write("1. Öğrenci adı: ");
ogrenciler[0] = Console.ReadLine() ?? "";            // Input girişi olmazsa null değer atar
Console.Write("1. Öğrenci notu: ");
notlar[0] = Convert.ToInt32(Console.ReadLine()); 

Console.Write("2. Öğrenci adı: ");
ogrenciler[1] = Console.ReadLine() ?? "";
Console.Write("2. Öğrenci notu: ");
notlar[1] = Convert.ToInt32(Console.ReadLine());

Console.Write("3. Öğrenci adı: ");
ogrenciler[2] = Console.ReadLine() ?? "";
Console.Write("3. Öğrenci notu: ");
notlar[2] = Convert.ToInt32(Console.ReadLine());


foreach(var ogrenci in ogrenciler[..2])
{
    Console.WriteLine(ogrenci);    
}

foreach (var not in notlar[..2])
{
    Console.WriteLine(not);
}

int not1 = notlar[0];
int not2 = notlar[1];
int not3 = notlar[2];

var ortalama = (not1 + not1 + not2 + not3) / 3;

Console.WriteLine($"Öğrencilerin ortalaması: {ortalama}");
*/

/*
// Çok Boyutlu Diziler
// Ali   => 50, 80, 90
// Ahmet => 60, 85, 90
// Canan => 40, 75, 80

string[] ogrenciler = { "Ali", "Ahmet", "Canan" };
int[,] notlar = new int[3, 3];

// Ali notlar
notlar[0,0] = 50;
notlar[0,1] = 80;
notlar[0,2] = 90;

// Ahmet notlar
notlar[1,0] = 60;
notlar[1,1] = 85;
notlar[1,2] = 90;

// Canan notlar
notlar[2,0] = 40;
notlar[2,1] = 75;
notlar[2,2] = 80;

var ortalama1 = (notlar[0, 0] + notlar[0, 1] + notlar[0, 2]) / 3;
var ortalama2 = (notlar[1, 0] + notlar[1, 1] + notlar[1, 2]) / 3;
var ortalama3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2]) / 3;

Console.WriteLine($"{ogrenciler[0]} isimli öğrenci not ortalaması: {ortalama1}");
Console.WriteLine($"{ogrenciler[1]} isimli öğrenci not ortalaması: {ortalama2}");
Console.WriteLine($"{ogrenciler[2]} isimli öğrenci not ortalaması: {ortalama3}");
*/


/*
// Reference Types
int[] x = { 10, 20, 30 };
int[] y = x;

Console.WriteLine(x[0]);  // 10
Console.WriteLine(y[0]);  // 10

x[0] = 40;

Console.WriteLine(x[0]);  // 20
Console.WriteLine(y[0]);  // 20
*/


/*
// Operators
// Aritmetik Operatörler

int a = 10;
int b = 3;
int? c = null;

// var sonuc = a + b;
// var sonuc = a - b;
// var sonuc = a * b;
// var sonuc = (float)a / (float)b;
var sonuc = a % b;

var sonuc2 = a++;
Console.WriteLine(sonuc);
Console.WriteLine(sonuc2);

var sonuc3 = a + (c ?? 0);  // c null değer ise 0 döndürerek işlemi yapar.
Console.WriteLine(sonuc3);


Console.WriteLine("sayı: ");
int sayi = int.Parse(Console.ReadLine());           // int.Parse() = Convert.ToInt32()
var tekMi = sayi % 2;

Console.WriteLine(tekMi);         // 1 ise sayı tek, 0 ise sayı çift
*/

/*
// Atama Operatörleri
var a = 5;
var b = 6;

a += b;
b -= 3;
a *= b;

// Math
double sayi1;
sayi1 = Math.Pow(2, 3);
sayi1 = Math.Sqrt(25);
sayi1 = Math.Abs(-123);

sayi1 = Math.Round(4.7);
sayi1 = Math.Ceiling(11.3);
sayi1 = Math.Floor(5.9);

sayi1 = Math.Max(0, 1, 2, 3, 4, 5, 6);

Console.WriteLine(sayi1);
*/

/*
// Karşılaştırma Operatörleri
// "==",     "!=",      "<",       "<=",      ">",      ">="

int a = 5, b = 5, c = 6;

var sonuc1 = (a == b);  // True
var sonuc2 = (a >= c);  // False

Console.WriteLine(sonuc1);
Console.WriteLine(sonuc2);

var sonuc3 =(a > c) ? "a büyük":"c büyük";           // Ternary  (True ise ":" önceki seçenek döner, False ise ":" sonrası seçenek döner.)
Console.WriteLine(sonuc3);

var sonuc4 = (a > b) ? "a büyük" : (a == b) ? "a ile b eşit" : "b büyük";
*/

/*
Console.WriteLine("Yaşınız: ");
int yas = Convert.ToInt32(Console.ReadLine());

var resit = (yas >= 18) ? "ehliyet alabilirsiniz.":"ehliyet için yaşınız tutmuyor.";
Console.WriteLine(resit);

Console.WriteLine("Sayı: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

var pozitifMi = (sayi2 > 0) ? "sayi pozitiftir." : "sayı negatiftir.";
Console.WriteLine(pozitifMi);

var ciftMi = (sayi2 % 2 == 0) ? "sayı çifttir." : "sayı tektir.";
Console.WriteLine(ciftMi);
*/

/*
// and operatörü => &&
// or  operatörü => ||
// not operatörü => !

int not = 40;
var kosul = (not >= 50 && not <= 100) ? "geçti":"kaldı";
Console.WriteLine(kosul);

int notOrt = 70;
int zayif = 0;

var kosul2 = (notOrt >=70) ? ((zayif == 0) ? "teşekkür alabilir":"zayıfınız olmamalı"):"notunuz en az 70 olmalıdır.";
Console.WriteLine(kosul2);

string email = "ornek@email.com";
string username = "admin";
string pswd = "123";

var giris = ((email == "ornek@email.com" || username == "admin") && (pswd == "123")) ? "başarılı" : "başarısız";
Console.WriteLine(giris);
*/

/*
// Random

string[] takimlar = { "Beşiktaş", "Galatasaray", "Fenerbahçe", "Trabzon", "Bursaspor"};
var rnd = new Random();

int sayi = rnd.Next(3);
int rastgele = rnd.Next(50, 100);

Console.WriteLine(rastgele);
Console.WriteLine(sayi + " " + takimlar[sayi]);
*/




