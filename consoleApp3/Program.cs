
// if / else / elseif blokları

/*
string username = "admin";
string password = "12345";


var isLogin = (username == "admin");

if (isLogin)
{
    if (password == "12345")
    {
        Console.WriteLine("Merhaba, Hoşgeldiniz");
    }
    else
    {
        Console.WriteLine("parola yanlış");
    }
}

else
    Console.WriteLine("username yanlış");     // tek satırsa parantez zorunlu değil
*/

/*
string username = "admin";
string password = "12345";

if (username != "admin")
{
    Console.WriteLine("usernama hatalı");
}
else if (password != "12345")
{
    Console.WriteLine("parola hatalı");
}
else
{
    Console.WriteLine("Giriş başarılı");
}
*/

/*
int x = 10;
int y = 20;

if (x > y)
{
    Console.WriteLine("x y'den büyük");
}
else if (x == y)
{
    Console.WriteLine("x ve ye eşit");
}
else
{
    Console.WriteLine("x y'den küçük");
}
*/


/*
// Basit Hesap Makinesi

Console.WriteLine("Toplama için +");
Console.WriteLine("Toplama için -");
Console.WriteLine("Toplama için *");
Console.WriteLine("Toplama için /");

Console.Write("Seçiminiz: ");
var secim = Console.ReadLine();

Console.Write("1. sayı: ");
var sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. sayı: ");
var sayi2 = Convert.ToInt32(Console.ReadLine());

double sonuc = 0;
bool ok = true;

if (secim == "+")
{
    sonuc = sayi1 + sayi2;
}
else if (secim == "-")
{
    sonuc = sayi1 - sayi2;
}
else if (secim == "*")
{
    sonuc = sayi1 * sayi2;
}
else if (secim == "/")
{
    if (sayi2 == 0)
    {
        ok = false;
        Console.WriteLine("Bölen 0 olamaz.");
    }
    sonuc = sayi1 / sayi2;
}
else
{
    ok = false;
    Console.WriteLine("Hatalı seçim.");
}
if (ok)
Console.WriteLine($"İşlem sonucu: {sayi1} {secim} {sayi2} = {sonuc}");
*/

/*
Console.WriteLine("1. yazılı: ");
int not1 = convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. yazılı: ");
int not2 = convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sözlü: ");
int sozlu = convert.ToInt32(Console.ReadLine());

var ort = (not1 + not2 +sozlu) / 3;
int not = -1;
bool ok = true;


if (ort >= 0 && ort < 40)
{
    not = 1;
}
else if (ort >= 40 && ort < 55)
{
    not = 2;
}
else if (ort >= 55 && ort < 70)
{
    not = 3;
}
else if (ort >= 70 && ort < 85)
{
    not = 4;
}
else if (ort >= 85 && ort < 100)
{
    not = 5;
}
else
{
    ok = false;
    Console.WriteLine("Yanlış not girdiniz!");
}

if(ok)
Console.WriteLine($"Not ortalamanız: {ort} ve notunuz {not}");
*/



// Switch-Case
/*
Console.WriteLine($"Bu program bulunduğunuz günden kaç gün sonra haftanın hangi gününe denk geldiğini hesaplar. Bugün çarşamba günündeyiz. Seçtiğiniz gün sayısını yazınız: ");
int gun = Convert.ToInt32(Console.ReadLine());
// 0 => pzts,  1 => salı ...  6 => cmts

if (gun < 0)
{
    gun = -1;
}
else
{
    gun %= 7;
}

switch (gun)
{
    case 0:
        Console.WriteLine("Çarşamba");
        break;
    case 1:
        Console.WriteLine("Perşembe");
        break;
    case 2:
        Console.WriteLine("Cuma");
        break;
    case 3:
        Console.WriteLine("Cumartesi");
        break;
    case 4:
        Console.WriteLine("Pazar");
        break;
    case 5:
        Console.WriteLine("Pazartesi");
        break;
    case 6:
        Console.WriteLine("Salı");
        break;
    case -1:
        Console.WriteLine("Programın doğru çalışması için pozitif sayı veriniz.");
        break;
}
*/

/*
int ay = 12;

switch (ay)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("İlkbahar");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yaz");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Sonbahar");
        break;
    default:
        Console.WriteLine("Hatalı ay bilgisi");
        break;
}
*/

/*
// Ternary
int sayi = 10;

// var sonuc = (sayi % 2 == 0) ? "sayı çifttir." : "sayı tektir.";
var sonuc = (sayi % 2 == 0) ?
    (sayi > 0) ? "sayı pozitif çift" : "sayı negatif çift" :
    (sayı > 0) ? "sayı pozitif tek" : "sayı negatif tek";

Console.WriteLine(sonuc);
*/


