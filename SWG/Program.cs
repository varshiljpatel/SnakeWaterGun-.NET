namespace SWG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Snake, Water and Gun...");
            string? userInput = "";
            Console.WriteLine("Selection :\n- s for snake\n- w for water \n- g for gun");
            do
            {
                Console.Write("type your selection : ");
                userInput = Console.ReadLine().ToLower().ToString();
                Random compNum = new Random();
                int selectionFrom = compNum.Next(1, 4);

                // define a mapping for computer
                Dictionary<int, string> map = new Dictionary<int, string>();
                map.Add(1, "s");
                map.Add(2, "w");
                map.Add(3, "g");
                string compSelect = map[selectionFrom];

                Console.WriteLine("\nYour selection is : " + userInput + "\nComputer selection is " + compSelect);
                if (userInput == "s" && compSelect == "w" ||
                    userInput == "w" && compSelect == "g" ||
                    userInput == "g" && compSelect == "s"
                    )
                {
                    Console.WriteLine("\n--- Your are winner! ---");
                }
                else if (userInput == "s" && compSelect == "g" ||
                    userInput == "w" && compSelect == "s" ||
                    userInput == "g" && compSelect == "w"
                    )
                {
                    Console.WriteLine("\n---  You are lose! ---");
                }
                else if (userInput != "s" || userInput != "w" || userInput != "g" || userInput != "exit")
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Selection :\n- s for snake\n- w for water \n- g for gun");
                }
                else
                {
                    Console.WriteLine("\n--- Game is Die ---");
                }
                Console.WriteLine();
                Console.WriteLine("Type exit for quit\n\n");
            } while (userInput != "exit");
            Console.ReadLine();
        }
    }
}