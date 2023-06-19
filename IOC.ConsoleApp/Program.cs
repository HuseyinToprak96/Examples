using IOC.ConsoleApp;
using System.Security.Cryptography.X509Certificates;

Bl bl = new Bl();
bl.GetProducts().ForEach(p =>
Console.WriteLine($"{p.Id}-{p.Name}-{p.Price}-{p.Stock}"));
Console.ReadLine();