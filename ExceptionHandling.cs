using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    // exceptiondan türemesi lazım customexception oluşturmamız için.
    public class ExceptionHandling : Exception
    {
        // normal akışı bozan olaylardaki hataları özelleştirmek istediğimiz durumlarda kullanırız.
        // istisnai durumları yöneteceğimiz bir yapıdır.
        public ExceptionHandling() : base("This is a custom exception")
        {
        }
        public ExceptionHandling(string message) : base(message)
        {
        }

    }
}
