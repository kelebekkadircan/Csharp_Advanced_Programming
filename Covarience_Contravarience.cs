using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class Covarience_Contravarience
    {
        public  class CovarienceA 
        {
            public virtual  CovarienceA getVarience()
            {

               return new CovarienceA();
            }
        }

        
        public  class CovarienceB : CovarienceA
        {
            // bu durumda covarience geçerlidir
            // geri dönüş türlerini değiştirebiliyoruz ismi aynı kalıyor
            public override CovarienceB getVarience()
            {
                return new CovarienceB();
            }

        }
        
        // eğer out koymaz isek bu durumda covarience davranışı geçerli olmaz.
        // out keywordü için delegate ve interface kullanmalıyız.
        public interface IAnimal<out T>
        {
            T getAnimal();
        }

        public class Animal<T> : IAnimal<T>
        {
            public T getAnimal()
            {
                throw new NotImplementedException();
            }
        }

        public interface IHuman <in T>
        {

        }

        public class Human<T> : IHuman<T>
        {

        }



    }
}
