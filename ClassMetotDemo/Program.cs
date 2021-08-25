using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Adi = "Oğuzhan";
            musteri1.Id = 1;
            musteri1.Soyadi = "Kutucu";
            musteri1.DogumYili = 1995;
            musteri1.Meslek = "Developer";


            Musteri musteri2 = new Musteri();

            musteri2.Adi = "Kaan";
            musteri2.Id = 2;
            musteri2.Soyadi = "Kutucu";
            musteri2.DogumYili = 1994;
            musteri2.Meslek = "Grafiker";

            Musteri musteri3 = new Musteri();

            musteri3.Adi = "Veli";
            musteri3.Id = 3;
            musteri3.Soyadi = "Keresteci";
            musteri3.DogumYili = 2001;
            musteri3.Meslek = "Marangoz";


            Musteri[] musteri = new Musteri[] {musteri1 , musteri2, musteri3};


            MusteriManager musteriManager = new MusteriManager();


            musteriManager.add(musteri1);

            musteriManager.delete(musteri3);


            musteriManager.Listele(musteri);



        













        }
    }
}
