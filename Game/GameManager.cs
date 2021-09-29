using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager : IGameService
    {
        public void AddCart(GameManager gameManager)
        {
            Console.WriteLine("Sepete Eklendi");
           
        }


        public void Buy(GameManager gameManager)
        {
            Console.WriteLine("Ödeme Yapıldı");
        }
    }
}
