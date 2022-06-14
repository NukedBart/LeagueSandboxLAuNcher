using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueSandbox_LAN_Server_Launcher
{
    public class Game
    {
        public List<Player> players;
        public ModSettings game = new ModSettings();
        public GameInfo gameInfo = new GameInfo();
        public Game(List<Player> players)
        {
            this.players = players;
        }
    }
}
