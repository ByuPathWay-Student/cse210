// I added saving and loading messages, that let the player know the whether the game was saved or loaded.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager currentGame = new GoalManager();
        currentGame.Start();
    }
}