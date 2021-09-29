using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameEventManager : IGameEventService
    {
        public void Discount(GameEventManager gameEvent)
        {
            Console.WriteLine(" Tebrikler!!  % 40 İndirim Kazandınız!1");
        }

        public void MonthlyDiscount(GameEventManager gameEvent)
        {
            Console.WriteLine("Bu Ay % 30 İndirimiz Var!!");
        }

        public void SeasonDiscount(GameEventManager gameEvent)
        {
            Console.WriteLine(" %60 Hoşgeldin Yaz İndirimi!!");
        }
    }
}
