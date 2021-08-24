using System;
using System.Collections.Generic;
using System.Linq;
// using System.Text;
// using System.Net;


namespace DinnerParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guest> guests = GetGuests();

            Table firstTable = new Table("Table 1"); // instantiating new table class, passing table name as argument
            Table secondTable = new Table("Table 2"); // instantiating new table class, passing table name as argument

            foreach (Guest guest in guests)
            {
                // iterating through dinner guests in first table collection by guest occupation and storing in Table1Occupations variable:
                List<string> Table1Occupations = firstTable.GuestList.Select(guest => guest.Occupation).ToList();
                // if Table1Occupations variable already contains a similar guest occupation, then add the current guest in the loop to
                // the second table to prevent having guests of duplicate occupations in the same table
                if (Table1Occupations.Contains(guest.Occupation))
                {
                    secondTable.AddGuest(guest);
                }
                // otherwise, add that guest to the list for the first table:
                else
                {
                    firstTable.AddGuest(guest);
                }
            }

            Console.WriteLine(firstTable.Name);
            foreach (Guest guest in firstTable.GuestList)
            {
                //display guest details from GuestList property in first table instance of Table class:
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine(secondTable.Name);
            foreach (Guest guest in secondTable.GuestList)
            {
                //display guest details from GuestList property in second table instance of Table class:
                Console.WriteLine($"{guest.Name} ({guest.Occupation}) {guest.Bio}");
            }


            // A method to make and return list of guests:
            List<Guest> GetGuests()
            {
                //Make a list of guest objects:
                List<Guest> guests = new List<Guest>();

                guests.Add(new Guest(
                    "Marilyn Monroe",
                    "entertainer",
                    "(1926 - 1962) American actress, singer, model"
                ));
                guests.Add(new Guest(
                    "Abraham Lincoln",
                    "politician",
                    "(1809 - 1865) US President during American civil war"
                ));
                guests.Add(new Guest(
                    "Martin Luther King",
                    "activist",
                    "(1929 - 1968)  American civil rights campaigner"
                ));
                guests.Add(new Guest(
                    "Rosa Parks",
                    "activist",
                    "(1913 - 2005)  American civil rights activist"
                ));
                guests.Add(new Guest(
                    "Peter Sellers",
                    "entertainer",
                    "(1925 - 1980) British actor and comedian"
                ));
                guests.Add(new Guest(
                    "Alan Turing",
                    "computer scientist",
                    "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world"
                ));
                guests.Add(new Guest(
                    "Admiral Grace Hopper",
                    "computer scientist",
                    "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds"
                ));
                guests.Add(new Guest(
                    "Indira Gandhi",
                    "politician",
                    "(1917 - 1984) Prime Minister of India 1966 - 1977"
                ));

                return guests;
            }
        }


        // Classes are how objects are defined in C#. Classes help ensure that the objects always have the correct properties/methods.

        public class Table // table class
        {
            public string Name { get; set; }
            public List<Guest> GuestList { get; set; }

            public Table(string tableName) // constructor for Table class
            {
                Name = tableName;
                GuestList = new List<Guest>(); // initializing new instance of the List class of type Guest class
            }

            public void AddGuest(Guest guest) // method to add guest object to the Guestlist collection
            {
                GuestList.Add(guest);
            }
        }

        public class Guest // guest class
        {
            public string Name { get; set; }
            public string Occupation { get; set; }
            public string Bio { get; set; }

            public Guest(string guestName, string guestOccupation, string guestBio) // constructor for Guest class
            {
                Name = guestName;
                Occupation = guestOccupation;
                Bio = guestBio;
            }
        }
    }
}