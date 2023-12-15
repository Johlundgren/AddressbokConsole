using AddressbokConsole.Interfaces;
using AddressbokConsole.Models;

namespace AddressbokConsole.Services;

internal class MenuService
{
    private static readonly IContactService _contactService = new ContactService();

    public void ShowMainMenu()
    {
        while (true)
        {
            DisplayMenuTitle("MENU OPTIONS");
            Console.WriteLine($"{"1.",-4} Add New Contact");
            Console.WriteLine($"{"2.",-4} View Contact List");
            Console.WriteLine($"{"0.",-4} Exit Application");
            Console.WriteLine();
            Console.Write("Enter your Option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddContactOption();
                    break;

                case "2":
                    ShowAllContactsOption();
                    break;

                case "0":
                    ShowExitApplicationOption();
                    break;

                default:
                    Console.WriteLine("\nInvalid Option, press any key to try again.");
                    break;

            }
            Console.ReadKey();
        }
    }
    public static void AddContactOption()
    {
        IContact contact = new Contact();

        DisplayMenuTitle("Add New Customer");

        Console.Write("First name: ");
        contact.FirstName = Console.ReadLine()!;

        Console.Write("Last name: ");
        contact.LastName = Console.ReadLine()!;

        Console.Write("E-Mail: ");
        contact.Email = Console.ReadLine()!;

        Console.Write("Phone Number: ");
        contact.PhoneNumber = Console.ReadLine()!;

        Console.Write("Address: ");
        contact.Address = Console.ReadLine()!;
        Console.Write("Contact was added succesfully!");

        _contactService.AddContactToList(contact);
    }

    public static void ShowAllContactsOption()
    {
        var contacts = _contactService.GetContactsFromList();
        foreach (var contact in contacts)
        {
            if (contact is IContact c)
                Console.WriteLine($"{c.FirstName} {c.LastName} <{c.Email}> {c.PhoneNumber} {c.Address}");

        }
    }

    public static void ShowContactOption()
    {
        // ENSKILD ANVÄNDARE BY EMAIL
    }

    private static void ShowExitApplicationOption()
    {
        Console.Clear();
        Console.Write("Are you sure you want to EXIT this application? (y/n): ");
        var option = Console.ReadLine();

        if (option.Equals("y", StringComparison.OrdinalIgnoreCase))
        {
            Environment.Exit(0);
        }
    }

    private static void DisplayMenuTitle(string title)
    {
        Console.Clear();
        Console.WriteLine($"##### {title} #####");
        Console.WriteLine();
    }

    private static void DisplayPressAnyKey()
    {
        Console.WriteLine();
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}
