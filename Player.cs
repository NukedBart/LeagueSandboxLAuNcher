using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueSandbox_LAN_Server_Launcher
{
    public class Player
    {
        public int playerId;
        public string blowfishKey = "17BLOhi6KZsTtldTsizvHg==";
        public string rank;
        public string name;
        public string champion;
        public string team;
        public int skin = 0;
        public string summoner1;
        public string summoner2;
        public int ribbon = 2;
        public int icon = 0;
        public Dictionary<string, int> runes = new Dictionary<string, int>()
        {
            ["1"] = 5245,
            ["2"] = 5245,
            ["3"] = 5245,
            ["4"] = 5245,
            ["5"] = 5245,
            ["6"] = 5245,
            ["7"] = 5245,
            ["8"] = 5245,
            ["9"] = 5245,
            ["10"] = 5317,
            ["11"] = 5317,
            ["12"] = 5317,
            ["13"] = 5317,
            ["14"] = 5317,
            ["15"] = 5317,
            ["16"] = 5317,
            ["17"] = 5317,
            ["18"] = 5317,
            ["19"] = 5289,
            ["20"] = 5289,
            ["21"] = 5289,
            ["22"] = 5289,
            ["23"] = 5289,
            ["24"] = 5289,
            ["25"] = 5289,
            ["26"] = 5289,
            ["27"] = 5289,
            ["28"] = 5335,
            ["29"] = 5335,
            ["30"] = 5335
        };
        public Player(int playerId, string rank, string name, string champion, string team, string summoner1, string summoner2, int skin = 0)
        {
            this.playerId = playerId;
            this.rank = rank;
            this.name = name;
            this.champion = champion;
            this.team = team;
            this.summoner1 = summoner1;
            this.summoner2 = summoner2;
            this.skin = skin;
        }
    }
}
