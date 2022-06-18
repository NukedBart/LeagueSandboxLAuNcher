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
        public GameInfo gameInfo;
        public Game(List<Player> players, 
                    bool MANACOSTS_ENABLED = true,
                    bool COOLDOWNS_ENABLED = true,
                    bool CHEATS_ENABLED = false,
                    bool MINION_SPAWNS_ENABLED = true,
                    string CONTENT_PATH = "../../../../Content",
                    bool IS_DAMAGE_TEXT_GLOBAL = false)
        {
            this.players = players;
            gameInfo = new GameInfo(MANACOSTS_ENABLED, COOLDOWNS_ENABLED, CHEATS_ENABLED, MINION_SPAWNS_ENABLED, CONTENT_PATH, IS_DAMAGE_TEXT_GLOBAL);
        }
    }
}
