namespace D4SankeAndLadder
{
    internal class Program
    {
        private static object SnakeLadder;

        public static object Players { get; private set; }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome! to Snake and Ladder Game");
            int position = 0;       //Position Initializing
            Console.WriteLine("The position of player starts: " + position);
            //Accessing StartGame method from SnakeLadder Class
            SnakeLadder.StartGame();
            Players.players();

        }     
        
    }
}