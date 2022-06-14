using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeagueSandbox_LAN_Server_Launcher
{
    public class ModSettings
    {
        public int map = 1;
        public string dataPackage = "LeagueSandbox-Scripts";
        public ModSettings(int map = 1, string dataPackage = "LeagueSandbox-Scripts")
        {
            this.map = map;
            this.dataPackage = dataPackage;
        }
    }
}
