using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GamerValidater : IGamerValidater
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 123456 && gamer.BirthYear == 1996)
            {


                return true;
            }



            else
            {

                return false;


            }

        }
    }
}
