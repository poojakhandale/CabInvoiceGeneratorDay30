using CabInvoiceGenerator;


   
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator!");

            while (true)
            {
                Console.WriteLine("Please choose the option :\n1)Calculate Fare\n2)Aggregate Amount for Multiple Rides\n3)Enhanced Invoice");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Invoicegenerator uc1 = new Invoicegenerator();
                        double fare1 = uc1.CalculateFare(10, 30);
                        Console.WriteLine("Total Fare the your Journey is :" + fare1);
                        break;
                    case 2:
                        Invoicegenerator uc2 = new();
                        MultipleRide[] rides = { new MultipleRide(10, 20), new MultipleRide(15, 25) };
                        double totalfare = uc2.CalculateFare(rides);
                        Console.WriteLine("Aggregate value for Multiple rides is :" + totalfare);
                        break;
                    case 3:
                        Invoicegenerator uc3 = new();
                        MultipleRide[] rides1 = { new MultipleRide(10, 20), new MultipleRide(15, 25) };
                        double totalFare = uc3.CalculateFare(rides1);
                        double totalfare = uc3.CalculateFare(rides1);
                        int numOfRides = uc3.count;
                        double avg = totalFare / numOfRides;
                        Console.WriteLine("Total Number of rides : " + numOfRides);
                        Console.WriteLine("Aggregate fare Value for day is :" + totalFare);
                        Console.WriteLine("Average of all the rides :" + avg);
                        break;
                    default:
                        Console.WriteLine("Please choose the correct option!");
                        break;
                }
            }
        }
    }




