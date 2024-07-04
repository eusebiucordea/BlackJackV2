using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackV2
{
    class Player
    {
        private List<Cards> player_list;

        public Player()
        {
            player_list = new List<Cards>();
        }
        //Adauga cartile in lista
        public void AddCards(Cards card)
        {
            player_list.Add(card);
        }
        //Goleste lista
        public void ClearCards() 
        {
            player_list.Clear();
        }

        public int SumPlayer()
        {
            //Suma carti player/dealer
            int suma_player = 0;
            for(int i = 0; i < player_list.Count;i++)
            {
                suma_player += player_list[i].Value;
            }

            //Daca suma > 21, as-ul devine 1
            if(suma_player > 21)
            {
                foreach(Cards card in player_list) 
                {
                    if(card.Value == 11) 
                    {
                        suma_player -= 10;
                        if (suma_player <= 21)
                            break;
                    }
                }
            }
            return suma_player;
        }
    }
}
