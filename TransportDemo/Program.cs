using TransportDemo.Model;

namespace TransportDemo;

class Program
{
    static void Main(string[] args)
    {
        TransportAgency agency = new TransportAgency();
        while (true)
        {
            Console.Write("Select travel mode:\n");
            Console.WriteLine("1.Car");
            Console.WriteLine("2.Train");
            Console.WriteLine("3.Plane");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                TransportModeType modeType = 0;
                switch(choice)
                {
                    case 1:
                        modeType = TransportModeType.Car;
                        break;
                    case 2:
                        modeType = TransportModeType.Train;
                        break;
                    case 3:
                        modeType = TransportModeType.Plane;
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                TransportMode mode = agency.CreateTransportMode(modeType);
                Console.Write("Enter travel distance (km): ");
                double travelDistance = double.TryParse(Console.ReadLine(), out double distance) ? distance : 0;
                Console.Write("Estimate travel time {0} hours " , mode.GetTravelTime(travelDistance));
                Console.WriteLine("Base fare: ${0}" , mode.CalculateBaseFare(travelDistance));
                Console.Write("\nDo you want to choose another transport mode? (y/n): ");
                string answer = Console.ReadLine() ?? string.Empty;
                if (!answer.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Bye Bye");
                    break;
                }
            }
        }
    }
}