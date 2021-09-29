using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerValidater gamerValidater = new GamerValidater();
            GamerManager gamerManager = new GamerManager(gamerValidater);
            gamerManager.Add(
                new Gamer
                {
                    Id = 123456,

                    FirstName = "Murat",
                    LastName = "Can",
                    BirthYear = 1996




                });
            

            GameEventManager gameEventManager = new GameEventManager();
            gameEventManager.Discount(gameEventManager);

            GameManager gameManager = new GameManager();
            gameManager.AddCart(gameManager);
            gameManager.Buy(gameManager);





        }

    }
}

