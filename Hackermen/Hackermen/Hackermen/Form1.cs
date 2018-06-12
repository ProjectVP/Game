using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackermen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Classes.Block[] blocks = new Classes.Block[30];
        private void button1_Click(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Clear();
            this.groupBox1.Refresh();
            GameInitialization();

        }
        void GameInitialization ()
        {
            LoadBlocks();
        }
        void LoadBlocks()
        {
            Classes.Block top = new Classes.Block(660, 20, new Point(20, 20));
            Classes.Block bottom = new Classes.Block(660, 20, new Point(20, 480));
            Classes.Block left = new Classes.Block(20, 480, new Point(20, 20));
            Classes.Block right = new Classes.Block(20, 480, new Point(660, 20));
            Classes.Block b1 = new Classes.Block(440, 10, new Point(80, 80));
            Classes.Block b2 = new Classes.Block(40, 60, new Point(570, 80));
            Classes.Block b3 = new Classes.Block(230, 10, new Point(80, 130));
            Classes.Block b4 = new Classes.Block(90, 10, new Point(370, 130));
            Classes.Block b5 = new Classes.Block(10, 200, new Point(510, 80));
            Classes.Block b6 = new Classes.Block(100, 10, new Point(510, 190));
            Classes.Block b7 = new Classes.Block(10, 120, new Point(80, 130));
            Classes.Block b8 = new Classes.Block(10, 140, new Point(80, 300));
            Classes.Block b9 = new Classes.Block(10, 150, new Point(130, 180));
            Classes.Block b10 = new Classes.Block(480, 10, new Point(130, 330));
            Classes.Block b11 = new Classes.Block(10, 140, new Point(600, 190));
            Classes.Block b12 = new Classes.Block(10, 50, new Point(180, 130));
            Classes.Block b13 = new Classes.Block(10, 100, new Point(230, 130));
            Classes.Block b14 = new Classes.Block(200, 10, new Point(180, 230));
            Classes.Block b15 = new Classes.Block(250, 10, new Point(130, 280));
            Classes.Block b16 = new Classes.Block(130, 10, new Point(430, 280));
            Classes.Block b17 = new Classes.Block(180, 10, new Point(280, 180));
            Classes.Block b18 = new Classes.Block(100, 10, new Point(80, 380));
            Classes.Block b19 = new Classes.Block(10, 100, new Point(300, 330));
            Classes.Block b20 = new Classes.Block(10, 100, new Point(400, 330));
            Classes.Block b21 = new Classes.Block(530, 10, new Point(80, 430));
            Classes.Block b22 = new Classes.Block(10, 40, new Point(600, 390));
            Classes.Block b23 = new Classes.Block(10, 50, new Point(520, 330));
            Classes.Block b24 = new Classes.Block(10, 40, new Point(460, 390));









            blocks[0] = top;
            blocks[1] = bottom;
            blocks[2] = left;
            blocks[3] = right;
            blocks[4] = b1;
            blocks[5] = b2;
            blocks[6] = b3;
            blocks[7] = b4;
            blocks[8] = b5;
            blocks[9] = b6;
            blocks[10] = b7;
            blocks[11] = b8;
            blocks[12] = b9;
            blocks[13] = b10;
            blocks[14] = b11;
            blocks[15] = b12;
            blocks[16] = b13;
            blocks[17] = b14;
            blocks[18] = b15;
            blocks[19] = b16;
            blocks[20] = b17;
            blocks[21] = b18;
            blocks[22] = b19;
            blocks[23] = b20;
            blocks[24] = b21;
            blocks[25] = b22;
            blocks[26] = b23;
            blocks[27] = b24;

            this.groupBox1.Controls.AddRange(blocks);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
