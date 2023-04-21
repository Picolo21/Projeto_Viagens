using Projeto_Viagens.Controllers;
using Projeto_Viagens.Models;

public class Program
{
    private static void Main(string[] args)
    {
        new CityController().Insert(new City
        {
            Name = "Araraquara",
            RegistrationDate = DateTime.Now,
        });

        new CityController().FindAll().ForEach(x => Console.WriteLine(x));
    }
}