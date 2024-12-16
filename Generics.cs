using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class Generics
    {
        // classlar generic olabilir , metodlar , structlar  , interfa
        //
        // // birden fazla t eklenebilir
       public class GenericsMyClass<T1, T2 ,T3,T4> {
            public T1 x; // t türünden x olacak int string ve ya kadir türünden
            public T2 Y; // t1 türünden y olacak int string ve ya kadir türünden
            public T3 TMethod1() {
                return default(T3);
            }
            public T4 TMethod2(T3 t3) {
                return default(T4);
            }
        }
        // kuralları =>  sınıf adının sonuna <parametre> eklenmelidir 
        // generic sınıflar her türlü kalıtıma uygundur
        // generic metotlar classtan bağımsız olarak generic olabilirler
        public T GenericMethod<T>(T t) {
            return t;
        }

        // CONSTRAINTS => kısıtlamalar
        // where T : class => t türü class olmalıdır
        // referans türlü olmalıdır
        class GenericConstraintsMyClass<T> where T : class // t bir class olmalı diyoruz
        {
            public T x;
        }    
        // değer türlü bir tür olmalıdır
        class GenericConstraintsMyClass2<T> where T : struct // t bir değer türü olmalı diyoruz
        {
            public T x;
        }
        // OVERLOADING YAPILABİLİR




    }
}
