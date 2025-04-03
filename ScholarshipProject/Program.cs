using ScholarshipProject.Models;
using ScholarshipProject.Repos;

Console.WriteLine("1. feladat");
try
{
    ScholarshipApplicant empty = new ScholarshipApplicant("", "Null");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("2. feladat");
ScholarshipApplicant odon = new ScholarshipApplicant("odon@nyertes.hu", "Ösztöndíj Ödön");
Console.WriteLine(odon);

// Ösztöndíjasok száma
Console.WriteLine("3. feladat");

ScholarshipRepo repo = new();
Console.WriteLine($"Ösztöndíjasok száma: {repo.GetNumberOfScholarship()} fő.");

// Min, Max
Console.WriteLine($"Legnagyobb száma: {repo.GetBiggestNumber()} Ft");
Console.WriteLine($"Legkisebb száma: {repo.GetLowestNumber()} Ft");
Console.WriteLine($"Összes száma: {repo.GetAllScholarships()} Ft");
Console.WriteLine($"Átlag: {repo.GetAvarage()} Ft");