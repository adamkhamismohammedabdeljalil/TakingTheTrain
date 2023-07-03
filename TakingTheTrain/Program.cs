namespace TakingTheTrain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create LinkedList and add stations
            LinkedList<string> stations = new LinkedList<string>();
            stations.AddLast("Milano Centrale FS");
            stations.AddLast("Loreto");
            stations.AddLast("Lambrate FS");
            stations.AddLast("Udine");
            //Choose 1 to add station or 2 to remove station.
            Console.WriteLine("Choose 1 to add station or 2 to remove station.");
            int choice= int.Parse(Console.ReadLine());
            //if user chosed 1, ask user about the station desdired to be added
            if (choice==1)
            {
                Console.WriteLine("insert the station you want to add :");
                string stationToAdd=Console.ReadLine();
                stations.AddLast(stationToAdd);
                Console.WriteLine($"station added : {stationToAdd}");

            }
            else if (choice==2)
            {
                Console.WriteLine("Choose the station you want to remove :");
                string stationToRemove=Console.ReadLine();  
                if (stationToRemove !=null && stations.Contains(stationToRemove))
                {
                    stations.Remove(stationToRemove);
                    Console.WriteLine($"station removed : {stationToRemove}");

                }
                else
                {
                    Console.WriteLine($"Station {stationToRemove} does not exists, choice an existing station.");
                }
            }
            else
            {
                Console.WriteLine($"Invalid choice :{choice}, Please insert a valid choice");
            }
            Console.WriteLine("Stations :");

            foreach (string station in stations) {
                Console.WriteLine(station);
            }
           
            
        }
    }
}