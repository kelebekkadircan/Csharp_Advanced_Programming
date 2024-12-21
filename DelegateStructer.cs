using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class DelegateStructer
    {
        // metot referanslarını temsil eden türlerdir.
        //bir metodu bir değişkene atamak için kullanılır.
        // Dinamik olarak çalışma zamanında metod çağrısı yapılmasına olanak tanır.
        // Farklı metotların aynı işlemi nasıl gerçekleştirdiğini soyutlayarak esneklik sağlar.
        // callback functionların c# hali

        public delegate int MathOperation(int a, int b); // delegate tanımlama

       public  int Add(int a, int b)
        {
            return a + b;
        }

      public   int Subtract(int a, int b)
        {
            return a - b;
        }




        // bir delegate ne zaman ihtiyaç duyarız => esas olarak nesnenin davranışını özelleştirmek için kullanılır. yemek yapmayı örnek olarka düşün

        public class DelegateA
        {
            public DelegateA()
            {
                Console.WriteLine("DelegateA");
            }

        }

      public  void DelegateX()
        {
            Console.WriteLine("DelegateX");
        }

        public (int,char) DelegateY(DelegateA a, (string, int) p)
        {
            Console.WriteLine("DelegateY");
            return (0, 'a');
        }

        public delegate void XHandler ( );
        public delegate (int , char) YHandler(DelegateA a , (string,int) p);





        // Generic Delegate
        public delegate T3 GenericDelegateHandler<T1,T2,T3>(T1 arg1 , T2 arg2);




    }

    public class PreDefinedDelegates
    {
        // uygun senaryolarda hızlı aksyion almak için kullanılır.
        // işlevsel programlama konspetlerini uygulayabilmek için vardır.
        // hepsi generic parametreler alabilir.
        // Action => geriye değer döndürmeyen metotları temsil eder. // generic türde parametre alabilir
        // Func => geriye değer döndüren metotları temsil eder. generic ve parametre alabilir. yine generic olarak. 
        // Predicate => geriye bool döndüren metotları temsil eder. generic parametre alabilir.

        
   





    }


}
