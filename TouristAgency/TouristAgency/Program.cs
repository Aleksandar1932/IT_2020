using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    class Reservation
    {
        string fistname;
        string lastname;
        Int32 age;
        string destination;
        DateTime timestamp;
        Int32 price;
        public Reservation(string fistname, string lastname, int age, string destination, DateTime timestamp, Int32 price)
        {
            this.fistname = fistname;
            this.lastname = lastname;
            this.age = age;
            this.destination = destination;
            this.timestamp = timestamp;
            this.price = price;
        }

        public DateTime getTimestamp()
        {
            return  this.timestamp;
        }

        public Int32 getPrice()
        {
            return this.price;
        }

        public override string ToString()
        {
            return string.Format("{0}", "A");
        }
    }
    class Program
    {
       public static List<string> citiesList = new List<string> { "Rim", "London", "Tokio", "Sofija", "Istanbul", "Toronto", "Majami", "Zagreb", "Belgrad", "Moskva" }; // lista na gradovi

        static void Main(string[] args)
        {
            Int32 countersNumber = Int32.Parse(Console.ReadLine()); // broj na salteri;

            Dictionary<Int32, List<Reservation>> reservations = new Dictionary<int, List<Reservation>>();

            //inicijalizacija na recnik
            for (int i = 0; i < countersNumber; i++)
            {
                reservations.Add(i, new List<Reservation>());
            }

            while (true)
            {
                displayMenu();
                makeChoice(reservations);
            }
      
        }

        public static void displayMenu()
        {
            Console.WriteLine("--- Turisticka Agencija World ---");
            Console.WriteLine("1. Usluzi klient");
            Console.WriteLine("2. Prikaz na prodadeni karti na salter");
            Console.WriteLine("3. Vkupen promet na salter");
            Console.WriteLine("4. Prodazbi na site salteri");
            Console.WriteLine("5. Vkupen promet na agencijata");
            Console.WriteLine("6. Uspesnost na agencijata");
            Console.WriteLine("7. Izlez od aplikacijata");
        }

        public static void serveClient(Dictionary<Int32, List<Reservation>> reservations)
        {
            Console.WriteLine("Salter: ");
            Int32 counter = Int32.Parse(Console.ReadLine());

            if (counter >= reservations.Keys.Count)
            {
                //invalid key;
                Console.WriteLine("Invalid Counter number exception!");
                return;
            }

            Console.WriteLine("Ime: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Prezime: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Godini: ");
            Int32 age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Destinacija: ");
            string destination = Console.ReadLine();

            if (!citiesList.Contains(destination))
            {
                //invalid destination
                Console.WriteLine("Invalid Counter number exception!");
                return;
            }


            Int32 price = destination.Length * 2000;

            Reservation newReservation = new Reservation(firstname, lastname, age, destination, DateTime.Now, price);

            reservations[counter].Add(newReservation);

        }

        public static void makeChoice(Dictionary<Int32, List<Reservation>> reservations)
        {
            Console.WriteLine("Odberete opcija: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                serveClient(reservations);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Prikaz na prodadeni karti na daden salter vo vremenski interval:");
                Console.WriteLine("Salter broj:");
                Int32 counter = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vreme od:");
                DateTime timeFrom = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Vreme do:");
                DateTime timeTo = DateTime.Parse(Console.ReadLine());

                salesPerCounterInInterval(reservations, counter, timeFrom, timeTo);

            }
            else if (choice == "3")
            {
                Console.WriteLine("Vkupen promet na salterot vo vremenski interval:");
                Console.WriteLine("Salter broj:");
                Int32 counter = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vreme od:");
                DateTime timeFrom = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Vreme do:");
                DateTime timeTo = DateTime.Parse(Console.ReadLine());

                profitPerCounterInInterval(reservations, counter, timeFrom, timeTo);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Prodazbi vo vremenski interval za site salteri:");
                
                Console.WriteLine("Vreme od:");
                DateTime timeFrom = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Vreme do:");
                DateTime timeTo = DateTime.Parse(Console.ReadLine());

                salesInInterval(reservations, timeFrom, timeTo);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Vkupen promet na agencijata:");
                totalProfit(reservations);
            }
            else if (choice == "6")
            {
                Console.WriteLine("Uspesnost na angecijata:");
                agencySuccess(reservations);
            }
            else if (choice == "7")
            {
                Environment.Exit(0);
            }
        }

        private static void agencySuccess(Dictionary<int, List<Reservation>> reservations)
        {
            Int32 numberOfAllReservations = reservations
               .Values.SelectMany(x => x)
               .ToList()
               .Count();

            for (int i = 0; i < reservations.Keys.Count; i++)
            {
                Console.WriteLine("Success on counter: {0} = {1} / {2}", i, reservations[i].Count(), numberOfAllReservations);
                
            }
        }

        private static void totalProfit(Dictionary<int, List<Reservation>> reservations)
        {
            Int32 totalProfit = 0;

            List<Reservation> allReservations = reservations
                .Values.SelectMany(x => x)
                .ToList(); //flat map na site rezervacii od site salteri vo edna lista;

            foreach(Reservation reservation in allReservations)
            {
                totalProfit += reservation.getPrice();
            }

            Console.WriteLine("Total Profit of the agency is: {0}", totalProfit);
        }

        private static void salesInInterval(Dictionary<int, List<Reservation>> reservations, DateTime timeFrom, DateTime timeTo)
        {
            for(int i = 0; i < reservations.Keys.Count; i++)
            {
                Console.WriteLine("Sales on counter: {0}", i);
                foreach(Reservation reservation in reservations[i])
                {
                    if (reservation.getTimestamp() >= timeFrom && reservation.getTimestamp() <= timeTo)
                    {
                        Console.WriteLine(reservation.ToString());
                    }
                }
            }
        }

        private static void profitPerCounterInInterval(Dictionary<int, List<Reservation>> reservations, int counter, DateTime timeFrom, DateTime timeTo)
        {
            List<Reservation> reservationsOnCounter = reservations[counter];
            Int32 totalProfit = 0;
            foreach (Reservation reservation in reservationsOnCounter)
            {
                if (reservation.getTimestamp() >= timeFrom && reservation.getTimestamp() <= timeTo)
                {
                    totalProfit += reservation.getPrice();
                }
            }

            Console.WriteLine("Total Profit from {0} to {1} on counter {2}, is {3} MKD",timeFrom, timeTo, counter, totalProfit);
        }

        private static void salesPerCounterInInterval(Dictionary<int, List<Reservation>> reservations, int counter, DateTime timeFrom, DateTime timeTo)
        {
            List<Reservation> reservationsOnCounter = reservations[counter];

            foreach (Reservation reservation in reservationsOnCounter)
            {
                if(reservation.getTimestamp() >= timeFrom && reservation.getTimestamp() <= timeTo)
                {
                    Console.WriteLine(reservation.ToString());
                }
            }
        }
    }
}
