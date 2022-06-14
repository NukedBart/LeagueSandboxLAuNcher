using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueSandbox_LAN_Server_Launcher
{
    public class GameInfo
    {
        public bool MANACOSTS_ENABLED = true;
        public bool COOLDOWNS_ENABLED = true;
        public bool CHEATS_ENABLED = false;
        public bool MINION_SPAWNS_ENABLED = true;
        public string CONTENT_PATH = "../../../../Content";
        public bool IS_DAMAGE_TEXT_GLOBAL = false;
        public GameInfo(bool MANACOSTS_ENABLED = true,
                        bool COOLDOWNS_ENABLED = true,
                        bool CHEATS_ENABLED = false,
                        bool MINION_SPAWNS_ENABLED = true,
                        string CONTENT_PATH = "../../../../Content",
                        bool IS_DAMAGE_TEXT_GLOBAL = false)
        {
            this.MANACOSTS_ENABLED = MANACOSTS_ENABLED;
            this.COOLDOWNS_ENABLED = COOLDOWNS_ENABLED;
            this.CHEATS_ENABLED = CHEATS_ENABLED;
            this.MINION_SPAWNS_ENABLED = MINION_SPAWNS_ENABLED;
            this.CONTENT_PATH = CONTENT_PATH;
            this.IS_DAMAGE_TEXT_GLOBAL = IS_DAMAGE_TEXT_GLOBAL;
        }
    }
}
