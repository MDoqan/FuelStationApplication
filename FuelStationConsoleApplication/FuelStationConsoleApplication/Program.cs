using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double dizel = 5.12, benzin = 5.55, lpg = 5.58;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecim = '0', altmenusecim = '0', akaryakitfiyatguncelleme = '0', akaryakitsatistipi = '0';

        MENU:
            Console.Clear();
            Console.WriteLine("Akaryakıt Satıs Takip");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Birim Fiyat Göster");
            Console.WriteLine("2-Birim Fiyat Güncelle");
            Console.WriteLine("3-Akaryakıt Satışı yap");
            Console.WriteLine("4-Depo Durumunu Göster");
            Console.WriteLine("5-Toplam Satışı Göster");
            Console.WriteLine("6-Çıkış");
            Console.WriteLine("Seçiminizi yapınız[1,2,3,4,5,6]:");

            try
            {
                anamenusecim = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Yanlış Tuşa Bastınız");

            ALTMENU:
               
                Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                try
                {
                    altmenusecim = Convert.ToChar(Console.ReadLine());
                    if (altmenusecim == '1')
                    {
                        goto MENU;

                    }
                    else if (altmenusecim == '2')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                        goto ALTMENU;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto ALTMENU;
                }
            }

            if (anamenusecim == '1')

            {
                Console.Clear();
                Console.WriteLine("Seçiminiz=1");
                Console.WriteLine("-----Birim Fiyat Listesi-----");
                Console.WriteLine("Benzin(B)={0} TL/Litre", benzin);
                Console.WriteLine("Lpg(L)={0} TL/Litre", lpg);
                Console.WriteLine("Dizel(D)={0} TL/Litre", dizel);
                Console.WriteLine(" ");
             
            ALTMENU1:
                Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                try
                {
                    altmenusecim = Convert.ToChar(Console.ReadLine());
                    if (altmenusecim == '1')
                    {
                        goto MENU;

                    }
                    else if (altmenusecim == '2')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                        goto ALTMENU1;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto ALTMENU1;
                }
            }

            else if (anamenusecim == '2')

            {
                Console.Clear();
                Console.WriteLine("Seçiminiz=2");
                Console.WriteLine("-----Birim Fiyat Güncelleme-----");

            AKARYAKITTIPI:

                Console.WriteLine("Akaryakıt Tipi Seçiniz[D,B,L]");

                try
                {
                    akaryakitfiyatguncelleme = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto AKARYAKITTIPI;
                }

                if (akaryakitfiyatguncelleme == 'b' || akaryakitfiyatguncelleme == 'B')

                {
                    Console.WriteLine("Benzin(B)={0} TL/Litre", benzin);

                BENZİNGUNCELLEME:

                    Console.WriteLine("Benzin Yakıt Için Yeni Fiyat Girin");

                    try
                    {
                        benzin = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        goto BENZİNGUNCELLEME;
                    }
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Benzin(B)={0} TL/Litre", benzin);
                }
                else if (akaryakitfiyatguncelleme == 'l' || akaryakitfiyatguncelleme == 'L')

                {
                    Console.WriteLine("Lpg(L)={0} TL/Litre", lpg);

                LPGGUNCELLEME:

                    Console.WriteLine("Lpg Yakıt Için Yeni Fiyat Girin");
                    try
                    {
                        lpg = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        goto LPGGUNCELLEME;
                    }
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Lpg(L)={0} TL/Litre", lpg);
                }
                else if (akaryakitfiyatguncelleme == 'd' || akaryakitfiyatguncelleme == 'D')

                {
                    Console.WriteLine("Dizel(D)={0} TL/Litre", dizel);

                DIZELGUNCELLEME:

                    Console.WriteLine("Dizel Yakıt Için Yeni Fiyat Girin");
                    try
                    {
                        dizel = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        goto DIZELGUNCELLEME;
                    }    
                    Console.WriteLine("Değişiklik Yapılmıştır");
                    Console.WriteLine("Dizel(D)={0} TL/Litre", dizel);
                }
                else
                {
                    Console.WriteLine("Yanlış Bir İşlem Yaptınız,Lütfen Girdiğiniz Değeri Kontrol Ediniz");
                    goto AKARYAKITTIPI;
                }
                Console.WriteLine(" ");
              
            ALTMENU2:
                Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                try
                {
                    altmenusecim = Convert.ToChar(Console.ReadLine());
                    if (altmenusecim == '1')
                    {
                        goto MENU;
                    }
                    else if (altmenusecim == '2')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                        goto ALTMENU2;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto ALTMENU2;
                }
            }

            else if (anamenusecim == '3')

            {
                Console.Clear();
                Console.WriteLine("Seçiminiz=3");
                Console.WriteLine("-----Akaryakıt Satış İşlemleri-----");

            AKARYAKITSATISI:

                Console.WriteLine("Akaryakıt Tipi Seçiniz[D,B,L]");

                try
                {
                    akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto AKARYAKITSATISI;
                }
                if (akaryakitsatistipi == 'b' || akaryakitsatistipi == 'B')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Yakıt Tankında Hiç Benzin Kalmamış");
                        goto MENU;
                    }
                    else
                    {
                    BENZINSATIS:

                        Console.WriteLine("Ne Kadar Benzin Yakıt Alacaksınız?");
                        try
                        {
                            satismiktari = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Yanlış Tuşa Bastınız");
                            goto BENZINSATIS;
                        }
                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt Tankında {0} Litre Benzin Var.İşlem Yapılmadı.", benzintank);

                        ALTMENU3:
                            Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                            try
                            {
                                altmenusecim = Convert.ToChar(Console.ReadLine());
                                if (altmenusecim == '1')
                                {
                                    goto MENU;
                                }
                                else if (altmenusecim == '2')
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                                    goto ALTMENU3;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Yanlış Tuşa Bastınız");
                                goto ALTMENU3;
                            }
                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakıt Dolum Tamamlanmıştır");
                            Console.WriteLine("Yakıt Tankında {0} Litre Benzin Kaldı.", benzintank);
                        }
                    }
                }
                else if (akaryakitsatistipi == 'l' || akaryakitsatistipi == 'L')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Yakıt Tankında Hiç Lpg Kalmamış");
                        goto MENU;
                    }
                    else
                    {
                    LPGSATIS:

                        Console.WriteLine("Ne Kadar Lpg Yakıt Alacaksınız?");
                        try
                        {
                            satismiktari = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Yanlış Tuşa Bastınız");
                            goto LPGSATIS;
                        }
                        if (lpgtank < satismiktari)
                        {
                            Console.WriteLine("Yakıt Tankında {0} Litre Lpg Var.İşlem Yapılmadı.", lpgtank);
                        ALTMENU4:
                            Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                            try
                            {
                                altmenusecim = Convert.ToChar(Console.ReadLine());
                                if (altmenusecim == '1')
                                {
                                    goto MENU;
                                }
                                else if (altmenusecim == '2')
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                                    goto ALTMENU4;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Yanlış Tuşa Bastınız");
                                goto ALTMENU4;
                            }
                        }
                        else if (satismiktari <= lpgtank)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakıt Dolum Tamamlanmıştır");
                            Console.WriteLine("Yakıt Tankında {0} Litre Lpg Kaldı.", lpgtank);
                        }
                    }
                }
                else if (akaryakitsatistipi == 'd' || akaryakitsatistipi == 'D')
                {
                    if (dizeltank == 0)
                    {
                        Console.WriteLine("Yakıt Tankında Hiç Dizel Kalmamış");
                        goto MENU;
                    }
                    else
                    {
                    DIZELSATIS:

                        Console.WriteLine("Ne Kadar Dizel Yakıt Alcaksınız?");
                        try
                        {
                            satismiktari = Convert.ToDouble(Console.ReadLine());

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Yanlış Tuşa Bastınız");
                            goto DIZELSATIS;
                        }
                        if (dizeltank < satismiktari)
                        {
                            Console.WriteLine("Yakıt Tankında {0} Litre Dizel Var.İşlem Yapılmadı.", dizeltank);
                        ALTMENU5:
                            Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                            try
                            {
                                altmenusecim = Convert.ToChar(Console.ReadLine());
                                if (altmenusecim == '1')
                                {
                                    goto MENU;
                                }
                                else if (altmenusecim == '2')
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                                    goto ALTMENU5;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Yanlış Tuşa Bastınız");
                                goto ALTMENU5;
                            }
                        }
                        else if (satismiktari <= dizeltank)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.WriteLine("Yakıt Dolum Tamamlanmıştır");
                            Console.WriteLine("Yakıt Tankında {0} Litre Dizel Kaldı.", dizeltank);
                        }
                    }
                }
                else
                {
                    {
                        Console.WriteLine("Yanlış Bir İşlem Yaptınız,Lütfen Girdiğiniz Değeri Kontrol Ediniz");
                        goto AKARYAKITSATISI;
                    }
                }
                Console.WriteLine(" ");
            ALTMENU6:
                Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                try
                {
                    altmenusecim = Convert.ToChar(Console.ReadLine());
                    if (altmenusecim == '1')
                    {
                        goto MENU;
                    }
                    else if (altmenusecim == '2')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                        goto ALTMENU6;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto ALTMENU6;
                }
            }

            else if (anamenusecim == '4')

            {
                Console.Clear();
                Console.WriteLine("Seçiminiz=4");
                Console.WriteLine("-----Depo Durumu-----");
                Console.WriteLine("Benzin Yakıt Tankı %{0} Doludur", (benzintank / 10));
                Console.WriteLine("Lpg Yakıt Tankı %{0} Doludur", (lpgtank / 10));
                Console.WriteLine("Dizel Yakıt Tankı %{0} Doludur", (dizeltank / 10));
                Console.WriteLine(" ");
            ALTMENU7:
                Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                try
                {
                    altmenusecim = Convert.ToChar(Console.ReadLine());
                    if (altmenusecim == '1')
                    {
                        goto MENU;

                    }
                    else if (altmenusecim == '2')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                        goto ALTMENU7;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto ALTMENU7;
                }
            }
            else if (anamenusecim == '5')
            {
                Console.Clear();
                Console.WriteLine("Seçiminiz=5");
                Console.WriteLine("-----Toplam Satış Durumu-----");
                Console.WriteLine("Satılan Toplam Benzin Yakıt :{0}", 1000 - benzintank);
                Console.WriteLine("Benzin Yakıt Tutarı :{0}", (1000 - benzintank) * benzin);
                Console.WriteLine("Satılan Toplam Benzin Yakıt :{0}", 1000 - benzintank);
                Console.WriteLine("Lpg Yakıt Tutarı :{0}", (1000 - lpgtank) * lpg);
                Console.WriteLine("Satılan Toplam Benzin Yakıt :{0}", 1000 - benzintank);
                Console.WriteLine("Dizel Yakıt Tutarı :{0}", (1000 - dizeltank) * dizel);
                Console.WriteLine(".........................");
                Console.WriteLine("Toplam Tutar:{0}", ((1000 - benzintank) * benzin) + ((1000 - benzintank) * benzin) + ((1000 - benzintank) * benzin));
                Console.WriteLine(" ");
            ALTMENU8:
                Console.WriteLine("Seçiminizi yapınız:     1.Anamenüye Dön     2.Programı Kapat");
                try
                {
                    altmenusecim = Convert.ToChar(Console.ReadLine());
                    if (altmenusecim == '1')
                    {
                        goto MENU;
                    }
                    else if (altmenusecim == '2')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Bir İşlem Yaptınız");
                        goto ALTMENU8;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Yanlış Tuşa Bastınız");
                    goto ALTMENU8;
                }
            }
            else if (anamenusecim == '6')
            {
                Environment.Exit(0);
            }

            Console.ReadKey();
            
        }
    }
}
