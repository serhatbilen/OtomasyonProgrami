using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240309_GenelAlistirma
{
	#region Any()
	// Any() metodu koleksiyonlar içerisinde değer arama işlemi yapan bir metoddur. 
	// Geriye bool tipinde değer döndürür.
	// Koleksiyon içerisinde eleman varsa "true", yoksa "false" değer döndürür.
	#endregion
	public class Menu
	{
		static List<Ogrenci> ogrenciler = new List<Ogrenci>();
		public static void Islemler(ConsoleKey key)
		{
			switch (key)
			{
				case ConsoleKey.NumPad1:
				case ConsoleKey.D1:
					Ekle("ÖĞRENCİ EKLE");
					break;
				case ConsoleKey.NumPad2:
				case ConsoleKey.D2:
					Listele("ÖĞRENCİ LİSTESİ");
					break;
				case ConsoleKey.NumPad3:
				case ConsoleKey.D3:
					Sil("ÖĞRENCİ SİL");
					break;
				case ConsoleKey.NumPad4:
				case ConsoleKey.D4:
					NotOrtalamasi("ÖĞRENCİLERİN GENEL NOT ORTALAMASI");
					break;
				case ConsoleKey.NumPad5:
				case ConsoleKey.D5:
					YasOrtalamasi("ÖĞRENCİLERİN YAŞ ORTALAMASI");
					break;
				case ConsoleKey.NumPad6:
				case ConsoleKey.D6:
					if (ogrenciler.Any())
					{
						BaslikYazdir("TOPLAM ÖĞRENCİ SAYISI");
						AnaMenuyeDon(string.Format("Listede toplam {0} öğrenci vardır", ogrenciler.Count));
					}
					else
					{
						Console.Clear();
						AnaMenuyeDon("Listede öğrenci bulunamadı");
					}
					break;
			}
		}

		private static void YasOrtalamasi(string v)
		{
			if (ogrenciler.Any())
			{
				BaslikYazdir(v);
				double yasToplam = 0;
				foreach (var item in ogrenciler)
				{
					yasToplam += item.Yas;
				}
				double yasOrtalamasi = yasToplam / ogrenciler.Count;
				AnaMenuyeDon(string.Format("Toplam {0} öğrencinin yaş ortalaması {1}", ogrenciler.Count, Math.Round(yasOrtalamasi, 2)));
			}
			else
			{
				Console.Clear();
				AnaMenuyeDon("Listede öğrenci bulunamadı");
			}
		}

		private static void NotOrtalamasi(string v)
		{
			if (ogrenciler.Any())
			{
				double genelToplam = 0;
				foreach (var item in ogrenciler)
				{
					genelToplam += item.Ortalama;
				}
				double genelOrtalama = genelToplam / ogrenciler.Count;
				AnaMenuyeDon(string.Format("Toplam {0} öğrencinin genel not ortalaması {1}", ogrenciler.Count, Math.Round(genelOrtalama,2)));
			}
			else
			{
				Console.Clear();
				AnaMenuyeDon("Listede öğrenci bulunamadı");
			}
		}

		private static void Sil(string v)
		{
			if (ogrenciler.Any())
			{
				BaslikYazdir(v);
				for (int i = 0; i < ogrenciler.Count; i++)
				{
					ogrenciler[i].Yazdir(i+1);
				}
                Console.WriteLine();
				int siraNo = Metodlar.GetInt("Silmek istediğiniz öğrencinin sıra numarasını giriniz: ", 1, ogrenciler.Count);
				int indexNo = siraNo - 1;
				string silinen = ogrenciler[indexNo].TamAd;
				Console.Write(silinen + " öğrencisini silmek istediğinize emin misiniz?(e): ");
				if (Console.ReadKey().Key == ConsoleKey.E)
				{
					ogrenciler.RemoveAt(indexNo);
					AnaMenuyeDon(string.Format("{0} öğrencisi listeden başarı ile silinmiştir", silinen));
				}
				else
				{
					AnaMenuyeDon("Silme işlemi iptal edildi");
				}

            }
			else
			{
				Console.Clear();
				AnaMenuyeDon("Listede öğrenci bulunamadı");
			}

		}

		private static void Listele(string v)
		{
			if (ogrenciler.Any())
			{
				BaslikYazdir(v);
				for (int i = 0; i < ogrenciler.Count; i++)
				{
					ogrenciler[i].Yazdir(i + 1);
				}
				AnaMenuyeDon(string.Format("Toplam {0} öğrenci listelenmiş", ogrenciler.Count));
			}
			else
			{
				Console.Clear();
				AnaMenuyeDon("Listede öğrenci bulunamadı");
			}
		}

		private static void Ekle(string v)
		{
			BaslikYazdir(v);
			Ogrenci o = new();
			o.Ad = Metodlar.GetString("Adı Giriniz: ", 2, 20);
			o.Soyad = Metodlar.GetString("Soyadı Giriniz: ", 2, 20);
			o.N1 = Metodlar.GetDouble("1. Not: ", 0, 100);
			o.N2 = Metodlar.GetDouble("2. Not: ", 0, 100);
			o.DogumTarihi = Metodlar.GetDateTime("Doğum Tarihi: ", DateTime.Now.Year-15, DateTime.Now.Year-7);
			ogrenciler.Add(o);
			AnaMenuyeDon(string.Format("{0} öğrencisi listeye başarı ile eklendi",o.TamAd));
		}

		private static void AnaMenuyeDon(string v)
		{
            Console.WriteLine();
            Console.WriteLine(v);
            Console.WriteLine("Ana Menüye Dönmek İçin Bir Tuşa Basınız");
			Console.ReadKey();
        }

		private static void BaslikYazdir(string v)
		{
			Console.Clear();
            Console.WriteLine(v);
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }
	}
}
