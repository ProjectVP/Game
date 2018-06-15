namespace HackerManGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GBStart = new System.Windows.Forms.GroupBox();
            this.BStart = new System.Windows.Forms.Button();
            this.HackerManPic = new System.Windows.Forms.PictureBox();
            this.Enemy3Pic = new System.Windows.Forms.PictureBox();
            this.Enemy2Pic = new System.Windows.Forms.PictureBox();
            this.Enemy1Pic = new System.Windows.Forms.PictureBox();
            this.Stone5 = new System.Windows.Forms.PictureBox();
            this.Stone4 = new System.Windows.Forms.PictureBox();
            this.Stone3 = new System.Windows.Forms.PictureBox();
            this.Stone2 = new System.Windows.Forms.PictureBox();
            this.Stone1 = new System.Windows.Forms.PictureBox();
            this.GBStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HackerManPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 537);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(863, 537);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GBStart
            // 
            this.GBStart.Controls.Add(this.BStart);
            this.GBStart.Location = new System.Drawing.Point(6, 1);
            this.GBStart.Margin = new System.Windows.Forms.Padding(4);
            this.GBStart.Name = "GBStart";
            this.GBStart.Padding = new System.Windows.Forms.Padding(4);
            this.GBStart.Size = new System.Drawing.Size(942, 567);
            this.GBStart.TabIndex = 16;
            this.GBStart.TabStop = false;
            // 
            // BStart
            // 
            this.BStart.Location = new System.Drawing.Point(393, 252);
            this.BStart.Margin = new System.Windows.Forms.Padding(4);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(100, 28);
            this.BStart.TabIndex = 0;
            this.BStart.Text = "start";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // HackerManPic
            // 
            this.HackerManPic.Image = ((System.Drawing.Image)(resources.GetObject("HackerManPic.Image")));
            this.HackerManPic.Location = new System.Drawing.Point(16, 15);
            this.HackerManPic.Margin = new System.Windows.Forms.Padding(4);
            this.HackerManPic.Name = "HackerManPic";
            this.HackerManPic.Size = new System.Drawing.Size(60, 64);
            this.HackerManPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HackerManPic.TabIndex = 13;
            this.HackerManPic.TabStop = false;
            // 
            // Enemy3Pic
            // 
            this.Enemy3Pic.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3Pic.Image")));
            this.Enemy3Pic.Location = new System.Drawing.Point(549, 86);
            this.Enemy3Pic.Margin = new System.Windows.Forms.Padding(4);
            this.Enemy3Pic.Name = "Enemy3Pic";
            this.Enemy3Pic.Size = new System.Drawing.Size(47, 66);
            this.Enemy3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy3Pic.TabIndex = 11;
            this.Enemy3Pic.TabStop = false;
            this.Enemy3Pic.Tag = "enemy";
            // 
            // Enemy2Pic
            // 
            this.Enemy2Pic.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2Pic.Image")));
            this.Enemy2Pic.Location = new System.Drawing.Point(400, 414);
            this.Enemy2Pic.Margin = new System.Windows.Forms.Padding(4);
            this.Enemy2Pic.Name = "Enemy2Pic";
            this.Enemy2Pic.Size = new System.Drawing.Size(47, 66);
            this.Enemy2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy2Pic.TabIndex = 10;
            this.Enemy2Pic.TabStop = false;
            this.Enemy2Pic.Tag = "enemy";
            // 
            // Enemy1Pic
            // 
            this.Enemy1Pic.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1Pic.Image")));
            this.Enemy1Pic.Location = new System.Drawing.Point(245, 75);
            this.Enemy1Pic.Margin = new System.Windows.Forms.Padding(4);
            this.Enemy1Pic.Name = "Enemy1Pic";
            this.Enemy1Pic.Size = new System.Drawing.Size(47, 65);
            this.Enemy1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy1Pic.TabIndex = 9;
            this.Enemy1Pic.TabStop = false;
            this.Enemy1Pic.Tag = "enemy";
            // 
            // Stone5
            // 
            this.Stone5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stone5.Image = ((System.Drawing.Image)(resources.GetObject("Stone5.Image")));
            this.Stone5.Location = new System.Drawing.Point(720, -1);
            this.Stone5.Margin = new System.Windows.Forms.Padding(4);
            this.Stone5.Name = "Stone5";
            this.Stone5.Size = new System.Drawing.Size(20, 402);
            this.Stone5.TabIndex = 8;
            this.Stone5.TabStop = false;
            this.Stone5.Tag = "wall";
            // 
            // Stone4
            // 
            this.Stone4.Image = ((System.Drawing.Image)(resources.GetObject("Stone4.Image")));
            this.Stone4.Location = new System.Drawing.Point(561, 167);
            this.Stone4.Margin = new System.Windows.Forms.Padding(4);
            this.Stone4.Name = "Stone4";
            this.Stone4.Size = new System.Drawing.Size(20, 385);
            this.Stone4.TabIndex = 7;
            this.Stone4.TabStop = false;
            this.Stone4.Tag = "wall";
            // 
            // Stone3
            // 
            this.Stone3.Image = ((System.Drawing.Image)(resources.GetObject("Stone3.Image")));
            this.Stone3.Location = new System.Drawing.Point(415, 0);
            this.Stone3.Margin = new System.Windows.Forms.Padding(4);
            this.Stone3.Name = "Stone3";
            this.Stone3.Size = new System.Drawing.Size(20, 401);
            this.Stone3.TabIndex = 6;
            this.Stone3.TabStop = false;
            this.Stone3.Tag = "wall";
            // 
            // Stone2
            // 
            this.Stone2.Image = ((System.Drawing.Image)(resources.GetObject("Stone2.Image")));
            this.Stone2.Location = new System.Drawing.Point(259, 148);
            this.Stone2.Margin = new System.Windows.Forms.Padding(4);
            this.Stone2.Name = "Stone2";
            this.Stone2.Size = new System.Drawing.Size(20, 420);
            this.Stone2.TabIndex = 5;
            this.Stone2.TabStop = false;
            this.Stone2.Tag = "wall";
            // 
            // Stone1
            // 
            this.Stone1.Image = ((System.Drawing.Image)(resources.GetObject("Stone1.Image")));
            this.Stone1.Location = new System.Drawing.Point(125, 0);
            this.Stone1.Margin = new System.Windows.Forms.Padding(4);
            this.Stone1.Name = "Stone1";
            this.Stone1.Size = new System.Drawing.Size(20, 401);
            this.Stone1.TabIndex = 0;
            this.Stone1.TabStop = false;
            this.Stone1.Tag = "wall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 567);
            this.Controls.Add(this.GBStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HackerManPic);
            this.Controls.Add(this.Enemy3Pic);
            this.Controls.Add(this.Enemy2Pic);
            this.Controls.Add(this.Enemy1Pic);
            this.Controls.Add(this.Stone5);
            this.Controls.Add(this.Stone4);
            this.Controls.Add(this.Stone3);
            this.Controls.Add(this.Stone2);
            this.Controls.Add(this.Stone1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "HackerMan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.GBStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HackerManPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stone1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Stone1;
        private System.Windows.Forms.PictureBox Stone2;
        private System.Windows.Forms.PictureBox Stone3;
        private System.Windows.Forms.PictureBox Stone4;
        private System.Windows.Forms.PictureBox Stone5;
        private System.Windows.Forms.PictureBox Enemy1Pic;
        private System.Windows.Forms.PictureBox Enemy2Pic;
        private System.Windows.Forms.PictureBox Enemy3Pic;
        private System.Windows.Forms.PictureBox HackerManPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox GBStart;
        private System.Windows.Forms.Button BStart;
    }
}

