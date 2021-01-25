using System;

namespace Method_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask about a players Name and some key stats
            Console.WriteLine("Hello, what player would we like to look into today?");
            var name = Console.ReadLine();
            Console.WriteLine("Awesome, " + name + " is a great player! Lets start with their points. What do they score a game?");
            var ppg = Console.ReadLine();
            Console.WriteLine("Impressive! Now how is " + name + " on the glass?");
            var totreb = Console.ReadLine();
            Console.WriteLine("How many Offensive rebounds? And Defensive?");
            var oreb = Console.ReadLine();
            var dreb = Console.ReadLine();
            Console.WriteLine("Do they often set up teammates for success with their passing? How many assists do they average?");
            var answer = Console.ReadLine();
            var assists = Console.ReadLine();
            Console.WriteLine("Now that we can see some raw stats, lets look more in depth. Does this player play 'winning' basketball? What is their PER?");
            var playerPer = int.Parse(Console.ReadLine());

            if (playerPer >= 15)
            {
                Console.WriteLine("Yes! This player plays team basketball!");
            }
            else
            {
                Console.WriteLine("No, some of these numbers may be empty stats");
            }

            Console.WriteLine("So now we have gotten a good look at " + name + ". They average " + ppg + " points, " + totreb + " rebounds, and " + assists + " assists per game. Their per is " + playerPer + ".");
        }
    }
}
