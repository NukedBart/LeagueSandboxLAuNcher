using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LeagueSandbox_LAN_Server_Launcher
{
    public partial class Form1 : Form
    {
        private bool maximized = false;
        public static List<Form2> red = new List<Form2>();
        public static List<Form2> blue = new List<Form2>();
        public static int redPlayerCount = 0;
        public static int bluePlayerCount = 0;
        public static int playerCount = 0;
        public static int playerId = 0;
        public static List<int> idList = new List<int>();
        public static List<int[]> redMapping = new List<int[]>();
        public static List<int[]> blueMapping = new List<int[]>();
        
        private int progressValue = 100;
        private bool debug = false;
        private string contentPath;
        private int scanDepth = 10;
        private bool cheatsEnabled = false;
        private bool manacostsEnabled = true;
        private bool cooldownsEnabled = true;
        private bool minionSpawnsEnabled = true;

        public Form1()
        {
            InitializeComponent();
            // Content Path Scan, CPS
            string gDirectory = "";
            for (int i = 1; i < scanDepth + 1; i++)
            {
                string directory = "";
                for (int j = 1; j < i + 1; j++)
                {
                    directory += "../";
                }
                if (Directory.Exists(directory + "Contents/"))
                {
                    contentPath = directory + "Contents/";
                    textBox1.Text = directory + "Contents/";
                    gDirectory = directory;
                    break;
                }
                if (Directory.Exists(gDirectory)) break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void setProgess(int value)
        {
            float maximumWidth = panel6.Width/100;
            if ((maximumWidth * 100 - value * maximumWidth) >= 0)
            {
                progress.Width = Convert.ToInt32(maximumWidth * (100 - value));
                button3.Width = Convert.ToInt32(value * maximumWidth);
                button3.TextAlign = ContentAlignment.MiddleCenter;
                progressValue = value;
            }
            this.Invalidate();
        }
        bool launchDisabled = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (!launchDisabled)
            {
                launchDisabled = true;
                setProgess(30);
                button3.Text = "构建玩家...";
                Game game = prepareBuild();
                string buffer = buildJson(game);
                Console.WriteLine(buffer);
                setProgess(85);
                button3.Text = "写入Json...";
                File.WriteAllText("Settings\\GameInfo.json", buffer);
                setProgess(95);
                button3.Text = "启动服务器...";
                Process.Start("GameServerConsole.exe");
                setProgess(100);
                button3.Text = "启动服务器！";
                launchDisabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maximizeTrigger();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point LeftDown;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            LeftDown.X = e.X;
            LeftDown.Y = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = MousePosition;
                p.Offset(-LeftDown.X, -LeftDown.Y);
                Location = p;
            }
            if (maximized & e.Button == MouseButtons.Left)
            {
                button5.Text = "口";
                this.WindowState = FormWindowState.Normal;
                maximized = !maximized;
                setProgess(progressValue);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            LeftDown.X = e.X;
            LeftDown.Y = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = MousePosition;
                p.Offset(-LeftDown.X, -LeftDown.Y);
                Location = p;
            }
            if (maximized & e.Button == MouseButtons.Left)
            {
                button5.Text = "口";
                this.WindowState = FormWindowState.Normal;
                maximized = !maximized;
                setProgess(progressValue);
            }
        }

        private void panel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maximizeTrigger();
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maximizeTrigger();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add before use
            playerCount++;
            redPlayerCount++;
            if (redPlayerCount < 6)
            {
                playerId++;
                // Used to link listboxes to tabpage indexes
                int[] mapping = { redPlayerCount - 1, playerCount };
                redMapping.Add(mapping);
                listBox1.Items.Add("Player" + Convert.ToString(playerId));
                // New player instance
                Form2 form = new Form2(playerId, "Player" + Convert.ToString(playerId), "RED", tabControl1, listBox1, redMapping[redMapping.Count-1]);
                // New tabpage to hold the instance
                TabPage neu = new TabPage();
                // Instance initilization
                neu.BackColor = Color.Maroon;
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                form.WindowState = FormWindowState.Maximized;
                // Add to the UI Display
                red.Add(form);
                neu.Controls.Add(red[redPlayerCount - 1]);
                tabControl1.TabPages.Add(neu);
                red[redPlayerCount - 1].Show();
                tabControl1.SelectedIndex = playerCount;
                idList.Add(playerId);
            }
            else
            {
                playerCount--;
                redPlayerCount--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            playerCount++;
            bluePlayerCount++;
            if (bluePlayerCount < 6)
            {
                playerId++;
                int[] mapping = { bluePlayerCount - 1, playerCount };
                blueMapping.Add(mapping);
                listBox2.Items.Add("Player" + Convert.ToString(playerId));
                Form2 form = new Form2(playerId, "Player" + Convert.ToString(playerId), "BLUE", tabControl1, listBox2, blueMapping[blueMapping.Count-1]);
                TabPage neu = new TabPage();
                neu.BackColor = Color.MidnightBlue;
                form.Dock = DockStyle.Fill;
                form.TopLevel = false;
                form.WindowState = FormWindowState.Maximized;
                blue.Add(form);
                neu.Controls.Add(blue[bluePlayerCount - 1]);
                tabControl1.TabPages.Add(neu);
                blue[bluePlayerCount - 1].Show();
                tabControl1.SelectedIndex = playerCount;
                idList.Add(playerId);
            }
            else
            {
                playerCount--;
                bluePlayerCount--;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int[] mapping in redMapping)
            {
                if (listBox1.SelectedIndex == mapping[0])
                {
                    if (!(listBox2.SelectedIndex < 0))
                        listBox2.SelectedIndex = -1;
                    tabControl1.SelectedIndex = mapping[1];
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int[] mapping in blueMapping)
            {
                if (listBox2.SelectedIndex == mapping[0])
                {
                    if (!(listBox1.SelectedIndex < 0))
                        listBox1.SelectedIndex = -1;
                    tabControl1.SelectedIndex = mapping[1];
                }
            }
        }

        private void maximizeTrigger()
        {
            if (maximized)
            {
                button5.Text = "口";
                this.WindowState = FormWindowState.Normal;
                maximized = !maximized;
            }
            else
            {
                button5.Text = "▽";
                this.WindowState = FormWindowState.Maximized;
                maximized = !maximized;
            }
            setProgess(progressValue);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (debug) return; 
            if (!File.Exists("GameServerConsole.exe") || !Directory.Exists("Settings\\"))
            {
                MessageBox.Show("未找到服务器文件，请将本程序至于GameServerConsole.exe同级目录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private Game prepareBuild()
        {
            List<Player> players = new List<Player>();
            for (int i = 0; i < redPlayerCount; i++)
            {
                /*  public int playerId;
                    public string rank;
                    public string name;
                    public string champion;
                    public string team;
                    public string summoner1;
                    public string summoner2;
                    */
                Form2 builder = tabControl1.TabPages[redMapping[i][1]].Controls[0] as Form2;
                players.Add(builder.buildPlayer());
            }
            for (int i = 0; i < bluePlayerCount; i++)
            {
                Form2 builder = tabControl1.TabPages[blueMapping[i][1]].Controls[0] as Form2;
                players.Add(builder.buildPlayer());
            }
            setProgess(50);
            button3.Text = "建立数据结构...";
            return new Game(players, manacostsEnabled, cooldownsEnabled, cheatsEnabled, minionSpawnsEnabled, contentPath);
        }
        private string buildJson(Game game)
        {
            setProgess(75);
            button3.Text = "构建Json...";
            return JsonConvert.SerializeObject(game, Formatting.Indented);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            contentPath = textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cheatsEnabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            manacostsEnabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            cooldownsEnabled = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            minionSpawnsEnabled = checkBox4.Checked;
        }
    }
}
