Console.WriteLine("Rüya Manavına Hoş Geldiniz!");

int elma = 2;

Console.WriteLine("Elma = " + elma + " TL");

int armut = 3;

Console.WriteLine("Armut = " + armut + " TL");

int cilek = 2;

Console.WriteLine("Çilek = " + cilek + " TL");

int muz = 3;

Console.WriteLine("Muz = " + muz + " TL");

int diger = 4;

Console.WriteLine("Diğer bütün meyveler = " + diger + " TL");

Console.Write("Hangi meyveyi satın almak istersiniz?" + " Elma/Armut/Çilek/Muz/Diğer:");

string meyveAdi = Console.ReadLine().ToLower();

switch (meyveAdi)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + elma + " TL'dir");
        break;

    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + armut + " TL'dir");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + cilek + " TL'dir");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + muz + " TL'dir");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + diger + " TL'dir");
        break;
}

// Bu uygulamamızda ki doğru kullanım Switch Case kullanımı olduğunu düşünmekteyim. Çünkü sabit değeri kontrol ediyoruz bir ve - veya gibi koşullu durumlar yok. O yüzden Switch Case yeterli.

//if (meyveAdi == "elma")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + elma + " TL'dir");
//}
//else if (meyveAdi == "armut")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + armut + " TL'dir");
//}
//else if (meyveAdi == "çilek")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + cilek + " TL'dir");
//}
//else if (meyveAdi == "muz")
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + muz + " TL'dir");
//}
//else
//{
//    Console.WriteLine("Seçtiğiniz meyvenin fiyatı" + " " + diger + " TL'dir");
//}