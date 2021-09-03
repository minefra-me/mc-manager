
namespace MC_Manager
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkListView1 = new DarkUI.Controls.DarkListView();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.ramUpdater = new System.Windows.Forms.Timer(this.components);
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.darkTextBox2 = new DarkUI.Controls.DarkTextBox();
            this.logUpdater = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkMenuStrip1.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(89, 18);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(7, 22);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(79, 15);
            this.darkLabel1.TabIndex = 5;
            this.darkLabel1.Text = "Current RAM:";
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.darkMenuStrip1.TabIndex = 6;
            this.darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openConfigFileToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openConfigFileToolStripMenuItem
            // 
            this.openConfigFileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openConfigFileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openConfigFileToolStripMenuItem.Name = "openConfigFileToolStripMenuItem";
            this.openConfigFileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openConfigFileToolStripMenuItem.Text = "Open config file";
            this.openConfigFileToolStripMenuItem.Click += new System.EventHandler(this.openconfigFileToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exitApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // darkListView1
            // 
            this.darkListView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkListView1.Location = new System.Drawing.Point(645, 24);
            this.darkListView1.Name = "darkListView1";
            this.darkListView1.Size = new System.Drawing.Size(155, 426);
            this.darkListView1.TabIndex = 7;
            this.darkListView1.Text = "darkListView1";
            this.darkListView1.DoubleClick += new System.EventHandler(this.darkListView1_DoubleClick);
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(426, 18);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(75, 23);
            this.darkButton2.TabIndex = 8;
            this.darkButton2.Text = "Stop";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // darkButton3
            // 
            this.darkButton3.Location = new System.Drawing.Point(345, 18);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(75, 23);
            this.darkButton3.TabIndex = 9;
            this.darkButton3.Text = "Start";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // ramUpdater
            // 
            this.ramUpdater.Enabled = true;
            this.ramUpdater.Interval = 5000;
            this.ramUpdater.Tick += new System.EventHandler(this.ramUpdater_Tick);
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(0, 24);
            this.darkTextBox1.Multiline = true;
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(645, 337);
            this.darkTextBox1.TabIndex = 10;
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkGroupBox1.Controls.Add(this.pictureBox1);
            this.darkGroupBox1.Controls.Add(this.darkTextBox2);
            this.darkGroupBox1.Controls.Add(this.darkLabel1);
            this.darkGroupBox1.Controls.Add(this.darkButton2);
            this.darkGroupBox1.Controls.Add(this.darkButton3);
            this.darkGroupBox1.Controls.Add(this.progressBar1);
            this.darkGroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.darkGroupBox1.Location = new System.Drawing.Point(0, 361);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(645, 89);
            this.darkGroupBox1.TabIndex = 11;
            this.darkGroupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // darkTextBox2
            // 
            this.darkTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox2.Location = new System.Drawing.Point(29, 53);
            this.darkTextBox2.Name = "darkTextBox2";
            this.darkTextBox2.Size = new System.Drawing.Size(610, 23);
            this.darkTextBox2.TabIndex = 10;
            this.darkTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.darkTextBox2_KeyDown);
            // 
            // logUpdater
            // 
            this.logUpdater.Enabled = true;
            this.logUpdater.Interval = 3000;
            this.logUpdater.Tick += new System.EventHandler(this.logUpdater_Tick);
            // 
            // darkLabel2
            // 
            this.darkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(645, 1);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.darkLabel2.Size = new System.Drawing.Size(155, 23);
            this.darkLabel2.TabIndex = 12;
            this.darkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.darkGroupBox1);
            this.Controls.Add(this.darkListView1);
            this.Controls.Add(this.darkMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.darkMenuStrip1;
            this.Name = "Main";
            this.Text = "MC Manager";
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private DarkUI.Controls.DarkListView darkListView1;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkButton darkButton3;
        private System.Windows.Forms.Timer ramUpdater;
        private System.Windows.Forms.ToolStripMenuItem openConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkTextBox darkTextBox2;
        private System.Windows.Forms.Timer logUpdater;
        public DarkUI.Controls.DarkTextBox darkTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DarkUI.Controls.DarkLabel darkLabel2;
    }
}

