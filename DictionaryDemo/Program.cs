using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aynen derste yaptığımız MyList gibi siz de kendi Dictonary sınıfınızı yazınız. (MyDictionary)
            //Sadece ekleme(Add) metodunu yazınız.

            MyDictionary<int,string> sehirler = new MyDictionary<int,string>();

            sehirler.Add(19, "Çorum");
            sehirler.Add(19, "Ankara");
            Console.WriteLine(sehirler.Length());
        }
    }
}
