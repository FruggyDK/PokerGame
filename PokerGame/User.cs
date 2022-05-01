using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PokerGame
{
    internal class User
    {
        private long user_id;
        public string username { get;  } 
        public int chip_balance { get; set; }
        
        public User(long user_id, string username)
        {
            this.user_id = user_id;
            this.username = username;
            GetChipBalance();
        }

        

        private void GetChipBalance()
        {
            chip_balance = DatabaseHandler.GetUsersChipBalance(user_id);
        }

        public void SyncWithDatabase()
        {
            DatabaseHandler.UpdateUsersChipBalance(user_id, chip_balance);
        }
    }
}
