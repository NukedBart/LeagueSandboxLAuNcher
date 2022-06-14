namespace LeagueSandbox_LAN_Server_Launcher
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.playerId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.playerRank = new System.Windows.Forms.ComboBox();
            this.playerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.playerChampion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.playerSummoner1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.playerSummoner2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家ID";
            // 
            // playerId
            // 
            this.playerId.Location = new System.Drawing.Point(88, 12);
            this.playerId.Maximum = new decimal(new int[] {
            2140000000,
            0,
            0,
            0});
            this.playerId.Name = "playerId";
            this.playerId.Size = new System.Drawing.Size(46, 21);
            this.playerId.TabIndex = 1;
            this.playerId.ValueChanged += new System.EventHandler(this.playerId_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(140, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "* 玩家用于连接服务器的识别编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(208, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "* 在对局中显示的段位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(53, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "段位";
            // 
            // playerRank
            // 
            this.playerRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerRank.FormattingEnabled = true;
            this.playerRank.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.playerRank.Items.AddRange(new object[] {
            "钻石"});
            this.playerRank.Location = new System.Drawing.Point(87, 39);
            this.playerRank.Name = "playerRank";
            this.playerRank.Size = new System.Drawing.Size(114, 20);
            this.playerRank.TabIndex = 4;
            this.playerRank.SelectedIndexChanged += new System.EventHandler(this.playerRank_SelectedIndexChanged);
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(87, 66);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(115, 21);
            this.playerName.TabIndex = 7;
            this.playerName.TextChanged += new System.EventHandler(this.playerName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(208, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "* 玩家在对局中的昵称";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(53, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "昵称";
            // 
            // playerChampion
            // 
            this.playerChampion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerChampion.FormattingEnabled = true;
            this.playerChampion.Items.AddRange(new object[] {
            "伊泽瑞尔"});
            this.playerChampion.Location = new System.Drawing.Point(88, 94);
            this.playerChampion.Name = "playerChampion";
            this.playerChampion.Size = new System.Drawing.Size(114, 20);
            this.playerChampion.TabIndex = 10;
            this.playerChampion.SelectedIndexChanged += new System.EventHandler(this.playerChampion_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(53, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "英雄";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(208, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "* 玩家在对局中使用的英雄";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(207, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "* 玩家在对局中使用的技能";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(10, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "召唤师技能A";
            // 
            // playerSummoner1
            // 
            this.playerSummoner1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerSummoner1.FormattingEnabled = true;
            this.playerSummoner1.Items.AddRange(new object[] {
            "治疗",
            "闪现"});
            this.playerSummoner1.Location = new System.Drawing.Point(87, 120);
            this.playerSummoner1.Name = "playerSummoner1";
            this.playerSummoner1.Size = new System.Drawing.Size(114, 20);
            this.playerSummoner1.TabIndex = 13;
            this.playerSummoner1.SelectedIndexChanged += new System.EventHandler(this.playerSummoner1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(208, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "* 玩家在对局中使用的技能，不可重复";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(12, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "召唤师技能B";
            // 
            // playerSummoner2
            // 
            this.playerSummoner2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerSummoner2.FormattingEnabled = true;
            this.playerSummoner2.Items.AddRange(new object[] {
            "治疗",
            "闪现"});
            this.playerSummoner2.Location = new System.Drawing.Point(88, 146);
            this.playerSummoner2.Name = "playerSummoner2";
            this.playerSummoner2.Size = new System.Drawing.Size(114, 20);
            this.playerSummoner2.TabIndex = 16;
            this.playerSummoner2.SelectedIndexChanged += new System.EventHandler(this.playerSummoner2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SimSun", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(88, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "移除玩家";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(657, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.playerSummoner2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.playerSummoner1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.playerChampion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.playerRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.playerId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown playerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox playerRank;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox playerChampion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox playerSummoner1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox playerSummoner2;
        private System.Windows.Forms.Button button1;
    }
}