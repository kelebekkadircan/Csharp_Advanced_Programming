using C__Advanced_Programming;
using static C__Advanced_Programming.Implicit_Explicit_Operators_Overloading;
using static C__Advanced_Programming.OperatorOverloading;



//class Program
//{
//    static void Main(string[] args)
//    {
//        Arrays arrays = new Arrays();
//        arrays.ArrayExample();
//    }
//}


#region Arrays

//Arrays arrays = new Arrays();
////arrays.ArrayExample();
////arrays.ArrayExample2Dimension();
////arrays.DynamicArrayExample();
////arrays.TwoDimensionaldynamicArrayExample();
////arrays.NewTypeArrayExample();

#endregion


#region RefReturnLocal
//int deneme = 55;
//RefReturnLocal refReturnLocal = new();
//refReturnLocal.NormalRefUsage(ref refReturnLocal.a);
//// iki tarafı da ref ile işaretlemezsek hata alırız.
// ref int refValue =  ref refReturnLocal.RefReturnLocalMethod(ref deneme);
//refValue = 100;
//Console.WriteLine($" ref value Son değeri : {refValue}");
//Console.WriteLine($" deneme Son değeri : {deneme}");


#endregion


#region OperatorOverloading
//OperatorOverloading operatorOverloading = new();


//Book book1 = new() { Name = "Book1", Author = "Author1" };
//Student student1 = new() { Name = "Student1" };

//// it will be error because we have not defined the operator overloading
//var s = student1 + book1;

//Console.WriteLine( s.Name);
//foreach( var book in s.Books)
//{
//    Console.WriteLine($"Book Name : {book.Name} Author : {book.Author}");
//}

#endregion

#region Implicit_Explicit_Operators_Overloading
//Implicit_Explicit_Operators_Overloading implicit_Explicit = new();
//// IMPLICIT OPERATOR OVERLOADI İLE TÜR DÖNÜŞÜMÜNE İZİN VERİRİZ.
//ImplicitA ımplicitA = new ImplicitB();
//// EXPLICIT OPERATOR OVERLOADI İLE TÜR DÖNÜŞÜMÜNE İZİN VERİRİZ.
//ImplicitB ımplicitB = (ImplicitB)new ImplicitA();

//// burada explicite izin verdiğimiz için implicit kabul etmiyor sadece expliciti kabul eder.
//ImplicitB ımplicitB2 = new ImplicitA(); ;


#endregion

