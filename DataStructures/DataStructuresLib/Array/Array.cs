using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresLib.Array
{
    public class Array<T> : IEnumerable<T>,ICloneable//numaralandırma yapabilmemizi sağlayacak ve LINQ kullanılabilecek
    {
        private T[] InnerList;
        public int Count { get; private set; }//prop yazdık ve intelisense çalıştı
        public int Capacity => InnerList.Length;

        public Array()
        {
            //ctor codesnip ile bu kısım oluşturuldu//;OOP de otomatik bir yapılandırıcı var yazmaya gerek yok aslında
            //ama konstructor ile çalışşacaksak gerek olabilir.Geri dönüş olarak bir tipi yok ,özel bir method bu amacı
            //tanımlamaları atamaları yapmak aslında burda tanımlayıp daha sonra kullanabilyoruz new ile
            InnerList = new T[2]; // 2 elemanlı
            Count = 0;
        }
        public Array(params T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            Add(item);
            
        }
        public Array(IEnumerable<T> collection)
        {
            InnerList=new T[collection.ToArray().Length];
            Count=0;
            foreach(var item in collection)
                Add(item);
        }

        public void Add(T item) {
            //Dizinin dinamik olarak genişlemesini sağlamak için şart koyuyoruz
            if (InnerList.Length == Count)
                DoubleArray();
            InnerList[Count] = item;
            Count++;
        }
        public void AddRange(IEnumerable<T> collection) //birden fazla elemanı koleksiyona eklemeye yarar
        {
            // var tempList = new T[collection.ToArray().Length] ;
            foreach (var item in collection)
            {
                //if(item != T)
                Add(item);
            }               
        }
        

        private void DoubleArray() {
            var temp= new T[InnerList.Length*2];//boyutu 2 ye katlar
            /*for (int i = 0; i < temp.Length; i++)
            {
                temp[i]=InnerList
            }*/
            System.Array.Copy(InnerList,temp,InnerList.Length);
            InnerList = temp;

        }
        public T Remove() {
            if (Count == 0)
                throw new Exception("There is no more item to be removed from array.");
            if (InnerList.Length/4 == Count)            
                HalfArray();
            
            var temp = InnerList[Count-1];
            if(Count > 0)
                Count--;
            return temp;
        }
        public bool Remove(T item) { //HomeWork
            throw new Exception();
        }

        private void HalfArray() {
            if(InnerList.Length >2)
            {
                var temp = new T[InnerList.Length/2];
                System.Array.Copy(InnerList, temp,InnerList.Length/4);
                InnerList = temp;
            }
        }

        public object Clone() {
           //return this.MemberwiseClone(); //1.Yöntem sığcopy bu, kopyaa direkt geçmez özellikler daha doğru kopya yaptıktan sonra arra müdahale crr yi değiştirmez
           var arr = new Array<T>(); // burası dip copy 2. yöntem kopya baştan oluşturulur  
            foreach (var item in this)
                arr.Add(item);
            return arr;
        }
       

        public IEnumerator<T> GetEnumerator() {
            return InnerList.Take(Count).GetEnumerator(); //Select(x => x).GetEnumerator(); // take ile arraylistin boyutuı kadarını yazdırdık selecct olunca boş yerler sıdır olarak ekranda yazılıyordu
         }

         IEnumerator IEnumerable.GetEnumerator() {
             return GetEnumerator();
         }
    }
}
