using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class OperatorOverloading
    {
        // operator overloading belirli var olan operatorlerin davranışlarını özelleştirmeye yarar. 

     

        public class Student
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; } = new();

            // void döndüremezsin yasak!!
            // public ve static tanımlama mecburiyetindeyiz
            // içerisine verilen t1 ve t2 parametlerinden biri
            // içerisinde tanımlandığı sınıf tipinden olmalı örn : biri Student olmalıdır
            //public static TResult operator +(T1 t1 , T2 t2)
            //{ 
            //    ...
            //return t1
            //}
        }
        public class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }

            public static Student operator +(Student student, Book book)
            {
                student.Books.Add(book);
                return student;
            }
            // simetrik şekilde tanımlarsak + operatörünün sağına ya da soluna koyabiliriz.
            public static Student operator +( Book book, Student student)
            {
                student.Books.Add(book);
                return student;
            }
        
        }

        // overloading yapamayacağımız operatorler vardır.










            
    }
}
