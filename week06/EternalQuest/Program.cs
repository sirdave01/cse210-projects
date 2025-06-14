using System;

//decalring the namespace EternalQuest
namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the EternalQuest Project.\n");

            //runing the GoalManger class to manage the goals in the game
            GoalManager goalManager = new GoalManager();
            goalManager.Run();
        }
    }
}