namespace Assignment1_Task3_Console
{
    internal interface IGame
    {
        bool GameWon { get; set; }
        string PlayGame(int input);
    }
}