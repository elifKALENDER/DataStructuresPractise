using System;
using System.Collections;
using System.Collections.Generic;

namespace Applications {

    class Program {

        static void Main(string[] args) {

            ///*var p1=new DataStructuresLib.Array.Array<int>(1,2,3,4);// enumerate ile çalışıyor
            //var p2= new int[] { 8,9,10,11};// enumerate ile çalışıyor
            //var p3=new List<int>() { 5,15,20,25};// enumerate ile çalışır
            //var p4= new ArrayList() { 12,13,14};*/// tip güvenliğini sağlamaz int e döndiremiyor enumerate ile çalışmaz=> kutudan çıkar kutuya sokmantığı var boxing

            ///*//Array
            //char[] arrChar = new char[3] { 'b', 't', 'k' };
            ////var arrInt =Array.CreateInstance(typeof(int), 5);
            ////arrInt.SetValue(10,0);//0. indexe 10 değerini ver
            ////arrInt.SetValue(5,2);//2.indexe 5 değerini ver
            ////arrInt.GetValue(0);//ekrana 0.indexi bas yapabilirz bununla

            ////ArrayList
            //var arrObj = new ArrayList();
            //arrObj.Add(10);
            //arrObj.Add('b');

            ////List(T)
            //var arrInt = new List<int>();
            //arrInt.Add(10);
            //arrInt.Add('b');
            //foreach (var item in arrInt)
            //{
            //    Console.WriteLine(item);
            //}


            ////Coleksiyon yapısı diziyi daha yönetilebilir kılıyor ve eklem çıkarma daha kolay oluyor count gibi ifadelerde kullanabiliyoru koleksiyonda
            ////veri yapısı=koleksiyon bu ders kapsamında bu ifadeyi bu anlamda kullanıyoruz
            //*/

            //var arr = new DataStructuresLib
            //    .Array
            //    .Array<int>();
            //    //.Array<int>(p1);//buraya p1,p2,p3,p4 koyup deniyuoruz
            //    //.Array<int>(23,44,55,16);// bunu constructor sayesinde yaprık params kullnadığımız için gelen parametreler üzerinden müdahale yapabileceğiz
            //for (int i=0; i<8; i++)
            //{
            //    arr.Add(i + 1);
            //    Console.WriteLine($"{i+1} has been added to array.");
            //    Console.WriteLine($"{arr.Count}/{arr.Capacity} ");
            //}
            //Console.WriteLine();

            //for (int i=arr.Count; i >= 1;i--)
            //{
            //    Console.WriteLine($"{arr.Remove()} has been removed from the array.");
            //    Console.WriteLine($"{arr.Count}/{arr.Capacity}");

            //}
            //Console.WriteLine();
            //foreach (var item in arr)
            //    {
            //        Console.WriteLine(item);
            //    }
            ///* arr.Add (23);
            //arr.Add (55);
            //arr.Add (44);
            //arr.Add (12);
            //arr.Add (34);
            //foreach (int item in arr)// her elemanı alıp gösterir bunu enumarete sayesinde ve linq sayesinde oldu
            //{
            //    Console.WriteLine (item);
            //}

            ////arr.Remove();
            //Console.WriteLine ("____");
            //arr.Where(x=> x%2 == 0)//(Linq sayesinde bunu yapabildik)
            //    .ToList ()
            //    .ForEach (x => Console.WriteLine (x));
                
            //Console.WriteLine ($"{arr.Count} / {arr.Capacity}");*/
            
            var arr = new DataStructuresLib.Array.Array<int>(1,3,5,7);
            var crr = arr.Clone() as DataStructuresLib.Array.Array<int>;//(DataStructuresLib.Array.Array<int>)arr.Clone();// klonladığımızda arr ile aynı özelliklere sahip olamaz enumerate edilemez mesela
            var brr = new DataStructuresLib.Array.Array<int>(2,4,6);
            arr.Add(99);
            crr.Add(88);
            arr.AddRange(brr);
            
            foreach(int item in arr)
            {
                Console.Write($"{item,-3}");
            }
            Console.WriteLine($"{arr.Count}/{arr.Capacity}");

            Console.WriteLine();
            foreach(int item in crr)
            { 
                Console.Write($"{item,-3}");
            }
            Console.WriteLine($"{arr.Count}/{arr.Capacity}");
            //Dictionary ve hashset için de denmeler yap
            var dictionary = new Dictionary<int, string>();
            var hashSet = new HashSet<int>();

            Console.ReadKey();
        }
    }
}