using System;
using System.Collections.Generic;

class Program
{
    static List<User> users = new List<User>();
    static int nextId = 1;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Sistem de Gestionare Utilizatori ===");
            Console.WriteLine("1. Adaugă Utilizator");
            Console.WriteLine("2. Vizualizează Utilizatori");
            Console.WriteLine("3. Editează Utilizator");
            Console.WriteLine("4. Șterge Utilizator");
            Console.WriteLine("5. Ieșire");
            Console.Write("Alege o opțiune: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    ViewUsers();
                    break;
                case "3":
                    EditUser();
                    break;
                case "4":
                    DeleteUser();
                    break;
                case "5":
                    Console.WriteLine("La revedere!");
                    return;
                default:
                    Console.WriteLine("Opțiune invalidă. Apasă Enter pentru a continua.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static void AddUser()
    {
        Console.Clear();
        Console.WriteLine("=== Adaugă Utilizator ===");

        Console.Write("Nume: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        users.Add(new User { Id = nextId++, Name = name, Email = email });

        Console.WriteLine("Utilizator adăugat cu succes! Apasă Enter pentru a continua.");
        Console.ReadLine();
    }

    static void ViewUsers()
    {
        Console.Clear();
        Console.WriteLine("=== Lista Utilizatori ===");

        if (users.Count == 0)
        {
            Console.WriteLine("Nu există utilizatori înregistrați.");
        }
        else
        {
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }

        Console.WriteLine("\nApasă Enter pentru a continua.");
        Console.ReadLine();
    }

    static void EditUser()
    {
        Console.Clear();
        Console.WriteLine("=== Editează Utilizator ===");

        Console.Write("ID-ul utilizatorului de editat: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var user = users.Find(u => u.Id == id);

            if (user != null)
            {
                Console.Write("Nume nou (lasă gol pentru a păstra același nume): ");
                string name = Console.ReadLine();
                if (!string.IsNullOrEmpty(name)) user.Name = name;

                Console.Write("Email nou (lasă gol pentru a păstra același email): ");
                string email = Console.ReadLine();
                if (!string.IsNullOrEmpty(email)) user.Email = email;

                Console.WriteLine("Utilizator actualizat cu succes!");
            }
            else
            {
                Console.WriteLine("Utilizatorul nu a fost găsit.");
            }
        }
        else
        {
            Console.WriteLine("ID invalid.");
        }

        Console.WriteLine("Apasă Enter pentru a continua.");
        Console.ReadLine();
    }

    static void DeleteUser()
    {
        Console.Clear();
        Console.WriteLine("=== Șterge Utilizator ===");

        Console.Write("ID-ul utilizatorului de șters: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var user = users.Find(u => u.Id == id);

            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("Utilizator șters cu succes!");
            }
            else
            {
                Console.WriteLine("Utilizatorul nu a fost găsit.");
            }
        }
        else
        {
            Console.WriteLine("ID invalid.");
        }

        Console.WriteLine("Apasă Enter pentru a continua.");
        Console.ReadLine();
    }
}
