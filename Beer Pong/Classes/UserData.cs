using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beer_Pong.Classes
{
    public class UserData
    {
        public int UserId { get; set; }
        public int Wins { get; set; }
        public int Games { get; set; }
        public string UserName { get; set; }

        public UserData(string userName, int userId)
        {
            UserName = userName;
            Wins = 0;
            Games = 0;
            UserId = userId;
        }
    }
}
