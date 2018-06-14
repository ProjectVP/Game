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
            this.HackerManPic = new System.Windows.Forms.PictureBox();
            this.Enemy3Pic = new System.Windows.Forms.PictureBox();
            this.Enemy2Pic = new System.Windows.Forms.PictureBox();
            this.Enemy1Pic = new System.Windows.Forms.PictureBox();
            this.Stone5 = new System.Windows.Forms.PictureBox();
            this.Stone4 = new System.Windows.Forms.PictureBox();
            this.Stone3 = new System.Windows.Forms.PictureBox();
            this.Stone2 = new System.Windows.Forms.PictureBox();
            this.Stone1 = new System.Windows.Forms.PictureBox();
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
            this.label1.Location = new System.Drawing.Point(2, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HackerManPic
            // 
            this.HackerManPic.Image = ((System.Drawing.Image)(resources.GetObject("HackerManPic.Image")));
            this.HackerManPic.Location = new System.Drawing.Point(12, 12);
            this.HackerManPic.Name = "HackerManPic";
            this.HackerManPic.Size = new System.Drawing.Size(45, 52);
            this.HackerManPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HackerManPic.TabIndex = 13;
            this.HackerManPic.TabStop = false;
            // 
            // Enemy3Pic
            // 
            this.Enemy3Pic.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3Pic.Image")));
            this.Enemy3Pic.Location = new System.Drawing.Point(412, 70);
            this.Enemy3Pic.Name = "Enemy3Pic";
            this.Enemy3Pic.Size = new System.Drawing.Size(35, 54);
            this.Enemy3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy3Pic.TabIndex = 11;
            this.Enemy3Pic.TabStop = false;
            // 
            // Enemy2Pic
            // 
            this.Enemy2Pic.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2Pic.Image")));
            this.Enemy2Pic.Location = new System.Drawing.Point(300, 336);
            this.Enemy2Pic.Name = "Enemy2Pic";
            this.Enemy2Pic.Size = new System.Drawing.Size(35, 54);
            this.Enemy2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy2Pic.TabIndex = 10;
            this.Enemy2Pic.TabStop = false;
            // 
            // Enemy1Pic
            // 
            this.Enemy1Pic.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1Pic.Image")));
            this.Enemy1Pic.Location = new System.Drawing.Point(184, 61);
            this.Enemy1Pic.Name = "Enemy1Pic";
            this.Enemy1Pic.Size = new System.Drawing.Size(35, 53);
            this.Enemy1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy1Pic.TabIndex = 9;
            this.Enemy1Pic.TabStop = false;
            // 
            // Stone5
            // 
            this.Stone5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stone5.Image = ((System.Drawing.Image)(resources.GetObject("Stone5.Image")));
            this.Stone5.Location = new System.Drawing.Point(540, -1);
            this.Stone5.Name = "Stone5";
            this.Stone5.Size = new System.Drawing.Size(15, 327);
            this.Stone5.TabIndex = 8;
            this.Stone5.TabStop = false;
            this.Stone5.Tag = "wall";
            // 
            // Stone4
            // 
            this.Stone4.Image = ((System.Drawing.Image)(resources.GetObject("Stone4.Image")));
            this.Stone4.Location = new System.Drawing.Point(421, 136);
            this.Stone4.Name = "Stone4";
            this.Stone4.Size = new System.Drawing.Size(15, 313);
            this.Stone4.TabIndex = 7;
            this.Stone4.TabStop = false;
            this.Stone4.Tag = "wall";
            // 
            // Stone3
            // 
            this.Stone3.Image = ((System.Drawing.Image)(resources.GetObject("Stone3.Image")));
            this.Stone3.Location = new System.Drawing.Point(311, 0);
            this.Stone3.Name = "Stone3";
            this.Stone3.Size = new System.Drawing.Size(15, 326);
            this.Stone3.TabIndex = 6;
            this.Stone3.TabStop = false;
            this.Stone3.Tag = "wall";
            // 
            // Stone2
            // 
            this.Stone2.Image = ((System.Drawing.Image)(resources.GetObject("Stone2.Image")));
            this.Stone2.Location = new System.Drawing.Point(194, 120);
            this.Stone2.Name = "Stone2";
            this.Stone2.Size = new System.Drawing.Size(15, 341);
            this.Stone2.TabIndex = 5;
            this.Stone2.TabStop = false;
            this.Stone2.Tag = "wall";
            // 
            // Stone1
            // 
            this.Stone1.Image = ((System.Drawing.Image)(resources.GetObject("Stone1.Image")));
            this.Stone1.Location = new System.Drawing.Point(94, 0);
            this.Stone1.Name = "Stone1";
            this.Stone1.Size = new System.Drawing.Size(15, 341);
            this.Stone1.TabIndex = 0;
            this.Stone1.TabStop = false;
            this.Stone1.Tag = "wall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
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
            this.Name = "Form1";
            this.Text = "HackerMan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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
    }
}

