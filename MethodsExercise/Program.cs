using System;

namespace Method_Exercise
{
    class Program
    {
        //exercise 2
        public static int Plus(int x,int y)
        {
            var answer = x + y;
            return answer;
        }

        public static int Times(int x, int y)
        {
            var answer = x * y;
            return answer;
        }

        //use for a preset number of variables that CANNOT change

        //exercise params
        public static int Add(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;

            }
        public static int Multi(params int[] list)
        { 
            int times = 1;
            for (int t = 0; t < list.Length; t++)
            {
                times = times * list[t];
            }
                return times;
            
        }
        //use for an unknow number of variable, or for more variable than you want to type out a method for. 
        static void Main(string[] args)
        {
            //exercise 1

            var numberOfCars = Add(3, 9, 4, 7, 5, 3, 2, 1); //uses Method Add from parameters
            var numberOfSalesman = Multi(7, 4, 5, 2); //uses Method Multi from parameters
            var numberOfTeams = Plus(4, 3);// uses Method Plus from Methods
            var numberOfPlayers = Times(6, 6);//uses Method Times from Methods

            Console.WriteLine(numberOfCars);
            Console.WriteLine(numberOfSalesman);
            Console.WriteLine(numberOfTeams);
            Console.WriteLine(numberOfPlayers);
            // ask about a players Name and some key stats
            Console.WriteLine("Hello, what player would we like to look into today?");
            var name = Console.ReadLine();
            Console.WriteLine("Awesome, " + name + " is a great player! Lets start with their points. What do they score a game?");
            var ppg = Console.ReadLine();
            Console.WriteLine("Impressive! Now lets look at how " + name + " is on the glass. How many rebounds does he get each game?");
            var totreb = Console.ReadLine();
            Console.WriteLine("How many Offensive rebounds? And Defensive?");
            var oreb = Console.ReadLine();
            var dreb = Console.ReadLine();
            Console.WriteLine("Do they often set up teammates for success with their passing? How many assists do they average?");
            var answer = Console.ReadLine();
            var assists = Console.ReadLine();
            Console.WriteLine("Now that we can see some raw stats, lets look more in depth, to see the relevance of their numbers, and to see if this player is a team player. What is their PER?");
            var playerPer = int.Parse(Console.ReadLine());

            if (playerPer >= 15)
            {
                Console.WriteLine("Yes! This player plays team basketball!");
            }
            else if (playerPer >= 10)
            {
                Console.WriteLine("This player is ok, but needs to work on their team play to be more efficient. Some of their stas are inflatd.");
            }
            else
            {
                Console.WriteLine("No, most of these numbers may be empty stats");
            }

            Console.WriteLine("So now we have gotten a good look at " + name + ". They average " + ppg + " points, " + totreb + " rebounds, and " + assists + " assists per game. Their per is " + playerPer + ".");
        }
    }
}
