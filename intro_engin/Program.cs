// See https://aka.ms/new-console-template for more information
using intro_engin.Business;
using intro_engin.DataAccess.Concretes;
using intro_engin.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

bool isAunthenticated = false;
Console.WriteLine(message1);

// condition (şart)
if (isAunthenticated)
{
    Console.WriteLine("Hoşgeldin Deniz");
}
else
{
    Console.WriteLine("Sisteme giriş yap ");
}

string kredi1 = "kredi1";
string kredi2 = "kredi2";
string kredi3 = "kredi3";
string kredi5 = "kredi5";
string kredi6 = "kredi6";
Console.WriteLine("Kod bitti");

//string[] loans2 = new string[6];
//loans2[0] = "kredi1";

string[] loans = { "kredi 1", "kredi 2", " kredi 3", "kredi 4", "kredi 5" };
for (int i = 0; i <loans.Length ; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new(new CourseDal()); 
List<Course> course2 = courseManager.GetAll();

for (int i = 0; i < course2.Count; i++)
{
    Console.WriteLine(course2[i].Name + " " + course2[i].Price);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NayionalIdentity = "23056351515";
customer1.FirstName = "Deniz";
customer1.LastName = "Alan";
customer1.CustomerNumber = "12345678";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NayionalIdentity = "23056351515615";
customer2.FirstName = "Denid";
customer2.LastName = "Alann";
customer2.CustomerNumber = "12345678165";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama";
customer3.CustomerNumber = "15556315";
customer3.TaxNumber = "15646615";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "15556315";
customer4.TaxNumber = "156466111";
                                //101       //102         //103   //104
BaseCustormer[] custormers = { customer1, customer2 , customer3, customer4};

//polymorphizm
foreach (BaseCustormer custormer in custormers)
{
    Console.WriteLine(custormer.CustomerNumber);

}

