namespace GZDoomServerGUI;

partial class MainWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        splitContainer1 = new SplitContainer();
        flowLayoutPanel1 = new FlowLayoutPanel();
        label1 = new Label();
        textWadName = new TextBox();
        label3 = new Label();
        textboxNPlayer = new TextBox();
        label7 = new Label();
        textboxSkill = new TextBox();
        label4 = new Label();
        textboxLevel = new TextBox();
        label2 = new Label();
        checkDeathmatch = new CheckBox();
        label8 = new Label();
        checkMonsters = new CheckBox();
        btnHostServer = new Button();
        flowLayoutPanel2 = new FlowLayoutPanel();
        label6 = new Label();
        textboxWadJoin = new TextBox();
        label5 = new Label();
        textboxHostIp = new TextBox();
        btnJoinServer = new Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        flowLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.BackColor = Color.Gray;
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.BackColor = Color.DimGray;
        splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
        splitContainer1.Panel1.Controls.Add(btnHostServer);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.BackColor = Color.DimGray;
        splitContainer1.Panel2.Controls.Add(flowLayoutPanel2);
        splitContainer1.Panel2.Controls.Add(btnJoinServer);
        splitContainer1.Size = new Size(413, 220);
        splitContainer1.SplitterDistance = 200;
        splitContainer1.TabIndex = 0;
        splitContainer1.TabStop = false;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Controls.Add(label1);
        flowLayoutPanel1.Controls.Add(textWadName);
        flowLayoutPanel1.Controls.Add(label3);
        flowLayoutPanel1.Controls.Add(textboxNPlayer);
        flowLayoutPanel1.Controls.Add(label7);
        flowLayoutPanel1.Controls.Add(textboxSkill);
        flowLayoutPanel1.Controls.Add(label4);
        flowLayoutPanel1.Controls.Add(textboxLevel);
        flowLayoutPanel1.Controls.Add(label2);
        flowLayoutPanel1.Controls.Add(checkDeathmatch);
        flowLayoutPanel1.Controls.Add(label8);
        flowLayoutPanel1.Controls.Add(checkMonsters);
        flowLayoutPanel1.Location = new Point(12, 20);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(188, 165);
        flowLayoutPanel1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.ForeColor = Color.White;
        label1.Location = new Point(3, 7);
        label1.Name = "label1";
        label1.Size = new Size(34, 15);
        label1.TabIndex = 1;
        label1.Text = "WAD";
        // 
        // textWadName
        // 
        textWadName.BackColor = Color.Black;
        textWadName.BorderStyle = BorderStyle.FixedSingle;
        textWadName.ForeColor = Color.White;
        textWadName.Location = new Point(43, 3);
        textWadName.Name = "textWadName";
        textWadName.Size = new Size(133, 23);
        textWadName.TabIndex = 0;
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.None;
        label3.AutoSize = true;
        label3.ForeColor = Color.White;
        label3.Location = new Point(3, 36);
        label3.Name = "label3";
        label3.Size = new Size(44, 15);
        label3.TabIndex = 4;
        label3.Text = "Players";
        // 
        // textboxNPlayer
        // 
        textboxNPlayer.BackColor = Color.Black;
        textboxNPlayer.BorderStyle = BorderStyle.FixedSingle;
        textboxNPlayer.ForeColor = Color.White;
        textboxNPlayer.Location = new Point(53, 32);
        textboxNPlayer.Name = "textboxNPlayer";
        textboxNPlayer.Size = new Size(123, 23);
        textboxNPlayer.TabIndex = 5;
        // 
        // label7
        // 
        label7.Anchor = AnchorStyles.None;
        label7.AutoSize = true;
        label7.ForeColor = Color.White;
        label7.Location = new Point(3, 65);
        label7.Name = "label7";
        label7.Size = new Size(28, 15);
        label7.TabIndex = 8;
        label7.Text = "Skill";
        // 
        // textboxSkill
        // 
        textboxSkill.BackColor = Color.Black;
        textboxSkill.BorderStyle = BorderStyle.FixedSingle;
        textboxSkill.ForeColor = Color.White;
        textboxSkill.Location = new Point(37, 61);
        textboxSkill.Name = "textboxSkill";
        textboxSkill.Size = new Size(139, 23);
        textboxSkill.TabIndex = 7;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.None;
        label4.AutoSize = true;
        label4.ForeColor = Color.White;
        label4.Location = new Point(3, 94);
        label4.Name = "label4";
        label4.Size = new Size(34, 15);
        label4.TabIndex = 6;
        label4.Text = "Level";
        // 
        // textboxLevel
        // 
        textboxLevel.BackColor = Color.Black;
        textboxLevel.BorderStyle = BorderStyle.FixedSingle;
        textboxLevel.ForeColor = Color.White;
        textboxLevel.Location = new Point(43, 90);
        textboxLevel.Name = "textboxLevel";
        textboxLevel.Size = new Size(133, 23);
        textboxLevel.TabIndex = 9;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.White;
        label2.Location = new Point(3, 116);
        label2.Name = "label2";
        label2.Size = new Size(72, 15);
        label2.TabIndex = 10;
        label2.Text = "Deathmatch";
        // 
        // checkDeathmatch
        // 
        checkDeathmatch.AutoSize = true;
        flowLayoutPanel1.SetFlowBreak(checkDeathmatch, true);
        checkDeathmatch.Location = new Point(81, 119);
        checkDeathmatch.Name = "checkDeathmatch";
        checkDeathmatch.Size = new Size(15, 14);
        checkDeathmatch.TabIndex = 11;
        checkDeathmatch.UseVisualStyleBackColor = true;
        // 
        // label8
        // 
        label8.Anchor = AnchorStyles.None;
        label8.AutoSize = true;
        label8.ForeColor = Color.White;
        label8.Location = new Point(3, 138);
        label8.Name = "label8";
        label8.Size = new Size(56, 15);
        label8.TabIndex = 12;
        label8.Text = "Monsters";
        // 
        // checkMonsters
        // 
        checkMonsters.Anchor = AnchorStyles.None;
        checkMonsters.AutoSize = true;
        checkMonsters.Location = new Point(65, 139);
        checkMonsters.Name = "checkMonsters";
        checkMonsters.Size = new Size(15, 14);
        checkMonsters.TabIndex = 13;
        checkMonsters.UseVisualStyleBackColor = true;
        // 
        // btnHostServer
        // 
        btnHostServer.Anchor = AnchorStyles.Bottom;
        btnHostServer.Location = new Point(62, 190);
        btnHostServer.Name = "btnHostServer";
        btnHostServer.Size = new Size(75, 23);
        btnHostServer.TabIndex = 10;
        btnHostServer.Text = "Host Server";
        btnHostServer.UseVisualStyleBackColor = true;
        btnHostServer.Click += btnHostServer_Click;
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Controls.Add(label6);
        flowLayoutPanel2.Controls.Add(textboxWadJoin);
        flowLayoutPanel2.Controls.Add(label5);
        flowLayoutPanel2.Controls.Add(textboxHostIp);
        flowLayoutPanel2.Location = new Point(21, 20);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new Size(170, 100);
        flowLayoutPanel2.TabIndex = 2;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.None;
        label6.AutoSize = true;
        label6.ForeColor = Color.White;
        label6.Location = new Point(3, 7);
        label6.Name = "label6";
        label6.Size = new Size(34, 15);
        label6.TabIndex = 2;
        label6.Text = "WAD";
        // 
        // textboxWadJoin
        // 
        textboxWadJoin.BackColor = Color.Black;
        textboxWadJoin.BorderStyle = BorderStyle.FixedSingle;
        textboxWadJoin.ForeColor = Color.White;
        textboxWadJoin.Location = new Point(43, 3);
        textboxWadJoin.Name = "textboxWadJoin";
        textboxWadJoin.Size = new Size(115, 23);
        textboxWadJoin.TabIndex = 15;
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.None;
        label5.AutoSize = true;
        label5.BackColor = Color.Transparent;
        label5.ForeColor = Color.White;
        label5.Location = new Point(3, 36);
        label5.Name = "label5";
        label5.Size = new Size(57, 15);
        label5.TabIndex = 0;
        label5.Text = "Host IPv4";
        // 
        // textboxHostIp
        // 
        textboxHostIp.BackColor = Color.Black;
        textboxHostIp.BorderStyle = BorderStyle.FixedSingle;
        textboxHostIp.ForeColor = Color.White;
        textboxHostIp.Location = new Point(66, 32);
        textboxHostIp.Name = "textboxHostIp";
        textboxHostIp.Size = new Size(92, 23);
        textboxHostIp.TabIndex = 17;
        // 
        // btnJoinServer
        // 
        btnJoinServer.Anchor = AnchorStyles.Bottom;
        btnJoinServer.Location = new Point(68, 190);
        btnJoinServer.Name = "btnJoinServer";
        btnJoinServer.Size = new Size(75, 23);
        btnJoinServer.TabIndex = 20;
        btnJoinServer.Text = "Join Server";
        btnJoinServer.UseVisualStyleBackColor = true;
        btnJoinServer.Click += btnJoinServer_Click;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(413, 220);
        Controls.Add(splitContainer1);
        Name = "MainWindow";
        Text = "GZDoom Multiplayer Tool";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        flowLayoutPanel2.ResumeLayout(false);
        flowLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private Button btnHostServer;
    private Button btnJoinServer;
    private FlowLayoutPanel flowLayoutPanel1;
    private Label label1;
    private TextBox textWadName;
    private Label label3;
    private TextBox textboxNPlayer;
    private Label label4;
    private TextBox textboxLevel;
    private FlowLayoutPanel flowLayoutPanel2;
    private Label label5;
    private TextBox textboxHostIp;
    private Label label6;
    private TextBox textboxWadJoin;
    private Label label7;
    private TextBox textboxSkill;
    private Label label2;
    private CheckBox checkDeathmatch;
    private Label label8;
    private CheckBox checkMonsters;
}