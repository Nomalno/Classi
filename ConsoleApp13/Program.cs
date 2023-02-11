using ConsoleApp13;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

string[] FathNames = { "Владимир", "Виталя", "Игор", "Альберт", "Мурад"};
string[] SurNames = { "Владимир", "Виталя", "Игор", "Альберт", "Мурад" };
string[] Names = { "Владимир", "Виталя", "Игор", "Альберт", "Мурад" };

Random random = new Random();
    FName[] FullName = new FName[5] { new FName(), new FName(), new FName(), new FName(), new FName() };
    for (int i = 0; i < FullName.Length; i++)
    {
    FullName[i].Name= FathNames[random.Next(5)];
    FullName[i].SurName = SurNames[random.Next(5)];
    FullName[i].FathName = Names[random.Next(5)];
    Console.WriteLine(FullName[i].SurName + " " + FullName[i].Name+ " " + FullName[i].FathName);
    }
Console.ReadKey();

//random.Next(5);

/* { "qq", "qq", "qq" },{"gg","ez","aga" } };*/





//string[] FathNames = { "Владимир", "Виталя", "Игор", "Альберт", "Мудар", "Джиган", "Артур", "Даниил", "Максим", "Джон" };
//В классе Program.cs создать массив из 5 экземпляров данного класса и вывести его на экран