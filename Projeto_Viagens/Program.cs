﻿using Projeto_Viagens.Controllers;
using Projeto_Viagens.Models;

public class Program
{
    private static int Menu()
    {
        Console.Clear();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("|".PadRight(35) + "|");
        Console.WriteLine("|          MENU DE OPÇÕES".PadRight(35) + "|");
        Console.WriteLine("|".PadRight(35) + "|");
        Console.WriteLine("|   [1] - Inserir".PadRight(35) + "|");
        Console.WriteLine("|   [2] - Editar".PadRight(35) + "|");
        Console.WriteLine("|   [3] - Deletar".PadRight(35) + "|");
        Console.WriteLine("|   [4] - Imprimir".PadRight(35) + "|");
        Console.WriteLine("|   [5] - Sair".PadRight(35) + "|");
        Console.WriteLine("|".PadRight(35) + "|");
        Console.WriteLine("------------------------------------\n");

        Console.Write("Escolha uma opção: ");
        int option = int.Parse(Console.ReadLine());

        return option;
    }

    private static void Main(string[] args)
    {
        int op;

        do
        {
            op = Menu();
            switch (op)
            {
                case 1:
                    InsertMenu();
                    break;
                case 2:
                    UpdateMenu();
                    break;
                case 3:
                    DeleteMenu();
                    break;
                case 4:
                    PrintMenu();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Encerrando programa...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("Programa encerrado!!!");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Por favor, insira uma opção válida");
                    Thread.Sleep(3000);
                    break;
            }
        } while (op != 5);
    }

    private static void InsertMenu()
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|".PadRight(46) + "|");
            Console.WriteLine("|               MENU DE INSERIR".PadRight(46) + "|");
            Console.WriteLine("|".PadRight(46) + "|");
            Console.WriteLine("|   [1] - Inserir Cidade".PadRight(46) + "|");
            Console.WriteLine("|   [2] - Inserir Endereço".PadRight(46) + "|");
            Console.WriteLine("|   [3] - Inserir Cliente".PadRight(46) + "|");
            Console.WriteLine("|   [4] - Inserir Passagem".PadRight(46) + "|");
            Console.WriteLine("|   [5] - Inserir Hotel".PadRight(46) + "|");
            Console.WriteLine("|   [6] - Inserir Pacote".PadRight(46) + "|");
            Console.WriteLine("|   [7] - Voltar ao Menu Principal".PadRight(46) + "|");
            Console.WriteLine("|".PadRight(46) + "|");
            Console.WriteLine("-----------------------------------------------\n");

            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    InsertCity();
                    break;
                case 2:
                    InsertAddress();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida");
                    Thread.Sleep(3000);
                    break;
            }
        } while (option != 7);
    }

    private static void UpdateMenu()
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("|".PadRight(45) + "|");
            Console.WriteLine("|               MENU DE EDITAR".PadRight(45) + "|");
            Console.WriteLine("|".PadRight(45) + "|");
            Console.WriteLine("|   [1] - Editar Cidade".PadRight(45) + "|");
            Console.WriteLine("|   [2] - Editar Endereço".PadRight(45) + "|");
            Console.WriteLine("|   [3] - Editar Cliente".PadRight(45) + "|");
            Console.WriteLine("|   [4] - Editar Passagem".PadRight(45) + "|");
            Console.WriteLine("|   [5] - Editar Hotel".PadRight(45) + "|");
            Console.WriteLine("|   [6] - Editar Pacote".PadRight(45) + "|");
            Console.WriteLine("|   [7] - Voltar ao Menu Principal".PadRight(45) + "|");
            Console.WriteLine("|".PadRight(45) + "|");
            Console.WriteLine("----------------------------------------------\n");

            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UpdateCity();
                    break;
                case 2:
                    UpdateAddress();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida");
                    Thread.Sleep(3000);
                    break;
            }
        } while (option != 7);
    }

    private static void DeleteMenu()
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("|".PadRight(46) + "|");
            Console.WriteLine("|               MENU DE DELETAR".PadRight(46) + "|");
            Console.WriteLine("|".PadRight(46) + "|");
            Console.WriteLine("|   [1] - Deletar Cidade".PadRight(46) + "|");
            Console.WriteLine("|   [2] - Deletar Endereço".PadRight(46) + "|");
            Console.WriteLine("|   [3] - Deletar Cliente".PadRight(46) + "|");
            Console.WriteLine("|   [4] - Deletar Passagem".PadRight(46) + "|");
            Console.WriteLine("|   [5] - Deletar Hotel".PadRight(46) + "|");
            Console.WriteLine("|   [6] - Deletar Pacote".PadRight(46) + "|");
            Console.WriteLine("|   [7] - Voltar ao Menu Principal".PadRight(46) + "|");
            Console.WriteLine("|".PadRight(46) + "|");
            Console.WriteLine("-----------------------------------------------\n");

            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    DeleteCity();
                    break;
                case 2:
                    DeleteAddress();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida");
                    Thread.Sleep(3000);
                    break;
            }
        } while (option != 7);
    }

    private static void PrintMenu()
    {
        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|".PadRight(48) + "|");
            Console.WriteLine("|               MENU DE IMPRESSÃO".PadRight(48) + "|");
            Console.WriteLine("|".PadRight(48) + "|");
            Console.WriteLine("|   [1] - Imprimir Cidade".PadRight(48) + "|");
            Console.WriteLine("|   [2] - Imprimir Endereço".PadRight(48) + "|");
            Console.WriteLine("|   [3] - Imprimir Cliente".PadRight(48) + "|");
            Console.WriteLine("|   [4] - Imprimir Passagem".PadRight(48) + "|");
            Console.WriteLine("|   [5] - Imprimir Hotel".PadRight(48) + "|");
            Console.WriteLine("|   [6] - Imprimir Pacote".PadRight(48) + "|");
            Console.WriteLine("|   [7] - Voltar ao Menu Principal".PadRight(48) + "|");
            Console.WriteLine("|".PadRight(48) + "|");
            Console.WriteLine("-------------------------------------------------\n");

            Console.Write("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintCity();
                    break;
                case 2:
                    PrintAddress();
                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:

                    break;
                case 6:

                    break;
                case 7:
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida");
                    Thread.Sleep(3000);
                    break;
            }
        } while (option != 7);
    }

    private static void InsertCity()
    {
        Console.Clear();
        Console.Write("Digite o nome da cidade: ");
        string name = Console.ReadLine();
        Console.Write("Digite a data de registro da cidade: ");
        DateTime registrationDate = DateTime.Parse(Console.ReadLine());

        City city = new City { Name = name, RegistrationDate = registrationDate };

        if (new CityController().Insert(city))
        {
            Console.Clear();
            Console.WriteLine("Cidade inserida com sucesso!");
            Thread.Sleep(3000);
        }
    }

    private static void UpdateCity()
    {
        Console.Clear();
        new CityController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCity()));

        Console.Write("Digite o valor do ID da cidade que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Digite o novo nome da cidade: ");
        string name = Console.ReadLine();
        Console.Write("Digite a nova data de registro da cidade: ");
        DateTime registrationDate = DateTime.Parse(Console.ReadLine());

        City city = new City { Name = name, RegistrationDate = registrationDate };

        if (new CityController().Update(city, id))
        {
            Console.Clear();
            Console.WriteLine("Cidade editada com sucesso!");
            Thread.Sleep(3000);
        }
    }

    private static void DeleteCity()
    {
        Console.Clear();
        new CityController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCity()));
        Console.Write("Digite o valor do ID da cidade que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());

        if (new CityController().Delete(id))
        {
            Console.Clear();
            Console.WriteLine("Cidade deletada com sucesso!");
            Thread.Sleep(3000);
        }
    }

    private static void PrintCity()
    {
        do
        {
            Console.Clear();
            new CityController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCity()));
            Console.WriteLine("Aperte ENTER para retornar ao Menu de Impressão");
        } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    private static void InsertAddress()
    {
        Console.Clear();
        new CityController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCity()));
        Console.Write("O endereço a ser cadastrado já possui uma cidade cadastrada [S / N]: ");
        char choice = char.Parse(Console.ReadLine().ToUpper());

        if (choice.Equals('S'))
        {
            Console.Write("\n\n" + "Digite o nome do endereço: ");
            string street = Console.ReadLine();
            Console.Write("Digite o número do endereço: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Digite o bairro do endereço: ");
            string neighborhood = Console.ReadLine();
            Console.Write("Digite o CEP do endereço: ");
            string postalCode = Console.ReadLine();
            Console.Write("Digite o complemento do endereço (se houver): ");
            string complement = Console.ReadLine();
            Console.Write("Digite a data de registro do endereço: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o número do ID da cidade: ");
            int id = int.Parse(Console.ReadLine());
            Address address = new Address
            {
                Street = street,
                Number = number,
                Neighborhood = neighborhood,
                PostalCode = postalCode,
                Complement = complement,
                RegistrationDate = registrationDate,
            };

            if (new AddressController().Insert(address, id))
            {
                Console.Clear();
                Console.WriteLine("Endereço inserido com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Write("\n\n" + "Digite o nome do endereço: ");
            string street = Console.ReadLine();
            Console.Write("Digite o número do endereço: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Digite o bairro do endereço: ");
            string neighborhood = Console.ReadLine();
            Console.Write("Digite o CEP do endereço: ");
            string postalCode = Console.ReadLine();
            Console.Write("Digite o complemento do endereço (se houver): ");
            string complement = Console.ReadLine();
            Console.Write("Digite a data de registro do endereço: ");
            DateTime registrationDateAddress = DateTime.Parse(Console.ReadLine());
            Address address = new Address
            {
                Street = street,
                Number = number,
                Neighborhood = neighborhood,
                PostalCode = postalCode,
                Complement = complement,
                RegistrationDate = registrationDateAddress
            };

            Console.Write("Digite o nome da cidade: ");
            string name = Console.ReadLine();
            Console.Write("Digite a data de registro da cidade: ");
            DateTime registrationDateCity = DateTime.Parse(Console.ReadLine());
            City city = new City
            {
                Name = name,
                RegistrationDate = registrationDateCity
            };

            if (new CityController().Insert(city))
            {
                Console.Clear();
                Console.WriteLine("Cidade inserida com sucesso!");
                Thread.Sleep(3000);
            }

            if (new AddressController().Insert(address, city))
            {
                Console.Clear();
                Console.WriteLine("Endereço inserido com sucesso!");
                Thread.Sleep(3000);
            }
        }
    }

    private static void UpdateAddress()
    {
        Console.Clear();
        new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));

        Console.Write("Digite o valor do ID da cidade que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Digite o novo nome do endereço: ");
        string street = Console.ReadLine();
        Console.Write("Digite o novo número do endereço: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Digite o novo bairro do endereço: ");
        string neighborhood = Console.ReadLine();
        Console.Write("Digite o novo CEP do endereço: ");
        string postalCode = Console.ReadLine();
        Console.Write("Digite o novo complemento do endereço: ");
        string complement = Console.ReadLine();
        Console.Write("Digite a nova data de registro do endereço: ");
        DateTime registrationDate = DateTime.Parse(Console.ReadLine());

        Address address = new Address
        {
            Street = street,
            Number = number,
            Neighborhood = neighborhood,
            PostalCode = postalCode,
            Complement = complement,
            RegistrationDate = registrationDate
        };

        if (new AddressController().Update(address, id))
        {
            Console.Clear();
            Console.WriteLine("Endereço editado com sucesso!");
            Thread.Sleep(3000);
        }
    }

    private static void DeleteAddress()
    {
        Console.Clear();
        new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));
        Console.Write("Digite o valor do ID do endereço que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());

        if (new AddressController().Delete(id))
        {
            Console.Clear();
            Console.WriteLine("Endereço deletado com sucesso!");
            Thread.Sleep(3000);
        }
    }

    private static void PrintAddress()
    {
        do
        {
            Console.Clear();
            new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));
            Console.WriteLine("Aperte ENTER para retornar ao Menu de Impressão");
        } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }
}