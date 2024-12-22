using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TrainReservationApp;
using TrainReservationApp.Interface;

namespace TrainReservationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AdminMenu();
                        break;
                    case "2":
                        UserMenu();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
        static void AdminMenu()
        {
            bool adminExit = false;
            while (!adminExit)
            {
                ITrainRepository trainRepository = new TrainRepository();

                Console.WriteLine("\n--- Admin Menu ---");
                Console.WriteLine("1. Add Trains");
                Console.WriteLine("2. Modify Trains");
                Console.WriteLine("3. Delete Trains (soft delete)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        trainRepository.AddTrain();
                        break;
                    case "2":
                        trainRepository.ModifyTrain();
                        break;
                    case "3":
                        trainRepository.DeleteTrain();
                        break;
                    case "4":
                        adminExit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
        static void UserMenu()
        {
            bool userExit = false;
            while (!userExit)
            {
                ITrainRepository trainRepository = new TrainRepository();

                Console.WriteLine("\n--- User Menu ---");
                Console.WriteLine("1. Book Tickets");
                Console.WriteLine("2. Cancel Tickets");
                Console.WriteLine("3. Show All Trains");
                Console.WriteLine("4. Show Booking/Cancellation");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        trainRepository.BookTicket();
                        break;
                    case "2":
                        trainRepository.CancelTicket();
                        break;
                    case "3":
                        trainRepository.ShowAllTrains();
                        break;
                    case "4":
                        trainRepository.ShowBookings();
                        break;
                    case "5":
                        userExit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}
