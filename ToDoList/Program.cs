using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static string UserInput(string response)
    {
      if (response == "a")
      {
        Console.Write("Enter your item:");
        string res = Console.ReadLine();

        Item thisItem = new Item(res);

        Console.Write("[V]iew, [A]dd, or [Q]uit:");
        response = Console.ReadLine().ToLower();

      }
      else if (response == "v")
      {

        List<Item> tempItem = Item.GetAll();
        foreach (Item item in tempItem)
        {
          Console.WriteLine(item.Description);
        }

        Console.Write("[V]iew, [A]dd, or [Q]uit:");
        response = Console.ReadLine().ToLower();
      }

      return response;

    }
    public static void Main()
    {
      Console.WriteLine("Hi, welcome to your to do list");


      Console.Write(@"Would you like to [V]iew or [A]dd to your list? -- ");

      string response = Console.ReadLine().ToLower();

      Console.WriteLine(response);

      while (response != "a" && response != "v")
      {
        Console.WriteLine("Sorry, I didn't catch that!");
        Console.WriteLine("Please type 'a' to add or 'v' to view");
        Console.Write("Would you like to [V]iew or [A]dd to your list? -- ");
        response = Console.ReadLine().ToLower();
      }
      while (response != "q")
      {
        response = UserInput(response);
      }

      Console.WriteLine("Bye!");


    }
  }
}