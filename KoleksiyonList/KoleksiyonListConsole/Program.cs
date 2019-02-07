using System;

namespace KoleksiyonListConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ibanez75612 Tht Koleksiyon Listeleri Konusu


            //liste tipinde değişkenler
            //List<string> stringListe = new List<string>();
            //List<int> intListe = new List<int>();
            //List<decimal> decimalListe = new List<decimal>();
            //List<float> floatListe = new List<float>();
            //List<object> objectListe = new List<object>();

            #region Liste Hakkında
            //List<string> stringListesi = new List<string>();

            //stringListesi.Add("Eleman 1"); //Add() metodu ile elemanımızı eklemiş olduk
            //stringListesi.Add("Eleman 2");

            ////foreach tab tab yazılmış hali default olarak böyle gelir  gördüğünüz gibi collection istiyor 
            //foreach (var item in collection)
            //{

            //}
            ////kısa açıklaması
            ////var kısmı döndüreceğiniz koleksiyon(Listenin) tipi
            ////item sizin vereceğiniz dynamic bir değişken ismi
            ////in’i ellemiyoruz
            ////collection kısmına string listeyi vereceğiz
            ////foreach bana collection listesi ver diyor bende döneyim mantığında çalışır.



            //foreach (var list in stringListe) //stringliste bizim koleksiyon değişkenimiz 
            //{
            //    Console.WriteLine(list);///console uygulamasında ekrana sonucu döndürüyorum
            //}

            //Console.ReadLine();//console ekranı kapanmasın diye kullanıyoruz 

            ////değişken yazım kuralı ilk harf küçük sonraki 2.kelimenin ilk harbi büyük şekilde olmalı (Camel Case) !!

            ////bu string listeye eleman guid kullanarak ekleyelim

            //stringListe.Add(Guid.NewGuid().ToString()); //tekli ekledim

            #endregion
            #region Ornek1
            // //Örnek: Bir string koleksiyonu oluşturun ve o koleksiyona 10 adet random karakterler ekleyin ve onları listeleyin
            //List<string> randomListe = new List<string>(); //koleksiyon değişkeni oluşturuyorum
            //for (int i = 1; i <= 10; i++)
            //{
            //    randomListe.Add(+i + " Eleman " + Guid.NewGuid().ToString());  //döne döne 10 eleman ekleyecek  i 
            //}
            //foreach (var item in randomListe)
            //{
            //    Console.WriteLine(item); //foreach kullanarak dönüyorum ekrana yazıyorum dataları
            //}
            //Console.ReadLine();
            #endregion
            #region Ornek2

            //List<int> myNumbers = new List<int>(); //integer türünde liste oluşturdum

            //Random rnd = new Random(); ///random değişkeni random sayı bulmak için

            //for (int i = 0; i < 300; i++) //300 kere dönecek
            //{
            //    myNumbers.Add(rnd.Next(0, 100)); //300 kere 0 ile 100 arasındaki sayılar gelecek
            //}

            /////bu senaryoda kaç adet sayı eklenmiş onu bulalım bakalım
            /////
            /////int bir değişken tanımlıyorum değeri oraya atamak için

            //foreach (var item in myNumbers)
            //{
            //    Console.WriteLine("Random Sayı" + item);
            //}
            //int queryCount = myNumbers.Count; //int değişkene kaçtane data eklemişim yani kayıt sayısını atadım

            //Console.WriteLine(queryCount + " Adet İnteger Data Bulundu");

            ///// birde burada tüm gelen random sayıları toplayalım
            ///// tekrar integer degişken açıyorum
            //// / Sum yazdım sql deki gibi sonra lamba ile rastgele bir harf tanımlayıp => yaptım yani datayı kullan dedim
            //int querySum = myNumbers.Sum(s => s); //burada s=> lambda olarak geçer lambda dan korkmayınız ilk defa kullandığınızda garip gelebilir
            ////s yazdığım yere istediğiniz şeyi yazabilirsiniz dinamik çalışır  =>  yapmanız şartıyla çalışır ve toplama işlemini yapar

            //Console.WriteLine("Sayıların Toplamı" + querySum);//ekrana yazdırdım

            //Console.ReadLine();

            #endregion
            #region Ornek3
            ///// içerisinde A geçenleri getirip ekrana yazdıralım
            ///// var diye  bir değişkenede atabilirdim ama daha okunaklı olsun diye list string türünden yazdım var'da da aynısını yapacaktı
            ///// for ile 10 kere dönüp rastgele 10 elemanlı biri koleksiyon listesi oluşturuyorum
            ///// aşşağıdaki sorguda yuvarıda oluşan random karakterlerde 'a' harfini tüm kayıtların içerisinden arıyorum 
            ///// contains içinde geçenleri arar liste tipinden değişkenlerde kullanılır
            ///// sql de where sorgusunda like ile arama yapılır örnek select * from tablo where a like '%a%' bu ona eş değer bir sorgu
            ///// ancak where yazdım parantez açıp s=> yaptım bu lampda bu bizim yardımcı elementimiz sakın sizi korkutmasın
            ///// s.Contains yani s burda benim datalarım oluyor s.Contains diyorum içinde a olanları ara dedim parantezleri kapattım wherele de işim bitmiş oldu
            ///// tolist diyerek listele demiş oldum
            ///// 
            //List<string> aListe = new List<string>();

            ////queryi birde  dönerek ekrana yazdıralım bakalım hangilerinde a varmış
            //int value = 0; //birde bakalım kaçtane a çıkmış sayac olarak kullanalım
            //for (int i = 0; i < 10; i++)
            //{
            //    aListe.Add(Guid.NewGuid().ToString());//guid oluşturup elemanları ekliyoruz
            //}
            //List<string> query = aListe.Where(s => s.Contains("a")).ToList(); //where yazıp içerisinde lamba ile s yani dinamik değer ile stringin içide a ları aradiyorum ve ToList ile listeliyorum.
            //foreach (var item in query) ///item kısmı bizim değişken adımız istediğimiz şeyi yazarız var olan kısımı list<string>  yapabiliriz ama bu sefer var tercih ettim
            //{
            //    value += 1; //1 1 arttırıyorum
            //    Console.WriteLine(item); //ekrana listeyi yazdırıyorum
            //}

            //Console.WriteLine(value + "Karaterde de 'A' Bulundu");
            ////gördüğünüz gibi dizilerden daha rahat ve esnek
            //Console.ReadLine();


            #endregion
            #region Ornek4

            //List<string> elemanListesi = new List<string>(); //listemi oluşturdum

            //for (int i = 0; i < 50; i++)
            //{
            //    elemanListesi.Add(Guid.NewGuid().ToString());//elemanları listeye yazdırdım.
            //}
            //List<string> query = elemanListesi.Skip(20).Take(30).ToList();//Eleman listesini çektim Skip ile ilk 20 elemanı atladım daha sonra Take ile kalan 30 elemanı almış oldum
            //int value = 0; //eleman sayını bulmak için oluşturdum
            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);//elemanları ekrana yazdırıyorum
            //    value += 1;///eleman sayısı her seferinde 1 artıyor
            //}
            //Console.WriteLine("Eleman Sayısı {0}", value);//eleman sayınısı ekrana yazdırdım
            //Console.ReadLine();

            #endregion
            #region Ornek5
            //List<string> anyList = new List<string>()
            //{
            //    "Tht","ibanez75612"
            //};
            ///// küme parantezi açıpda böyle Add yerine ekleme yapabiliriz  bunuda unutmayalım araya sıkıştırmış olayım
            ///// 

            //bool returnValue = anyList.Where(s => s.Contains("Tht")||s=="Tht").Any();// ||veya operatörü ile gelen değer Thtye eşitse kontrolüde yaptım :)

            //if (returnValue)///koşulsuz yazma sebebim ifin default construckteri bool'a bakar
            //{
            //    Console.WriteLine("Tht Geçiyor");
            //}
            //else
            //{
            //    Console.WriteLine("Tht Geçmiyor");
            //}
            //Console.ReadLine();
            #endregion
            #region Ornek6
            //List<string> stringlist = new List<string>()
            //{
            //    "Türk","Hack","Team" ///elemanları , , şeklinde hiç add() demeden ekledim
            //};
            //Console.WriteLine(stringlist[0]);//Dizilerdeki gibi 0. elemanı alıyoruz
            //Console.WriteLine(stringlist[1]);
            //Console.WriteLine(stringlist[2]);
            //Console.ReadLine();
            #endregion
        }
    }
}
