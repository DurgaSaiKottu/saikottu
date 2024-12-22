using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TrainReservationApp.Interface;




namespace TrainReservationApp
{
    public class TrainRepository : ITrainRepository
    {
        static string connectionString = "Server =ICS-LT-D244D6FL;Database=SQL;Trusted_Connection=True; ";
        public void AddTrain()
        {
            try
            {
                Console.Write("Enter Train Number: ");
                int trainNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Train Name: ");
                string trainName = Console.ReadLine();

                Console.Write("Enter Total Berths: ");
                int totalBerths = int.Parse(Console.ReadLine());

                Console.Write("Enter Available Berths: ");
                int availableBerths = int.Parse(Console.ReadLine());

                Console.Write("Enter Class Type: ");
                string classType = Console.ReadLine();

                Console.Write("Enter Source: ");
                string source = Console.ReadLine();

                Console.Write("Enter Destination: ");
                string destination = Console.ReadLine();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_AddTrain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TrainNo", trainNumber);
                    cmd.Parameters.AddWithValue("@TrainName", trainName);
                    cmd.Parameters.AddWithValue("@TotalBerths", totalBerths);
                    cmd.Parameters.AddWithValue("@AvailbleBerths", availableBerths);
                    cmd.Parameters.AddWithValue("@ClassType", classType);
                    cmd.Parameters.AddWithValue("@Source", source);
                    cmd.Parameters.AddWithValue("@Destination", destination);
                    cmd.Parameters.AddWithValue("@IsActive", "1");

                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Train added successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ModifyTrain()
        {
            try
            {
                Console.Write("Enter Train Number to Modify: ");
                int trainNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter New Train Name: ");
                string trainName = Console.ReadLine();

                Console.Write("Enter New Total Berths: ");
                int totalBerths = int.Parse(Console.ReadLine());

                Console.Write("Enter New Available Berths: ");
                int availableBerths = int.Parse(Console.ReadLine());

                Console.Write("Enter New Class Type: ");
                string classType = Console.ReadLine();

                Console.Write("Enter New Source: ");
                string source = Console.ReadLine();

                Console.Write("Enter New Destination: ");
                string destination = Console.ReadLine();

                Console.Write("Is Active (1 for active, 0 for inactive): ");
                bool isActive = Console.ReadLine() == "1";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ModifyTrain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);
                    cmd.Parameters.AddWithValue("@TrainName", trainName);
                    cmd.Parameters.AddWithValue("@TotalBerths", totalBerths);
                    cmd.Parameters.AddWithValue("@AvailbleBerths", availableBerths);
                    cmd.Parameters.AddWithValue("@ClassType", classType);
                    cmd.Parameters.AddWithValue("@Source", source);
                    cmd.Parameters.AddWithValue("@Destination", destination);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);

                    cmd.ExecuteNonQuery();
                }
                Console.WriteLine("Train modified successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteTrain()
        {
            try
            {
                Console.Write("Enter Train Number to Delete: ");
                int trainNumber = int.Parse(Console.ReadLine());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteTrain", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TrainNumber", trainNumber);

                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Train deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void BookTicket()
        {
            try
            {
                Console.Write("Enter Train Number to book: ");
                int trainNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter Passenger Name: ");
                string passengerName = Console.ReadLine();

                Console.Write("Enter the Number of Tickets: ");
                int TicketsBooked = int.Parse(Console.ReadLine());



                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_BookTicket", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TrainNo", trainNumber);
                    cmd.Parameters.AddWithValue("@PassengerName", passengerName);
                    cmd.Parameters.AddWithValue("@TicketsBooked", TicketsBooked);
                    cmd.Parameters.AddWithValue("@BookingStatus", "Booked");
                    cmd.Parameters.AddWithValue("@IsTicketBooked", "1");

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Ticket booked successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ShowAllTrains()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ShowAllTrains", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"TrainNo: {reader["TrainNo"]} | TrainName: {reader["TrainName"]} | From: {reader["Source"]} | To: {reader["Destination"]} | Available Seats: {reader["AvailbleBerths"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CancelTicket()
        {
            try
            {
                Console.Write("Enter BookingId to cancel: ");
                int bookingId = int.Parse(Console.ReadLine());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_CancelTicket", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookingId", bookingId);
                    cmd.Parameters.AddWithValue("@BookingStatus", "Cancelled");

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Ticket canceled successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ShowBookings()
        {
            try
            {
                Console.WriteLine("\n--- Bookings ---");
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_ShowBookings", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"BookingId: {reader["BookingId"]} | PassengerName: {reader["PassengerName"]} | Status: {reader["BookingStatus"]} | " +
                                           $"TicketBooked: {reader["IsTicketBooked"]} | Cancelled: {reader["IsTicketCancelled"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
