using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class AccessModifiers
    {
        // public 
        // bir elemanın proje içerisinde her hangi bir yerden erişilebilir olmasını sağlar. sınıf metot property field gibi elemanlar public olarak tanımlanabilir.
        public string AccessModifiersNamepublic;

        // private
        // yalnızca içinde tanımlandığı class içerisinden erişilebilir. class interface vs private olarak tanımlanamaz.
        private string AccessModifiersNameprivate2;

        // protected
        // yalnızca tanımlandığı sınıf ya da türetilen alt sınıfların içerisinden erişilebilir.yani türe ait instanceler üzerinden erişilmez.   
        // class inherit edildiyse class modeli içerisinde erişilebilir. ama instance üzerinden olmaz. farklı bir proje üzerinden inherit edildiyse erişilebilir.
        protected string AccessModifiersNameprotected3;

        // internal
        // yalnızca tanımlandığı proje içerisinden erişilebilir. başka bir proje üzerinden erişilemez.
        // classlar default olarak internallardır. yani dışarıdan erişilemezler. farklı projelerden erişilebilir olması için public olarak tanımlanmalıdır.
        internal string AccessModifiersNameInternal4;

        // protected internal
        // protected ve internal özelliklerini birleştirir. yani tanımlandığı proje içerisinden ve türetilen sınıflar içerisinden erişilebilir.eğer kalıtım varsa
        // aynı proje içinde kalıtım yoksa bile erişebiliirz . fakat farklı proje için kalıtım istiyor.
        protected internal string AccessModifiersNameProtectedInternal5;




        // private protected
        // protected olduğu için ilgili sınıftan türeyenlerde erişilebilir.private olduğu için aynı assembly içerisindeki sınıflardan erişilebilir.
        // protected internaıl tam tersidir
        private protected string AccessModifiersNamePrivateProtected6; 



    }
}
