using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LeagueSandbox_LAN_Server_Launcher
{
    public partial class Form2 : Form
    {
        private int id;
        private string rank;
        private string name;
        private string champion;
        private string team;
        private string summoner1;
        private string summoner2;
        private TabControl parent;
        private ListBox parentListbox;
        private int[] currentMapping;
        private int lastValue = 0;
        private int lastSummoner1;
        private int lastSummoner2;
        private int skin = 0;

        public Form2(int id, string name, string team, TabControl parent, ListBox parentListbox, int[] currentMapping, string summoner1 = "治疗", string summoner2 = "闪现", string rank = "钻石", string champion = "伊泽瑞尔")
        {
            this.id = id;
            this.rank = rank;
            this.name = name;
            this.champion = champion;
            this.team = team;
            this.summoner1 = summoner1;
            this.summoner2 = summoner2;
            this.parentListbox = parentListbox;
            this.currentMapping = currentMapping;
            this.parent = parent;
            InitializeComponent();

            updateTestMode();

            if (team == "RED") this.BackColor = Color.Maroon;
            else this.BackColor = Color.MidnightBlue;

            playerId.Value = id;
            lastValue = id;
            playerName.Text = this.name;
            for(int i = 0; i<playerRank.Items.Count; i++)
            {
                if (playerRank.Items[i] == rank)
                {
                    playerRank.SelectedIndex = i;
                }
            }
            for (int i = 0; i < playerSummoner1.Items.Count; i++)
            {
                if (playerSummoner1.Items[i] == summoner1)
                {
                    playerSummoner1.SelectedIndex = i;
                    lastSummoner1 = i;
                }
            }
            for (int i = 0; i < playerSummoner2.Items.Count; i++)
            {
                if (playerSummoner2.Items[i] == summoner2)
                {
                    playerSummoner2.SelectedIndex = i;
                    lastSummoner2 = i;
                }
            }
            for (int i = 0; i < playerChampion.Items.Count; i++)
            {
                if (playerChampion.Items[i] == champion)
                {
                    playerChampion.SelectedIndex = i;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * variables used:
                private TabControl parent;
                private ListBox parentListbox;
                private int[] currentMapping;
             */
            
            for(int i = 0; i < Form1.blueMapping.Count; i++)
            {
                if (Form1.blueMapping[i][1] > currentMapping[1]) Form1.blueMapping[i][1]--;
            }// reindex blue mapping
            for (int i = 0; i < Form1.redMapping.Count; i++)
            {
                if (Form1.redMapping[i][1] > currentMapping[1]) Form1.redMapping[i][1]--;
            }// reindex red mapping
            if(team == "BLUE")
            {
                for(int i = 0; i < parentListbox.Items.Count; i++)
                {
                    if (Form1.blueMapping[i][0] > currentMapping[0]) Form1.blueMapping[i][0]--;
                }
            }// reindex blue mapping if nessisary
            else
            {
                for (int i = 0; i < parentListbox.Items.Count; i++)
                {
                    if (Form1.redMapping[i][0] > currentMapping[0]) Form1.redMapping[i][0]--;
                }
            }// reindex red mapping if nessisary
            parentListbox.Items.RemoveAt(currentMapping[0]);
            parent.TabPages.RemoveAt(currentMapping[1]);
            if (team == "RED") 
            {
                Form1.redPlayerCount--;
                Form1.red.RemoveAt(currentMapping[0]);
            }
            else
            {
                Form1.bluePlayerCount--;
                Form1.blue.RemoveAt(currentMapping[0]);
            }
            Form1.playerCount--;
            Console.WriteLine(Form1.blueMapping);
            Console.WriteLine(Form1.redMapping);
            Form1.idList.Remove(lastValue);
            this.Close();
        }

        private void playerName_TextChanged(object sender, EventArgs e)
        {
            parentListbox.Items[currentMapping[0]] = playerName.Text;
        }
        public Player buildPlayer()
        {
            return new Player(id, rank, name, champion, team, summoner1, summoner2, skin);
        }

        private void playerId_ValueChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < Form1.idList.Count; i++)
            {
                if (Form1.idList[i] == playerId.Value)
                {
                    playerId.Value = lastValue;
                    return;
                }
            }
            repeat:
                if(Form1.idList.Remove(lastValue)) goto repeat;
            Form1.idList.Add(Convert.ToInt32(playerId.Value));
            lastValue = Convert.ToInt32(playerId.Value);
        }

        private void playerRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (playerRank.SelectedIndex)
            {
                case 0:
                    rank = "DIAMOND";
                    break;
                default:
                    rank = "DIAMOND";
                    break;
            }
        }

        private void playerChampion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (playerChampion.SelectedIndex)
            {
                case 0:
                    champion = "Ezreal";
                    break;
                default:
                    champion = "Ezreal";
                    break;
            }
        }

        private void playerSummoner1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerSummoner1.SelectedIndex != playerSummoner2.SelectedIndex)
            {
                switch (playerSummoner1.SelectedIndex)
                {
                    case 0:
                        summoner1 = "SummonerHeal";
                        break;
                    case 1:
                        summoner1 = "SummonerFlash";
                        break;
                    default:
                        champion = "SummonerHeal";
                        break;
                }
                return;
            }
            playerSummoner1.SelectedIndex = lastSummoner1;
        }

        private void playerSummoner2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerSummoner2.SelectedIndex != playerSummoner1.SelectedIndex)
            {
                switch (playerSummoner2.SelectedIndex)
                {
                    case 0:
                        summoner2 = "SummonerHeal";
                        break;
                    case 1:
                        summoner2 = "SummonerFlash";
                        break;
                    default:
                        champion = "SummonerHeal";
                        break;
                }
                return;
            }
            playerSummoner2.SelectedIndex = lastSummoner2;
        }
        public void updateTestMode()
        {
            panel7.Visible = Form1.testingMode;
            numericUpDown1.Value = 0;
            skin = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            skin = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
