using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class Implicit_Explicit_Operators_Overloading
    {
        // bir verinin kendi türünden olmayan farklı bir referansa
        // yahut değişkene atanabilmesi için , atanma sürecinde
        // yapılan tür dönüştürme işlemlerini açıklamak için kullanılan kavramlardır.

        // Implicit Conversion : Kapalı Dönüşüm

        //public static implicit/explicit operator T1(T2 t2)
        //{
        //    // return new T1();
        //}
        public class ImplicitA
        {

            public static implicit operator ImplicitA(ImplicitB a)
            {
                return new ImplicitA() { };
            }

        }
       public class ImplicitB
        {

            public static explicit operator ImplicitB(ImplicitA a)
            {
                return new ImplicitB() { };
            }

        }

    }
}
