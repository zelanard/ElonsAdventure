using System;

namespace ElonsAdventure.View
{
    /// <summary>
    /// <c>CarView</c> models the interface which displays information to the console.
    /// </summary>
    public class CarView
    {
        /// <summary>
        /// Write message to the console.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="carColor"></param>
        public void CarToConsole(string output, ConsoleColor carColor)
        {
            Console.ForegroundColor = carColor;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Prompt the user for a colour.
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetCarColour()
        {
            Console.WriteLine("Which colour is your car, red green or blue?");
            switch (Console.ReadLine().ToUpper())
            {
                case "RED":
                    {
                        return ConsoleColor.Red;
                    }
                case "GREEN":
                    {
                        return ConsoleColor.Green;
                    }
                case "BLUE":
                    {
                        return ConsoleColor.Blue;
                    }
                default:
                    {
                        return ConsoleColor.Red;
                    }
            }
        }
        /// <summary>
        /// Prompt the user for a distance in clicks. (1 click = 20 km)
        /// </summary>
        /// <returns></returns>
        public int GetDistance()
        {
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// prompt user for yes or no.
        /// </summary>
        /// <returns>true/false</returns>
        public bool YesNo()
        {
            while (true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Y)
                {
                    Console.WriteLine();
                    return true;
                }
                else if (key == ConsoleKey.N)
                {
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    continue;
                }
            }
        }
        /// <summary>
        /// reset the console
        /// </summary>
        internal void Reset()
        {
            Console.Clear();
        }
    }
}
