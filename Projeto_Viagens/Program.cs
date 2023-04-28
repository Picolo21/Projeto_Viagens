using Projeto_Viagens_ADO.NET.Controllers;
using Projeto_Viagens_ADO.NET.Models;

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
                    InsertCustomer();
                    break;
                case 4:
                    InsertTicket();
                    break;
                case 5:
                    InsertHotel();
                    break;
                case 6:
                    InsertPackage();
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
                    UpdateCustomer();
                    break;
                case 4:
                    UpdateTicket();
                    break;
                case 5:
                    UpdateHotel();
                    break;
                case 6:
                    UpdatePackage();
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
                    DeleteCustomer();
                    break;
                case 4:
                    DeleteTicket();
                    break;
                case 5:
                    DeleteHotel();
                    break;
                case 6:
                    DeletePackage();
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
                    PrintCustomer();
                    break;
                case 4:
                    PrintTicket();
                    break;
                case 5:
                    PrintHotel();
                    break;
                case 6:
                    PrintPackage();
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
        string? name = Console.ReadLine();
        Console.Write("Digite a data de registro da cidade: ");
        DateTime registrationDate = DateTime.Parse(Console.ReadLine());

        City city = new City { CityName = name, RegistrationDate = registrationDate };

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
        CityController cityController = new CityController();
        cityController.FindAll().ForEach(x => Console.WriteLine(x.ToStringCity()));

        Console.Write("Digite o valor do ID da cidade que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        if (cityController.FindAll().Exists(x => x.Id == id))
        {
            Console.Clear();
            Console.Write("Digite o novo nome da cidade: ");
            string? name = Console.ReadLine();
            Console.Write("Digite a nova data de registro da cidade: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());

            City city = new City { CityName = name, RegistrationDate = registrationDate };

            if (new CityController().Update(city, id))
            {
                Console.Clear();
                Console.WriteLine("Cidade editada com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void DeleteCity()
    {
        Console.Clear();
        CityController cityController = new CityController();
        cityController.FindAll().ForEach(x => Console.WriteLine(x.ToStringCity()));

        Console.Write("Digite o valor do ID da cidade que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());
        if (cityController.FindAll().Exists(x => x.Id == id))
        {
            if (new CityController().Delete(id))
            {
                Console.Clear();
                Console.WriteLine("Cidade deletada com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
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
            string? street = Console.ReadLine();
            Console.Write("Digite o número do endereço: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Digite o bairro do endereço: ");
            string? neighborhood = Console.ReadLine();
            Console.Write("Digite o CEP do endereço: ");
            string? postalCode = Console.ReadLine();
            Console.Write("Digite o complemento do endereço (se houver): ");
            string? complement = Console.ReadLine();
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
                RegistrationDate = registrationDate
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
            InsertCity();
            InsertAddress();
        }
    }

    private static void UpdateAddress()
    {
        Console.Clear();
        AddressController addressController = new AddressController();
        addressController.FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));

        Console.Write("Digite o valor do ID da cidade que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        if (addressController.FindAll().Exists(x => x.Id == id))
        {
            Console.Clear();
            Console.Write("Digite o novo nome do endereço: ");
            string? street = Console.ReadLine();
            Console.Write("Digite o novo número do endereço: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Digite o novo bairro do endereço: ");
            string? neighborhood = Console.ReadLine();
            Console.Write("Digite o novo CEP do endereço: ");
            string? postalCode = Console.ReadLine();
            Console.Write("Digite o novo complemento do endereço: ");
            string? complement = Console.ReadLine();
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
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void DeleteAddress()
    {
        Console.Clear();
        AddressController addressController = new AddressController();
        addressController.FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));

        Console.Write("Digite o valor do ID do endereço que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());
        if (addressController.FindAll().Exists(x => x.Id == id))
        {
            if (new AddressController().Delete(id))
            {
                Console.Clear();
                Console.WriteLine("Endereço deletado com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
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

    private static void InsertCustomer()
    {
        Console.Clear();
        new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));
        Console.Write("O Cliente a ser cadastrado já possui um endereço cadastrado [S / N]: ");
        char choice = char.Parse(Console.ReadLine().ToUpper());

        if (choice.Equals('S'))
        {
            Console.Write("\n\n" + "Digite o nome do cliente: ");
            string? name = Console.ReadLine();
            Console.Write("Digite o número do telefone do cliente: ");
            string? phone = Console.ReadLine();
            Console.Write("Digite a data de registro do cliente: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o número do ID do endereço: ");
            int id = int.Parse(Console.ReadLine());
            Customer customer = new Customer
            {
                CustomerName = name,
                Phone = phone,
                RegistrationDate = registrationDate
            };

            if (new CustomerController().Insert(customer, id))
            {
                Console.Clear();
                Console.WriteLine("Cliente inserido com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            InsertAddress();
            InsertCustomer();
        }
    }

    private static void UpdateCustomer()
    {
        Console.Clear();
        CustomerController customerController = new CustomerController();
        customerController.FindAll().ForEach(x => Console.WriteLine(x.ToStringCustomer()));

        Console.Write("Digite o valor do ID do cliente que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        if (customerController.FindAll().Exists(x => x.Id == id))
        {
            Console.Clear();
            Console.Write("Digite o novo nome do cliente: ");
            string? name = Console.ReadLine();
            Console.Write("Digite o novo número de telefone do cliente: ");
            string? phone = Console.ReadLine();
            Console.Write("Digite a nova data de registro do cliente: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());

            Customer customer = new Customer
            {
                CustomerName = name,
                Phone = phone,
                RegistrationDate = registrationDate
            };

            if (new CustomerController().Update(customer, id))
            {
                Console.Clear();
                Console.WriteLine("Cliente editado com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void DeleteCustomer()
    {
        Console.Clear();
        CustomerController customerController = new CustomerController();
        customerController.FindAll().ForEach(x => Console.WriteLine(x.ToStringCustomer()));

        Console.Write("Digite o valor do ID do cliente que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());
        if (customerController.FindAll().Exists(x => x.Id == id))
        {
            if (new CustomerController().Delete(id))
            {
                Console.Clear();
                Console.WriteLine("Cliente deletado com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void PrintCustomer()
    {
        do
        {
            Console.Clear();
            new CustomerController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCustomer()));
            Console.WriteLine("Aperte ENTER para retornar ao Menu de Impressão");
        } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    private static void InsertHotel()
    {
        Console.Clear();
        new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));
        Console.Write("O Hotel a ser cadastrado já possui um endereço cadastrado [S / N]: ");
        char choice = char.Parse(Console.ReadLine().ToUpper());

        if (choice.Equals('S'))
        {
            Console.Write("\n\n" + "Digite o nome do hotel: ");
            string? name = Console.ReadLine();
            Console.Write("Digite a data de registro do hotel: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o valor do hotel: ");
            decimal value = decimal.Parse(Console.ReadLine());
            Console.Write("Digite o número do ID do endereço: ");
            int id = int.Parse(Console.ReadLine());
            Hotel hotel = new Hotel
            {
                HotelName = name,
                RegistrationDate = registrationDate,
                HotelValue = value
            };

            if (new HotelController().Insert(hotel, id))
            {
                Console.Clear();
                Console.WriteLine("Hotel inserido com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            InsertAddress();
            InsertHotel();
        }
    }

    private static void UpdateHotel()
    {
        Console.Clear();
        HotelController hotelController = new HotelController();
        hotelController.FindAll().ForEach(x => Console.WriteLine(x.ToStringHotel()));

        Console.Write("Digite o valor do ID do cliente que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        if (hotelController.FindAll().Exists(x => x.Id == id))
        {
            Console.Clear();
            Console.Write("Digite o novo nome do hotel: ");
            string? name = Console.ReadLine();
            Console.Write("Digite a nova data de registro do hotel: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o novo valor do hotel: ");
            decimal value = decimal.Parse(Console.ReadLine());

            Hotel hotel = new Hotel
            {
                HotelName = name,
                RegistrationDate = registrationDate,
                HotelValue = value
            };

            if (new HotelController().Update(hotel, id))
            {
                Console.Clear();
                Console.WriteLine("Hotel editado com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void DeleteHotel()
    {
        Console.Clear();
        HotelController hotelController = new HotelController();
        hotelController.FindAll().ForEach(x => Console.WriteLine(x.ToStringHotel()));

        Console.Write("Digite o valor do ID do hotel que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());
        if (hotelController.FindAll().Exists(x => x.Id == id))
        {
            if (new HotelController().Delete(id))
            {
                Console.Clear();
                Console.WriteLine("Hotel deletado com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void PrintHotel()
    {
        do
        {
            Console.Clear();
            new HotelController().FindAll().ForEach(x => Console.WriteLine(x.ToStringHotel()));
            Console.WriteLine("Aperte ENTER para retornar ao Menu de Impressão");
        } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    private static void InsertTicket()
    {
        Console.Clear();
        new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));
        Console.Write("A passagem a ser cadastrada já possui os endereços de origem e destino cadastrados [S / N]: ");
        char choice = char.Parse(Console.ReadLine().ToUpper());

        if (choice.Equals('N'))
        {
            InsertAddress();
            InsertTicket();
        }

        Console.Clear();
        new CustomerController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCustomer()));
        Console.Write("A passagem a ser cadastrada já possui cliente cadastrados [S / N]: ");
        char choice2 = char.Parse(Console.ReadLine().ToUpper());

        if (choice2.Equals('N'))
        {
            InsertCustomer();
            InsertTicket();
        }

        if (choice.Equals('S') && choice2.Equals('S'))
        {
            Console.Write("\n\n" + "Digite a data da passagem: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o valor da passagem: ");
            decimal ticketValue = decimal.Parse(Console.ReadLine());

            Console.Clear();
            new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));
            Console.Write("Digite o número do ID de origem do endereço: ");
            int idOrigin = int.Parse(Console.ReadLine());

            Console.Clear();
            new AddressController().FindAll().ForEach(x => Console.WriteLine(x.ToStringAddress()));
            Console.Write("Digite o número do ID de destino do endereço: ");
            int idDestination = int.Parse(Console.ReadLine());

            Console.Clear();
            new CustomerController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCustomer()));
            Console.Write("Digite o número do ID do cliente: ");
            int idCustomer = int.Parse(Console.ReadLine());
            Ticket ticket = new Ticket
            {
                Date = date,
                TicketValue = ticketValue
            };

            if (new TicketController().Insert(ticket, idOrigin, idDestination, idCustomer))
            {
                Console.Clear();
                Console.WriteLine("Passagem inserida com sucesso!");
                Thread.Sleep(3000);
            }
        }
    }

    private static void UpdateTicket()
    {
        Console.Clear();
        TicketController ticketController = new TicketController();
        ticketController.FindAll().ForEach(x => Console.WriteLine(x.ToStringTicket()));

        Console.Write("Digite o valor do ID do cliente que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        if (ticketController.FindAll().Exists(x => x.Id == id))
        {
            Console.Clear();
            Console.Write("Digite a nova data de registro da passagem: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o novo valor da passagem: ");
            decimal ticketValue = decimal.Parse(Console.ReadLine());

            Ticket ticket = new Ticket
            {
                Date = date,
                TicketValue = ticketValue
            };

            if (new TicketController().Update(ticket, id))
            {
                Console.Clear();
                Console.WriteLine("Passagem editada com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void DeleteTicket()
    {
        Console.Clear();
        TicketController ticketController = new TicketController();
        ticketController.FindAll().ForEach(x => Console.WriteLine(x.ToStringTicket()));

        Console.Write("Digite o valor do ID da passagem que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());
        if (ticketController.FindAll().Exists(x => x.Id == id))
        {
            if (new TicketController().Delete(id))
            {
                Console.Clear();
                Console.WriteLine("Passagem deletada com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void PrintTicket()
    {
        do
        {
            Console.Clear();
            new TicketController().FindAll().ForEach(x => Console.WriteLine(x.ToStringTicket()));
            Console.WriteLine("Aperte ENTER para retornar ao Menu de Impressão");
        } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }

    private static void InsertPackage()
    {
        Console.Clear();
        new HotelController().FindAll().ForEach(x => Console.WriteLine(x.ToStringHotel()));
        Console.Write("O pacote a ser cadastrado já possui o hotel cadastrado [S / N]: ");
        char choice = char.Parse(Console.ReadLine().ToUpper());

        if (choice.Equals('N'))
        {
            InsertHotel();
            InsertPackage();
        }

        Console.Clear();
        new TicketController().FindAll().ForEach(x => Console.WriteLine(x.ToStringTicket()));
        Console.Write("O pacote a ser cadastrado já possui a passagem cadastrada [S / N]: ");
        char choice2 = char.Parse(Console.ReadLine().ToUpper());

        if (choice2.Equals('N'))
        {
            InsertTicket();
            InsertPackage();
        }

        Console.Clear();
        new CustomerController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCustomer()));
        Console.Write("O pacote a ser cadastrado já possui o cliente cadastrado [S / N]: ");
        char choice3 = char.Parse(Console.ReadLine().ToUpper());

        if (choice3.Equals('N'))
        {
            InsertCustomer();
            InsertPackage();
        }

        if (choice.Equals('S') && choice2.Equals('S') && choice3.Equals('S'))
        {
            Console.Clear();
            new HotelController().FindAll().ForEach(x => Console.WriteLine(x.ToStringHotel()));
            Console.Write("Digite o número do ID do hotel: ");
            int idHotel = int.Parse(Console.ReadLine());

            Console.Clear();
            new TicketController().FindAll().ForEach(x => Console.WriteLine(x.ToStringTicket()));
            Console.Write("Digite o número do ID da passagem: ");
            int idTicket = int.Parse(Console.ReadLine());

            Console.Clear();
            new CustomerController().FindAll().ForEach(x => Console.WriteLine(x.ToStringCustomer()));
            Console.Write("Digite o número do ID do cliente: ");
            int idCustomer = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.Write("Digite a data de registro do pacote: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o valor do pacote: ");
            decimal packageValue = decimal.Parse(Console.ReadLine());

            Package package = new Package
            {
                RegistrationDate = registrationDate,
                PackageValue = packageValue
            };

            if (new PackageController().Insert(package, idHotel, idTicket, idCustomer))
            {
                Console.Clear();
                Console.WriteLine("Pacote inserido com sucesso!");
                Thread.Sleep(3000);
            }
        }
    }

    private static void UpdatePackage()
    {
        Console.Clear();
        PackageController packageController = new PackageController();
        packageController.FindAll().ForEach(x => Console.WriteLine(x.ToStringPackage()));

        Console.Write("Digite o valor do ID do pacote que deseja editar: ");
        int id = int.Parse(Console.ReadLine());
        if (packageController.FindAll().Exists(x => x.Id == id))
        {
            Console.Clear();
            Console.Write("Digite a nova data de registro do pacote: ");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Digite o novo valor do pacote: ");
            decimal packageValue = decimal.Parse(Console.ReadLine());

            Package package = new Package
            {
                RegistrationDate = registrationDate,
                PackageValue = packageValue
            };

            if (new PackageController().Update(package, id))
            {
                Console.Clear();
                Console.WriteLine("Pacote editado com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void DeletePackage()
    {
        Console.Clear();
        PackageController packageController = new PackageController();
        packageController.FindAll().ForEach(x => Console.WriteLine(x.ToStringPackage()));

        Console.Write("Digite o valor do ID do pacote que deseja deletar: ");
        int id = int.Parse(Console.ReadLine());
        if (packageController.FindAll().Exists(x => x.Id == id))
        {
            if (new PackageController().Delete(id))
            {
                Console.Clear();
                Console.WriteLine("Pacote deletado com sucesso!");
                Thread.Sleep(3000);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("O ID informado não existe");
            Thread.Sleep(3000);
        }
    }

    private static void PrintPackage()
    {
        do
        {
            Console.Clear();
            new PackageController().FindAll().ForEach(x => Console.WriteLine(x.ToStringPackage()));
            Console.WriteLine("Aperte ENTER para retornar ao Menu de Impressão");
        } while (Console.ReadKey().Key != ConsoleKey.Enter);
    }
}