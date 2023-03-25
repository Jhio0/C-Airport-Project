using MauiApp1.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Windows.System;

namespace MauiApp1.Data
{
    public class ReservationManager : Reservation
    {
        public static List<ReservationManager> reservationList = new List<ReservationManager>();

        public static string xmlFile = "C:\\Users\\soria\\OneDrive\\Documents\\OOP2\\main airport\\MauiApp1\\MauiApp1\\bin\\Reservations.xml";
        public static string GenerateRandomReservationCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string chars1 = "0123456789";
            var random = new Random();
            int index = random.Next(chars.Length);
            var a = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                int index1 = random.Next(chars1.Length);
                a.Append(chars1[index1]);
            }
            return chars[index] + a.ToString();
        }

        public ReservationManager() { }

        public static List<ReservationManager> GetReservations()
        {
            return reservationList;
        }

        public static void WriteReservationsToXmlFile()
        {
            var serializedReservations = new XmlSerializer(typeof(ReservationManager));
            using (var writer = new StreamWriter(xmlFile))
            {
                foreach (ReservationManager res in reservationList)
                {
                    serializedReservations.Serialize(writer, res);
                }
                writer.Close();
            }
        }

        public static void DeserializeXmlFile()
        {
            XmlSerializer DeserializeReservation = new XmlSerializer(typeof(ReservationManager));
            ReservationManager reservation;
            using (FileStream fs = new FileStream(xmlFile, FileMode.Open))
            {
                reservation = (ReservationManager)DeserializeReservation.Deserialize(fs);
                reservationList.Add(reservation);
            }
        }

        public ReservationManager(string res, string code, string airline, string cost, string name, string citizen, string status)
        {
            ReservationCode = res;
            FlightCode = code;
            Airline = airline;
            Cost = cost;
            Name = name;
            Citizenship = citizen;
            Status = status;
        }

        public static List<ReservationManager> reservationpage = new List<ReservationManager>();
        public static List<ReservationManager> GetReservationsFromBinaryFile()
        {
            return reservationpage;
        }

        public static List<ReservationManager> reservationMatchingList = new List<ReservationManager>();

        public static List<ReservationManager> GetMatchingFlightsupdate()
        {
            return reservationMatchingList;
        }
    }
}
