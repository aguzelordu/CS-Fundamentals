// For

//kontrol değişkeni
//kontrol
//güncellenmesi

/*
int sum = 0;
for (var i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}

Console.WriteLine(sum);
*/
/*
Console.WriteLine("Başlangıç sayısı: ");
int baslangic = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Bitiş sayısı: ");
int bitis = Convert.ToInt32(Console.ReadLine());

var tplm = 0;
for (var i = baslangic; i <= bitis; i++)
{
    tplm +=i;
}

Console.WriteLine(tplm);
*/
/*
string[] isimler = { "Ali", "Ahmet", "Merve", "Ayşe"};

for (var i = 0; i < isimler.Length; i++)
{
    Console.WriteLine(isimler[i]);
}

int[] sayilar = { 1, 3, 4, 34, 41, 56, 77, 89, 90, 100, 153 };

for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] % 3 == 0)
    {
        Console.WriteLine(sayilar[i]);
    }
}
*/



/*
// While
var i = 0;

while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

var j = 0;
string[] isimler = { "Ali", "Ahmet", "Merve", "Ayşe"};

while (j < isimler.Length)
{
    Console.WriteLine(isimler[j]);
    j++;
}
*/

/*
var secim = "e";
var sayac = 1;
var toplam = 0;

while (secim == "e")
{
    Console.Write($"{sayac}. sayı: ");
    toplam += Convert.ToInt32(Console.ReadLine());

    Console.Write("Devam etmek istiyor musunuz? (e/h)");
    secim = Console.ReadLine();

    sayac ++;
}

Console.WriteLine($"{sayac-1} adet sayının toplamı: {toplam}");
*/

/*
// Break & Continue

string yazi = "Bu bir string ifadedir.";

for (var i = 0; i < yazi.Length; i++)
{
    if(yazi[i] == 'r')
    {
        continue;
    }
    Console.WriteLine(yazi[i]);
    if (yazi[i] == 'd')
    {
        break;
    }
}

int x = 0;

while (x < 5)
{
    x++;      // Eğer continue işlemi sonrası artırırsak continue sonrası kodlar atlandığından aynı değerde takılı kalarak sonsüz döngüye giricek
    if (x % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(x);
}
*/

/*
var rnd = new Random();
int tutulan = rnd.Next(1, 10);
int hak = 3;
Console.WriteLine("Bu bir sayı tahmin oyunudur. 1-10 arasında tutulan sayıyı bilin. 3 hakkınız var.");

while (hak > 0)
{
    Console.WriteLine("Sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    hak--;

    if (sayi == tutulan)
    {
        Console.WriteLine("Tebrikler bildiniz. Tutulan sayı: " + tutulan);
        break;
    }
    else
    {
        if (hak == 0)
        {
            Console.WriteLine("Oyun bitti. Tutulan sayı: " + tutulan);
            break;
        }
        if (tutulan > sayi)
        {
            Console.WriteLine("yukarı");
        }
        else
        {
            Console.WriteLine("aşağı");
        }
    }
}
*/

/*
// Do-While
Console.WriteLine("Adet: ");
int adet = Convert.ToInt32(Console.ReadLine());

string[] urunler = new string[adet];

int i = 0;

do
{
    Console.Write("Ürün adı: ");
    urunler[i] = Console.ReadLine() ?? "-";
    i++;
} while (adet != i);

Console.WriteLine("Ürünler Listeleniyor...");

for (var k = 0; k < urunler.Length; k++)
{
    Console.WriteLine(urunler[k]);
}
*/


/*
// ForEach

string ad = "Ali";

// for (var i = 0; i < ad.Length; i++)
// {
//     Console.WriteLine(ad[i]);
// }

foreach (var harf in ad)
{
    Console.WriteLine(harf);
}

int[] numbers = { 1, 2, 3, 4, 5, 6 };

foreach (var num in numbers)
{
    if (num == 4)
    {
        break;
    }
    Console.WriteLine(num);
}
*/

// Dosya işlemleri

//Stream
//File
//Directory
/*
StreamReader sr = File.OpenText("deneme.txt");

var s = "";

while ((s = sr.ReadLine()) != null)
{
    Console.WriteLine(s);
}

// string yazi = File.ReadAllText("deneme.txt")

string[] yazi = File.ReadAllLines("deneme.txt");

Console.WriteLine(yazi[0]);
Console.WriteLine(yazi[2]);
*/

/*
using (StreamWriter sw = File.CreateText("deneme1.txt"))
{
    sw.WriteLine("Merhaba");
    sw.WriteLine("Yazılımcı");
    sw.WriteLine("Hoşgeldin");
}

// sw.Close();         //using() kullanılarak açılır ise dosya kapatılmalı

using(StreamWriter sw = File.AppendText("deneme1.txt"))
{
    sw.WriteLine("Bu");
    sw.WriteLine("Dosya");
    sw.WriteLine("Yeni");
}


using (StreamReader sr = File.OpenText("deneme1.txt"))
{
    var s = "";

    while ((s = sr.ReadLine()) != null)
    {
        Console.WriteLine(s);
    }
}

// File.WriteAllText("deneme.txt", "merhaba");
// File.AppendAllText("deneme1.txt", "merhaba");
*/

/*
// Klasörlerle çalışma
Directory.CreateDirectory("temp/deneme1");
Directory.CreateDirectory("temp/deneme2");

if (Directory.Exists("temp\\deneme2"))
{
    Directory.Delete("temp\\deneme1");
}
else
{
    Console.WriteLine("Silmek istediğiniz klasör bulunmamaktadır.");
}

// string path = @"C:\...\deneme"
string path = Directory.GetCurrentDirectory();
Console.WriteLine(path);
*/

string rootPath = Directory.GetCurrentDirectory();

/*
string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);

foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}
*/
/*
string[] files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

foreach (string file in files)
{
    Console.WriteLine(file);
    Console.WriteLine(Path.GetExtension(file));
    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
    Console.WriteLine(Path.GetFileName(file));

    var info = new FileInfo(file);
    Console.WriteLine($"{Path.GetFileName(file)}: {info.Length}");

}
*/

// Kopyalama işlemi













