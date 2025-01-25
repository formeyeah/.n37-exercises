

using System;
using static Program;

class Program
{
    public struct Person
    {
        public string Name;
        public string Number;
        public Person(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }

    public static List<Person> people = new List<Person>();

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine(" ------------- 118 Menu -------------------");
        Console.WriteLine(" 1- Add");
        Console.WriteLine(" 2- Edit");
        Console.WriteLine(" 3- Search");
        Console.WriteLine(" 4- Delete");
        Console.WriteLine(" 5- List");
        Console.WriteLine(" 6- Exit");
        Console.Write(" choose an Option: ");
    }

    public static void AddPerson()
    {
        Console.Clear();
        Console.Write("Give me a name: ");
        string name = Console.ReadLine();
        Console.Write("Give me a number: ");
        string number = Console.ReadLine();
        people.Add(new Person(name, number));
    }

    public static void ShowPersonList()
    {
        foreach (Person person in people)
        {
            Console.WriteLine($"{people.IndexOf(person) + 1} - {person.Name} : {person.Number}");
        }
        Console.ReadKey();
    }

    public static void SearchPerson()
    {
        Console.Clear();
        Console.Write("Give me a name: ");
        string name = Console.ReadLine();
        bool found = false;
        foreach (Person person in people)
        {
            if (person.Name == name)
            {
                Console.WriteLine($"{people.IndexOf(person) + 1} - {person.Name} : {person.Number}");
                found = true;
            }

        }
        if (!found)
        {
            Console.WriteLine("Name Not Found!");
        }

        Console.ReadKey();

    }


    public static void EditPerson()
    {
        Console.Clear();
        Console.Write("Give me a name: ");
        string name = Console.ReadLine();
        bool found = false;
        int editedNodeNumber = 0;
        foreach (Person person in people)
        {
            if (person.Name == name)
            {
                editedNodeNumber = people.IndexOf(person);
                found = true;
            }

        }

        if (!found)
        {
            Console.WriteLine("Name Not Found!");
        }
        else
        {
            Console.Write("Give me a new name: ");
            string newName = Console.ReadLine();
            Console.Write("Give me a new number: ");
            string newNumber = Console.ReadLine();
            people[editedNodeNumber] = new Person(newName, newNumber);
            Console.WriteLine("Person Edited Successfully!");
        }

        Console.ReadKey();
    }

    public static void DeletePerson()
    {
        Console.Clear();
        Console.Write("Give me a name: ");
        string name = Console.ReadLine();
        bool found = false;
        int deletedNodeNumber = 0;
        foreach (Person person in people)
        {
            if (person.Name == name)
            {
                deletedNodeNumber = people.IndexOf(person);
                found = true;
            }

        }

        if (!found)
        {
            Console.WriteLine("Name Not Found!");
        }
        else
        {
            Console.Write("Are you Sure?(y/n) ");
            string decision = Console.ReadLine();
            if (decision == "y")
            {
                people.Remove(people[deletedNodeNumber]);
                Console.WriteLine("Person Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Ok! You ignored!");

            }
        }

        Console.ReadKey();
    }


    static void Main()
    {
        int SelectedOperation = 0;
        do
        {
            ShowMenu();
            string input = Console.ReadLine();
            SelectedOperation = int.Parse(input);
            switch (SelectedOperation)
            {
                case 1:
                    AddPerson();
                    break;
                case 2:
                    EditPerson();
                    break;
                case 3:
                    SearchPerson();
                    break;
                case 4:
                    DeletePerson();
                    break;
                case 5:
                    ShowPersonList();
                    break;

            }

        } while (SelectedOperation != 6);

    }
}