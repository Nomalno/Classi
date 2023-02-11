using ConsoleApp13;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

string[] SurNames = { "Иванов", "Стрельцов", "Дмитриев", "Ковалёв", "Белов" };
string[] Names = { "Владимир", "Виталий", "Игорь", "Альберт", "Антон" };
string[] FathNames = { "Владимирович", "Дмитриевич", "Ильич", "Иванович", "Игоревич"};

Random random = new Random();
    FName[] FullName = new FName[5] { new FName(), new FName(), new FName(), new FName(), new FName() };
    for (int i = 0; i < FullName.Length; i++)
    {
    FullName[i].SurName = SurNames[random.Next(5)];
    FullName[i].Name= Names[random.Next(5)];
    FullName[i].FathName = FathNames[random.Next(5)];
    Console.WriteLine(FullName[i].SurName + " " + FullName[i].Name+ " " + FullName[i].FathName);
    }
Console.ReadKey();

//В классе Program.cs создать массив из 5 экземпляров данного класса и вывести его на экран
