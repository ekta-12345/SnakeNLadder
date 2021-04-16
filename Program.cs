using System;

namespace SnakeAndLadderAssignment
{
    class SnakeAndLadder
    {
        int START_POSITION = 0; // Declare integer start position in 0
        public void PlayGame()
        {
            Random random = new Random();
            int Die = random.Next(1, 6);    //Random Value Generate 1 to 6
            Console.WriteLine(" Player Die Roll Position :-" + Die);        //Print Random value
            Console.WriteLine(" Single Player Start_Position:- " + START_POSITION); //Print Start Position
            Console.ReadLine();
        }
        static void Main(string[] args)//Main method
        {
            SnakeAndLadder StartPlay = new SnakeAndLadder(); // Calling Method
            StartPlay.PlayGame();//method PlaGame

        }
    }
}
