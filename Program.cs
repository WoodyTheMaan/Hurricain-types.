namespace Hurricain_types_
{
    internal class Program
    {
        public static string hurricanSelected;
        static void Main(string[] args)
        {

            MainMenu();



        }
        public static void MainMenu()
        {


            Console.WriteLine("Please select a type of hurricane.");
            Console.WriteLine("");
            Console.WriteLine("Catagory one ----- 1");
            Console.WriteLine("Catagory two ----- 2");
            Console.WriteLine("Catagory three --- 3");
            Console.WriteLine("Catagory four ---- 4");
            Console.WriteLine("Catagory five ---- 5");
            hurricanSelected = Console.ReadLine();
            theHurricanes();
        }
        public static void theHurricanes()
        {


            switch (hurricanSelected)
            {
                default:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("ERROR try again!");
                    Console.ReadLine();
                    MainMenu();
                    break;
                case "1":

                    Console.WriteLine("You picked Catagory 1.");
                    Console.WriteLine("Category 1: 74-95 mph or 64-82 kt or 119-153 km/hr ");
                    Console.ReadLine();
                    break;
                case "2":

                    Console.WriteLine("You picked Catagory 2.");
                    Console.WriteLine("Category 2: 96-110 mph or 83-95 kt or 154-177 km/hr");
                    Console.ReadLine();
                    break;

                case "3":

                    Console.WriteLine("You picked Catagory 3.");
                    Console.WriteLine("Category 3: 111-130 mph or 96-113 kt or 178-209 km/hr");
                    Console.ReadLine();
                    break;

                case "4":

                    Console.WriteLine("You picked Catagory 4.");
                    Console.WriteLine("Category 4: 131-155 mph or 114-135 kt or 210-249 km/hr");
                    Console.ReadLine();
                    break;

                case "5":

                    Console.WriteLine("You picked Catagory 5.");
                    Console.WriteLine("Category 5: greater than 155 mph or 135 kt or 249 km/hr");
                    Console.ReadLine();
                    break;


            }
            string input;
            Console.WriteLine("Thanks! Click 1 to go back to menu and click 2 to leave");
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("You selected 1.");
                Thread.Sleep(700);

                MainMenu();
            }
           





        }
    }
    
}