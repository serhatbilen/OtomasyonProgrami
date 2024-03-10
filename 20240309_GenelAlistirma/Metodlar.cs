using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _20240309_GenelAlistirma
{
	#region string.IsNullOrEmpty()
	// bu metod içerisinde bir adet string parametre alır
	// bu string değerin boş olup olmadığını kontrol eder.
	// string değer boş ise true, dolu ise false değer döndürür.
	#endregion
	public class Metodlar
	{
		// "Ad Giriniz: ", 2, 20
		public static string GetString(string metin, int min = 1, int max = 500)
		{
			string txt = string.Empty;
			// boş bir string değer oluşturduk
			bool hata = false;
			do
			{
                Console.Write(metin);
				txt = Console.ReadLine();
				if (string.IsNullOrEmpty(txt))
				{
                    Console.WriteLine("Boş bir değer giremezsiniz");
					hata = true;
				}
				else
				{
					if (txt.Length < min || txt.Length > max)
					{
                        Console.WriteLine("Lütfen min. {0}, max. {1} uzunlukta metin giriniz",min,max);
						hata = true;
					}
					else
					{
						hata = false;
					}
				}
            } while (hata);
			return txt;
		}

		public static int GetInt(string metin, int min = int.MinValue, int max = int.MaxValue)
		{
			int sayi = 0;
			bool hata = false;
			do
			{
                Console.Write(metin);
				try
				{
					sayi = int.Parse(Console.ReadLine());
					if (sayi >= min && sayi <= max)
					{
						hata = false;
					}
					else
					{
                        Console.WriteLine("Lütfen {0} ile {1} arasında bir değer giriniz.", min,max);
						hata = true;
                    }
				}
				catch (Exception ex)
				{
                    Console.WriteLine(ex.Message);
					hata = true;
                }
            } while (hata);
			return sayi;
		}

		public static double GetDouble(string metin, double min = double.MinValue, double max = double.MaxValue)
		{
			double sayi = 0;
			bool hata = false;

			do
			{
                Console.Write(metin);
				try
				{
					sayi = double.Parse(Console.ReadLine());
					if(sayi >= min && sayi <= max)
					{
						hata = false;
					}
					else
					{
                        Console.WriteLine("Lütfen {0} ile {1} aralığında bir değer giriniz", min,max);
						hata = true;
                    }
				}
				catch (Exception ex)
				{
                    Console.WriteLine(ex.Message);
					hata = true;
                }
            } while (hata);
			return sayi;
		}

		public static DateTime GetDateTime(string metin, int minYear, int maxYear)
		{
			DateTime date = DateTime.Now;
			bool hata = false;
			do
			{
                Console.Write(metin);
				try
				{
					date = DateTime.Parse(Console.ReadLine());
					if (date.Year <= maxYear && date.Year >= minYear)
					{
						hata = false;
					}
					else
					{
                        Console.WriteLine("Lütfen {0} ile {1} yılları arasında tarih giriniz", minYear, maxYear);
						hata = true;
                    }
				}
				catch (Exception ex)
				{
                    Console.WriteLine(ex.Message);
					hata = true;
                }
            } while (hata);
			return date;
		}
	}
}
