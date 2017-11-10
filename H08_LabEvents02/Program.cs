using System;

namespace H08_LabEvents02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A Player has a Name property 
             * A Player has a a Play method 
             * that returns a random int between 1 and 6.
             * 
             * A Game has a Player1 and a Player2 properties 
             * that should be set during the making of a new Game.
             * A Game has a Start method.
             * The Start method invokes the Play of Player1, 
             * then the Play of Player2,
             * then compares the two results and returns the player that won.
             * 
             * The Main creates 2 Players
             * The Main creates a Game with the two players
             * The Main invokes the Start method
             * 
             * The User Interface should be updated every time a player plays.
             * 
             * In order to do that, implement an Event in the Player class
             * that is raised everytime the Player plays,
             * then update the UI in a listener contained in the Program.
             */


            Player p1 = new Player();
            IPlayer p2 = new Player();

            ((IPlayer)p1).Play();

            Game g = new Game(p1, p2);

        }
    }
}
