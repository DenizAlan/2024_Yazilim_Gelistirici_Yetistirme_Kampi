// See https://aka.ms/new-console-template for more information
using intro_engin.Business;
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


CourseManager courseManager = new(); // ben bunu newledim demek
Course[] course2 = courseManager.GetAll();

for (int i = 0; i < course2.Length; i++)
{
    Console.WriteLine(course2[i].Name + " " + course2[i].Price);
}
