using IOC.ConsoleApp;
using System.Security.Cryptography.X509Certificates;

Bl bl = new Bl(new OracleDal());
Bl bl1 = new Bl(new Dal());
Console.WriteLine("Oracle DB");
bl.GetProducts().ForEach(p =>
Console.WriteLine($"{p.Id}-{p.Name}-{p.Price}-{p.Stock}"));
Console.WriteLine("Sql DB");
bl1.GetProducts().ForEach(p =>
Console.WriteLine($"{p.Id}-{p.Name}-{p.Price}-{p.Stock}"));
Console.ReadLine();