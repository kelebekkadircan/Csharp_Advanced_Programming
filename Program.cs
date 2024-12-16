using C__Advanced_Programming;
using System.Dynamic;
using static C__Advanced_Programming.Implicit_Explicit_Operators_Overloading;
using static C__Advanced_Programming.OperatorOverloading;


Console.WriteLine("MAIN SAYFASINA HOŞGELDİN DOSTUM");
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

#region ExceptionHandling
//ExceptionHandling exceptionHandling = new();
//int exceptionValue = 0;
//int exceptionValue2 = 1;
//try
//{
//    int result = exceptionValue2 / exceptionValue;
//}
//catch(Exception ex)
//{
//    // burada exceptionHandling sınıfından türettiğimiz custom exceptionu yakalarız.
// // throw ile fırlatılan sınıflar Exception sınıfından türemiş olması zaruridir. Exceptiondan türemeyen sınıflar fırlatılamaz.
//    throw new ExceptionHandling("This is a custom exception");
//}


#endregion

#region Dynamic_Object

//Dynamic_Object dynamic_Object = new();


// ctor tetiklenir ve dinamik olarak üretilir.
//Activator.CreateInstance(typeof(Dynamic_Object));


// burada ilgili intance içerisinde olmayan propertyleri kullanabiliyoruz.
//dynamic instance = new Dynamic_Object();
//instance.DynamicProperty1 = "Dynamic Property1";
//instance.DynamicProperty2 = 12345;

//// burada direkt kendisi üretiyor ve propertyleri kullanabiliyoruz.
//dynamic instace2 = new ExpandoObject();
//instace2.DynamicProperty3 = "Dynamic Property3";
//instace2.DynamicProperty4 = 678;

//Console.WriteLine($"{instace2.DynamicProperty3} - {instace2.DynamicProperty4}");

#endregion

#region Generics

#endregion