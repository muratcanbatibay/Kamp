using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IGameService
    {
        public void AddCart(GameManager gameManager);
        public void Buy(GameManager gameManager);


    }
}
