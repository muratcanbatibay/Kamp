using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GamerManager : IGamerManager
    {
        IGamerValidater _gamerValidater;

        public GamerManager(IGamerValidater gamerValidater)
        {
            _gamerValidater = gamerValidater;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerValidater.Validate(gamer)==true)
            {
                Console.WriteLine("Kullanıcı Başarıyla Eklendi ve Giriş Yaptı");


            }
            else
            {

                Console.WriteLine("Kullanıcı Geçersiz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Güncellendi");
        }
    }
}
