using Backend;
using System.ComponentModel.Design;

var lists  = new SinglyLinkedLists<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option) 
    {
        case "1":
            Console.Write("Enter value: ");
            lists.InsertAtBeginning(Console.ReadLine()!);
            break;
        case "2":
            Console.Write("Enter value: ");
            lists.InsertAtEnd(Console.ReadLine()!);
            break;
        case "3":
            Console.WriteLine(lists);
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Insert at beginning.");
    Console.WriteLine("2. Insert end.");
    Console.WriteLine("3. Contains.");
    Console.WriteLine("4. Remove.");
    Console.WriteLine("5. Reverse.");
    Console.WriteLine("6. Show lists.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your option? ");
    return Console.ReadLine()!;
}