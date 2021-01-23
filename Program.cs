using System;
using System.Collections.Generic;

namespace MyDictionaryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sinifListesi = new MyDictionary<int, string>();
            sinifListesi.Add(143 , "Mehmet");
            sinifListesi.Add(153 , "Ayse");
            sinifListesi.Add(764 , "Mete");
            sinifListesi.Add(199 , "Bahar");
            sinifListesi.Add(415 , "Emir");
            sinifListesi.Add(73, "Yusa");



            //
            for (int i = 0; i < sinifListesi.Count(); i++)
            {
                Console.WriteLine(sinifListesi.GetValue(i));
            }
            //
            try
            {
                Console.WriteLine("Ogrenci No Giriniz: ");
                int key;
                key = int.Parse(Console.ReadLine());
                for (int i = 0; i < sinifListesi.Count(); i++)
                {
                    if (key == sinifListesi.GetKey(i))
                    {
                        string print = sinifListesi.GetValueByKey(key);
                        Console.WriteLine(print);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            //
            try
            {
                Console.WriteLine("Ogrenci ismi giriniz: ");
                string key;
                key = Console.ReadLine();
                for (int i = 0; i < sinifListesi.Count(); i++)
                {
                    if (key == sinifListesi.GetValue(i))
                    {
                        var print = sinifListesi.GetKeyByValue(key);
                        Console.WriteLine(print);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
            Console.WriteLine($"Sınıf Mevcudunuz: {sinifListesi.Count()}");
                
            
           

           
       

        }
    }
}
