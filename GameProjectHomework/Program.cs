using System;

namespace GameProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);
            Gamer gamer = new Gamer();
            gamer.GamerName = "Dogus";
            gamer.GamerSurname = "Yasayan";
            gamer.DateOfYear = 1997;
            gamer.NationaltyIdentıty = 35719691652;
            gamerManager.Add(gamer);
        }
    }
}
