using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PokerGame
{
    internal class Player
    {
        public IPAddress address { get; }
        //private string _name;
        public List<Card> Cards;
        //private int chips;

        public Player()
        {
            address = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
            Cards = new List<Card>(2);
        }

    }
}
