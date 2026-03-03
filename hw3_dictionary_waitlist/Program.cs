using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;

Console.WriteLine("Welcome to the Enhanced Reservation System");

Dictionary<string, int> waitlist = new Dictionary<string, int>();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. add a person and party size");
    Console.WriteLine("3. remove a person by name");
    Console.WriteLine("Any other key to exit");
    Console.Write("Please choose: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Customer name to add:");
        string customerName = Console.ReadLine();

        if (waitlist.ContainsKey(customerName))
        {
            Console.WriteLine("Error: That name is already on the list.");
        }

        else
        {
            Console.Write("Enter party size:");
            if (int.TryParse(Console.ReadLine(), out int partySize))
            {
                waitlist.Add(customerName, partySize);
            }

            else
            {
                Console.WriteLine("Invalid party size.");
            }
        }
    }

    else if (choice == "3")
    {
        Console.Write("Customer name to remove:");
        string nameToRemove = Console.ReadLine();

        if (waitlist.Remove(nameToRemove))
        {
            Console.WriteLine($"{nameToRemove} has been removed.");
        }
        else
        {
            Console.WriteLine("Name not found.");
        }
    }

    else
    {
        Console.WriteLine("Invalid choice. Exit.");
        break;
    }

    Console.WriteLine();
    Console.WriteLine("The updated waitlist:");
    foreach (KeyValuePair<string, int> entry in waitlist)
    {
        Console.WriteLine($"Customer: {entry.Key} | Party Size: {entry.Value}");
    }
}  


