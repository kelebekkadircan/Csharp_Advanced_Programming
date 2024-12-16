using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C__Advanced_Programming
{
    public class RefReturnLocal
    {
       public int a = 5;
        public int b = 20;
        

        public void NormalRefUsage (ref int a)
        {
            Console.WriteLine($"Başlangıç değeri: {a}");
            a = 10;
            Console.WriteLine($"Yeni değeri: {a}");
        }

        // eğer dışarıdan içeriye referans verilen bir parametre ise kullanabiliriz yoksa local değişkenlerle kullanamayız.
       public ref int RefReturnLocalMethod(ref int c)
        {
            // global olarak tanımlanmış olması gerekiyor
            Console.WriteLine($"Başlangıç değeri: {c}");
            c = 30;
            Console.WriteLine($"Yeni değeri: {c}");
            return ref c;

            // bu örnekte değer local olduğu için hata alırız
            //int localValue = 10;
            //return ref localValue;


        }

        // deep copy yapmadan referansı döndürdüğümüz için b'nin değeri değişti.


    }
}
