﻿// ÖĞRENCİ KAYIT OTOMASYONU
// --------------------------
// 1- Öğrenci Ekle
// 2- Öğrencileri Listele
// 3- Öğrenci Sil
// 4- Öğrencilerin Genel Not Ortalaması
// 5- Öğrencilerin Yaş Ortalaması
// 6- Toplam Öğrenci Sayısı
// 0- Çıkış
using _20240309_GenelAlistirma;

ConsoleKey cevap;
do
{
    Console.Clear();
    Console.WriteLine("ÖĞRENCİ KAYIT OTOMASYONU");
    Console.WriteLine("------------------------");
    Console.WriteLine("1- Öğrenci Ekle");
    Console.WriteLine("2- Öğrencileri Listele");
    Console.WriteLine("3- Öğrenci Sil");
    Console.WriteLine("4- Öğrencilerin Genel Not Ortalaması");
    Console.WriteLine("5- Öğrencilerin Yaş Ortalaması");
    Console.WriteLine("6- Toplam Öğrenci Sayısı");
    Console.WriteLine("0- Çıkış");
    Console.WriteLine();
    Console.Write("Hangi işlemi yapmak istersiniz? ");
    cevap = Console.ReadKey().Key;
    Menu.Islemler(cevap);
} while (cevap != ConsoleKey.NumPad0 && cevap != ConsoleKey.D0);

Console.Clear();
Console.WriteLine();
Console.WriteLine("Programı kullandığınız için teşekkür ederiz");
Console.WriteLine("Kapatmak için bir tuşa basınız");