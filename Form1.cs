using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_14___Tic_Tac_Toe_Game_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int playCount = 0;


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Pen whitePen = new Pen(Color.White, 10);
            
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(whitePen, 400, 300, 1050, 300); 
            e.Graphics.DrawLine(whitePen, 400, 460, 1050, 460); 
                                                               
            e.Graphics.DrawLine(whitePen, 610, 140, 610, 620); 
            e.Graphics.DrawLine(whitePen, 840, 140, 840, 620); 
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            lbl_Players.Text = "Player 1";
            lbl_Winner.Text = "In Progress";
            playCount = 0;

            pictureBox1.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox2.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox3.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox4.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox5.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox6.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox7.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox8.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");
            pictureBox9.Image = Image.FromFile(@"D:\Random Fotos\question mark.png");

            pictureBoxsBackColorsBlack();
            pictureBoxsTags();
        }

        private void pictureBoxsEnabledFalse()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
        }

        private void pictureBoxsBackColorsBlack()
        {
            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            pictureBox7.BackColor = Color.Black;
            pictureBox8.BackColor = Color.Black;
            pictureBox9.BackColor = Color.Black; 
        }
        private void pictureBoxsTags()
        {
            pictureBox1.Tag = "-";
            pictureBox2.Tag = "-";
            pictureBox3.Tag = "-";
            pictureBox4.Tag = "-";
            pictureBox5.Tag = "-";
            pictureBox6.Tag = "-";
            pictureBox7.Tag = "-";
            pictureBox8.Tag = "-";
            pictureBox9.Tag = "-";
        }

        public void ChangeImage(PictureBox pb)
        {
            pb.Enabled = false;

            if (lbl_Players.Text == "Player 1")
            {
                lbl_Players.Text = "Player 2";
                pb.Image = Image.FromFile(@"D:\Random Fotos\X.png");
                pb.Tag = "X";
            }
            else
            {
                lbl_Players.Text = "Player 1";
                pb.Image = Image.FromFile(@"D:\Random Fotos\O.png");
                pb.Tag = "O";
            }
            playCount++;
            WinnerStatus();
        }

        public bool CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if ((pb1.Tag == pb2.Tag && (pb2.Tag == pb3.Tag)) && pb1.Tag.ToString() != "-")
            {
                lbl_Players.Text = "Game Over";
                if (pb1.Tag.ToString() == "X")
                    lbl_Winner.Text = "Player 1";
                else
                    lbl_Winner.Text = "Player 2";

                pb1.BackColor = Color.Green;
                pb2.BackColor = Color.Green;
                pb3.BackColor = Color.Green;

                pictureBoxsEnabledFalse();
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }

        private void WinnerStatus()
        {
            if (CheckValues(pictureBox1, pictureBox2, pictureBox3))
                return;

            if (CheckValues(pictureBox4, pictureBox5, pictureBox6))
                return;

            if (CheckValues(pictureBox7, pictureBox8, pictureBox9))
                return;

            if (CheckValues(pictureBox1, pictureBox4, pictureBox7))
                return;

            if (CheckValues(pictureBox2, pictureBox5, pictureBox8))
                return;

            if (CheckValues(pictureBox3, pictureBox6, pictureBox9))
                return;

            if (CheckValues(pictureBox1, pictureBox5, pictureBox9))
                return;

            if (CheckValues(pictureBox3, pictureBox5, pictureBox7))
                return;

            if (playCount == 9)
            {
                lbl_Players.Text = "Game Over";
                lbl_Winner.Text = "Draw";
                MessageBox.Show("Draw", "Game Over", MessageBoxButtons.OK);
            }
        }
    }
}
