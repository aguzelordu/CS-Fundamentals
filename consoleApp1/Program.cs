// See https://aka.ms/new-console-template for more information

/*
var kdvOrani = 1.2;
var urunA = 125;
var urunB = 430;


Console.WriteLine("Merhaba, Dunya!");

Console.WriteLine(50); //urunFiyat
Console.WriteLine(125 * 1.2);
Console.WriteLine(430 * kdvOrani);
*/

/*
var sayi = 20;
var urun_adi = "elma";

var sayi2 = 30;
var fiyat = 10.95;

var stoktaMi = "evet";



Console.WriteLine(sayi);
Console.WriteLine(urun_adi);
Console.WriteLine(sayi2);
Console.WriteLine(fiyat);
*/

/*
    Data Types

    Value Types:
        Tam Sayı:               byte, short, int, long
        Ondalıklı sayılar:      float, double, decimal
        Diğer:                  char, boolean, struct

    Reference Types:
        String, Class, Array, Interface

*/


/*
int sayi = 200;

double kdvOrani = 1.18;
float kdvOrani2 = 1.2f;
decimal kdvOrani3 = 1.12m;

char cinsiyet = 'K';
string cinsiyet2 = "Kadin";
*/

/*
Console.WriteLine("1. sayı: ");
string sayi1 = Console.ReadLine();   //nullable için ? eklenmeli

Console.WriteLine("2. sayı: ");
string? sayi2 = Console.ReadLine();
*/

/*
Console.Write("1. sayı: ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sayı: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

var toplam = sayi1 + sayi2;

Console.WriteLine(toplam);
*/


/*
//********* implicit casting => bilinçsiz tür dönüşümü **********
int a = 10;
long b = a;

Int16 c = 25;
Int32 d = c;

//********* explicit casting => bilinçli tür dönüşümü ***********

long d1 = 20;
int e = (int)d1;

double f = 8.3;
float g = (float)f;

float h = 12.4f;
int i = (int)h;

Console.WriteLine(i);

int x = 33;
string z = x.ToString();
*/

/*
//Nullable Types
int? maas = null;

bool? isActive = default;

Console.WriteLine(maas.HasValue);
Console.WriteLine(maas.GetValueOrDefault());  // boş ise default değer yazdırılır.
*/


/*
using System.ComponentModel;

Console.WriteLine("adı: ");
string? ad = Console.ReadLine();

Console.WriteLine("soyadı: ");
string? soyad = Console.ReadLine();

Console.WriteLine("yaşı: ");
string? yas = Console.ReadLine();

// string concat
string mesaj1 = ad + " " + soyad + " isimli kişi " + yas + " yaşındadır.";
// string interpolation
string mesaj2 = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";

Console.WriteLine(mesaj1);
Console.WriteLine(mesaj2);
*/

/*
string mesaj = "   Ahmet Yılmaz isimli kişi 20 yaşındadır.   ";

int adet = mesaj.Length;

string kucuk = mesaj.ToLower();
string buyuk = mesaj.ToUpper();

string bosluksuz = mesaj.Trim();

string[] dizi = mesaj.Split(" ");

bool bslngc = mesaj.StartsWith("A");
bool bts = mesaj.EndsWith(" ");
bool varMi = mesaj.Contains("Ahmet");

var sira = mesaj.IndexOf("i");
string parca = mesaj.Substring(14 , 8);

Console.WriteLine(parca);

Console.WriteLine(dizi[4]);
*/


/*
string kursAdi = ".NET ile C# Programlama Dili";

// Kaç karaktere sahip
int karakterSayisi = kursAdi.Length;

// Hepsi küçük harf
string kucukHarf = kursAdi.ToLower();

// "." ile mi başlıyor
bool noktaMi = kursAdi.StartsWith(".");

// C# bilgisinin konumu
var konum = kursAdi.IndexOf("C#");

//String "C++" bilgisi içeriyor mu
bool iceriyorMu = kursAdi.Contains("C++");

// "Dili" yerine "Dersleri" yaz
string guncelString = kursAdi.Replace("Dili", "Dersleri");
*/


/*
// Datetime

var simdi = DateTime.Now;

Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);
Console.WriteLine(simdi.Month);
Console.WriteLine(simdi.Day);
Console.WriteLine(simdi.Hour);
Console.WriteLine(simdi.Minute);
Console.WriteLine(simdi.Second);
Console.WriteLine(simdi.DayOfWeek);

DateTime dt = new DateTime(2022, 6, 10, 14, 30, 45);
DateTime dt2 = dt.AddYears(1);

var fark = simdi - dt;
Console.WriteLine(fark.TotalDays);

*/




