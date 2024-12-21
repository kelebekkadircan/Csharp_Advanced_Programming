using C__Advanced_Programming;
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Dynamic;
using static C__Advanced_Programming.Covarience_Contravarience;
using static C__Advanced_Programming.DelegateStructer;
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
//Generics generics = new();
//generics.GenericMethod<int>(5);


#endregion

#region Covarience_Contravarience
//// Polimorfizim
//Covarience_Contravarience covarience = new();
//// burada hata vermemesi için referansın poliformizim kurallarına uyması gerekir
//// CovarenceB nin CovarienceA dan kalıtım alması gibi
////CovarienceB : CovarienceA  kalıtım alıyor.
//CovarienceA covariencea = new CovarienceB();

//// büyük bir türe küçük bir türün atanmasına Covarience denir.
//// bu kodun derlenmesini covarience sağlar object sınıfına string atadık.
////Covarience 
//// daha spesifik olan bir türün daha genel bir türe atanmasına contravarience denir. => stingi objecte atadık
//object[] names = new string[5]
//{
//    "Ali",
//    "Veli",
//    "Deli",
//    "Mehmet",
//    "Ahmet"
//};


//// Covarience
//CovarienceA[] covarienceAray = new CovarienceB[3];
//IEnumerable<CovarienceA> covarienceAs = new List<CovarienceB>();
//// bu kodun derlenmesini covarience sağlar ve alttaki davranış covarience davranışıdır.
//IEnumerable<CovarienceB> covarienceAs2 = new List<CovarienceB>();
//IEnumerable<CovarienceA> covarienceAs3 = covarienceAs2;

//// covarience içerisinde referans daha büyük(object) iken nesne (string) gibi daha küçük bir türdür. // ,implicit conversion
////contravarience içerisnde ise durum tam tersidir referans(String) küçük iken nesne(object) gibi daha büyük bir türdür. // ,explicit conversion

////ArrayTypes  => alt türden oluşan bir dizinin üst türden oluşan bir diziye atanmasına covarience denir. ve implicit şekilde dönüştürülür.
////CovarienceA[] covarienceAray = new CovarienceB[3];
////object[] objects = new string[5]
////{
////    "Ali",
////    "Veli",
////    "Deli",
////    "Mehmet",
////    "Ahmet"
////};

//IAnimal<object> ianimal = new Animal<string>();






//// Contravarience
//// daha genel olan bir türün daha spesifik bir türe atanmasına contravarience denir. => object sınıfına string atadık.
//// küçük bir türe büyük bir tür atanmasına contravarience denir.
//// bu kodun derlenmesini contravarience sağlar
//// normalde programlamaya uygun bir mantık değildir.
//Action<string> xDelegate = Xmethod;
//void Xmethod(object o) {};


//// Delegate Yapısı
//// bu kodun derlenmesini contravarience sağlar ve alttaki davranış contravarience davranışıdır.
//Action<CovarienceA> Aaction = a => { };
//Action<CovarienceB> Baction = Aaction;

//IHuman<CovarienceA> human1 = new Human<CovarienceA>();
//// covarience =>  IHuman<CovarienceA> human1 = new Human<CovarienceB>();
//// contravarience davranışı
//IHuman<CovarienceB> human2 = new Human<CovarienceB>();

//// in ile kullanırken parametrede kullanabiliriz fakat return type olarak kullanamayız
//delegate void XHandler<in T>(T arg);
//// out ile kullanırken parametrede kullanamayız fakat return type olarak kullanabiliriz
//delegate T YHandler<out T>();

#endregion

#region Delegates

//DelegateStructer delegateStructer = new();

//// Delegate örneği oluşturma
//MathOperation addition = delegateStructer.Add;
//MathOperation subtraction = delegateStructer.Subtract;




//// Delegate çağrısı
//Console.WriteLine($"Addition: {addition(10, 5)}");
//Console.WriteLine($"Subtraction: {subtraction(10, 5)}");

////// Ornekler
//// xDelegate içerisindeki metotu çağırır.
//XHandler xDelegate = new XHandler(delegateStructer.DelegateX);
//// newlemeden direkt atayabiliriz.
//XHandler xDelegate2 = delegateStructer.DelegateX;
//// XHandler delegate türüne bir metot atamak için lambda expression kullanabiliriz. burada parametre almayan ve geri değer döndürmeyeni veriyoruz.
//XHandler xDelegate3 = () => { };

//// YHandler delegate türüne bir metot atamak için lambda expression kullanabiliriz. burada parametre alan ve geri değer döndüreni veriyoruz.
//YHandler yDelegate = delegateStructer.DelegateY;
//YHandler yDelegate2 = (a, p) => { return (0, 'a'); };

//xDelegate(); // out => DelegateX.
//xDelegate.Invoke(); // BU DA İMZAYA UYGUN PARAMETERLERİ İSTER.

// Generic Delegate


// PreDefinedDelegates

//PreDefinedDelegates preDefinedDelegates = new();

//preDefinedDelegates.preActionDelegate += (5, "aa", true) =>
//{

//};

// Action => geriye değer döndürmeyen metotları temsil eder. // generic türde parametre alabilir VOID!
//Action<int, string, bool> preDefinedActionDelegate = (a, b, c) => {
//    Console.WriteLine($"{a},{b},{c}");
//};

//// geriye int dönen  metotları temsil eden bir func delegate. sonuncu tür geri dönüş değerine karşılık gelir.
//Func<int, string, bool, int> preDefinedFuncDelegate = (a, b, c) => {
//    Console.WriteLine($"{a},{b},{c}");
//    return 0;
//};

//// generic türden veri alır ve bool döner. generic ile alacağı veriyi veririz.
//Predicate<int> preDefinedPredicateDelegate = (a) => {
//   return  a > 10 ? true : false;
//};

#endregion

#region EventBased

//EventBasedPublisher eventBased = new();

//// burada delegate void olan ve parametre almayan bir metot olduğu için lambda ile biz de o tarz atadık.
//eventBased.MyEventBased += () => { 
//};

//// yukarıda event için delegate gibi davrandık ve raise eventi tetikleyince delegate çalıştı.
//eventBased.RaiseEvent();

//eventBased.MyEventBased -= () => {
//};
// public olsa dahi instance üzerinden erişilemez.
//eventBased.EventBasedHandlerX;

//string path = @"C:\Users\keleb\Desktop\EventBasedExample";
//PathControl pathControl = new();

//pathControl.PathControlEvent += (sizeMb) =>
//{
//    Console.WriteLine("20 mb aştı");
//    Console.WriteLine($"Path size is {sizeMb} MB");
//};

//await pathControl.Control(path);



#endregion

#region AnonymousMembers

// İsimsiz Yapılar



////Anonymous Objects => Derleme zamanında tanımlanmıyor ve çalışma zamanında tanımlanıyor. anlık ve tek kullanımlık veri oluşturmada yararlıdır
// türünü bilmeden isimsiz tanım için var keywordu kullanılır. dynamic de olabilir runtime çalışma sergilenecekse
// herdaim readonly olacaktır
//var anonymousObject1 = new
//{
//    // anlık olara tanımlanır ve kullanılır. ne isim veriyorsak ne değer veriyorsak ona göre tip alıcaktır
//    Name = "Ali",
//    Surname = "Veli",
//    Age = 25
//};
// yeni bir sınıf tasarlayıp 1 kere kullanmaktansa o an kullanabileceğimiz bir yapı oluşturmak için kullanılır.

//// Anonymous Methods => metodu tanımlamadan direkt kullanmamızı sağlar
// GENELLİKLE DELEGATE İLE KULLANILIR.
//Topla toplaFunction = delegate (int a, int b)
//{
//    return a + b;
//};

//// Lambda Expression => kısa ve anlaşılır bir şekilde metot tanımlamamızı sağlar.
//// anonymous methodlardan daha kısa ve anlaşılır bir şekilde metot tanımlamamızı sağlar.
//var action1 = () => { };
//var action2 = ( char x ) => {  };
//var Func1 = (int x, int y) => { return x + y; };
//var Predicate1 = (int x) => { return x > 10 ? true : false; };
//delegate int Topla(int a, int b);


//// Anonymous Collection => koleksiyonları tanımlamadan direkt kullanmamızı sağlar
// array tanımlamadan direkt kullanmamızı sağlar.
//var x = new[] { 1, 2, 3, 4, 5 };
//// List 
//var y = new Collection()
//{
//    new { Name = "Ali", Surname = "Veli", Age = 25 },
//    new { Name = "Ali", Surname = "Veli", Age = 25 },
//    new { Name = "Ali", Surname = "Veli", Age = 25 }
//};



//// Riskleri NELERDİR



#endregion


#region ExpandoObjects
// Neden dinamik nesne üretme ihtiyacımız var => runtime da dinamik oluşturmak isteyebiliriz. kullanıcı verilerinin isteğe göre oluşturulması gibi
// expando object => runtime da oluşturulur ve kullanılır. genişletebilir bir yapıdır.

//dynamic expandoObject = new ExpandoObject();

//expandoObject.Name = "Ali";
//expandoObject.Surname = "Veli";
//expandoObject.Age = 25;



#endregion

#region AccessModifiers


#endregion