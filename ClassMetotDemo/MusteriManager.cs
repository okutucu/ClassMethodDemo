using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void add(Musteri musteri)
        {

            Console.WriteLine(musteri.Adi +" isimli müşteri başarılı bir şekilde eklenmiştir.");


        }
        public void delete(Musteri musteri)
        {

            Console.WriteLine(musteri.Adi +  "isimli müşteri başarılı bir şekilde silinmiştir.");


        }
        public void Listele (Musteri[] musteri)
        {

            foreach (var m in musteri)
            {

                Console.WriteLine(m.Id + " " +  m.Adi + " " + m.Soyadi + " " + m.DogumYili + " " + m.Meslek);

            }


        }
            
            






    }
}
