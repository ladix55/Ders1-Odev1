// See https://aka.ms/new-console-template for more information
using c_2024.Business;
using c_2024.Entities;
using System;

Console.WriteLine("Hello, World!");

Console.WriteLine("----------------******-----------------");

string message1 = "Krediler"; //mesaj
int term = 12; //vade
double amount = 100.50; //tutar-miktar
//veriables --> camelCase (iki kelime olursa ilk harf küçük diğer kelime işlk harf büyük)
bool isAuthenticated = false; //giriş yapmış mı?

Console.WriteLine(message1);

Console.WriteLine("----------------******-----------------");

//condition (hal-koşul-şart)

if (isAuthenticated) //isAuthenticated true mi? diye bakıyor - if eğer tek bir kod çalışacaksa {} açmaya gerek yok.
{
    Console.WriteLine("Hoşgeldiniz");
}
else //isAuthenticated false olursa else komutu çalışıyor.
{
    Console.WriteLine("Sisteme giriş yap");
}

Console.WriteLine("----------------******-----------------");

//Array (diziler) aynı veri tipindeki değerleri tutmak için kullanılır.
string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6", }; //genelde db tarafından gelir.
//string[] loans2 = new string[6];
//loans2[0] = "kredi1"; --> şeklinde de tanımlanıp değer atanabilir.

//loop (döngü) 
for (int i = 0; i < loans.Length; i++) //loans.Length demek dizinin uzunluğu, eleman sayısı anlamında
{
    Console.WriteLine(loans[i]);
}

Console.WriteLine("----------------******-----------------");

/*
 Solution Explorer ekranında projeye sağ tıklayarak add->New folder diyerek yeni bir klasör oluşturuyoruz.Entities (varlıklar)
Yeni klaörün (Entities) içine tekrar add->class diyerek isim veriyoruz ve bize class dosyası oluşturuyor. Course (kurslar)
namespaces değerinin sonuna direk noktalı virgül koyarsak üst bölümde importlerın (girdilerin) olduğu alt kısımda class 
komutlarının yazılacağı sayfa karşımıza çıkıyor.
 */

Course course1 = new Course(); //class tanımlanırken new Course() şeklinde referans tanımlaması yapılır.
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net 8...";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Python";
course2.Description = "Python 3.5";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "JAVA";
course3.Description = "Java ile Nesene...";
course3.Price = 55;

Course[] courses = { course1, course2, course3 }; //class yapısı kullanarak girdiğimiz değerleri dizi içerisine alıyoruz.

for (int i = 0;i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name+ " --> "+ courses[i].Price);
}
Console.WriteLine("Course class yapısı çıktısı");

Console.WriteLine("----------------******-----------------");

CourseManager courseManager = new CourseManager(); //new yapısı gördüğünde ilgili classın contructor (yapıcı blok) çalışır.
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " --> " + courses2[i].Price);
}
/* Birinci ve İkinci class yapısındaki fark 
 * birinci class da veriler her işlemde tekrar oluşturulmalıdır.
 * ikinci class yapsıında ise bir defa tanımlanır bundan sonraki süreçte ilgili classın GetAll yapısı çağırılarak,
 * tekrar tekrar farklı alanlarda kullanılır.
 */
Console.WriteLine("CourseManager class yapısı çıktısı");

Console.WriteLine("----------------******-----------------");

Console.WriteLine("Kod Bitti");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FisrtName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "22987654321";
customer2.FisrtName = "Alp";
customer2.LastName = "Eren";
customer2.CustomerNumber = "654321";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Company";
customer3.CustomerNumber = "987654";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "XYZ Company";
customer4.CustomerNumber = "852963";
customer4.TaxNumber = "0987654321";

Console.WriteLine("----------------******-----------------");

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities1= cities2;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//Value Type --> int, bool, doble...
//Reference Type --> array, class, interface....


//Polymorphism
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}
