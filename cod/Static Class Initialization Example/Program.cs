using System;

namespace cod
{
    class GameSettings
    {
        public static string GameName;
        public static int MaxPlayers;
        public static float Version;

        static GameSettings()
        {
            GameName = "Ahil's Ascend";
            MaxPlayers = 4;
            Version = 1.0f;
        }
        public GameSettings()
        {
            System.Console.WriteLine("Обычный конструктор вызван");
        }
    }
    class Program
    {
        static void Main()
        {

            System.Console.WriteLine(GameSettings.GameName);
            var gamesettings = new GameSettings();






        }
    }
}