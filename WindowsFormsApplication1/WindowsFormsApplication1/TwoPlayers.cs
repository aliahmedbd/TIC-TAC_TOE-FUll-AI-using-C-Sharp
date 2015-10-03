using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TwoPlayers : Form
    {
        public int count = 0;
        public int a=10, b=10, c=10, d=10, e1=10, f=10, g=10, h=10, i=10;
        public int p1 = 0, p2 = 0;
        int draw = 0;
        public TwoPlayers()
        {
            InitializeComponent();
            label1.Text = Value.First;
            label2.Text = Value.Second;
            label3.Text = "0";
            label4.Text = "0";

        }

        private void TwoPlayers_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn1.Text = "×";
                a = 1;
                draw++;
            }
            else
            {
                btn1.Text = "0";
                a = 0;
                draw++;
            }
            
            check();

        }

      
        private void btn2_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn2.Text = "×";
                b = 1; draw++;
            }
            else
            {
                btn2.Text = "0";
                b = 0; draw++;
            }
            check();
        }

        private void reset_click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn3.Text = "×";
                c = 1; draw++;
            }
            else
            {
                btn3.Text = "0";
                c = 0; draw++;
            }
            check();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn4.Text = "×";
                d = 1; draw++;
            }
            else
            {
                btn4.Text = "0";
                d = 0; draw++;
            }
            check();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn5.Text = "×";
                e1 = 1; draw++;

            }
            else
            {
                btn5.Text = "0";
                e1 = 0; draw++;


            }
            check();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn6.Text = "×";
                f = 1; draw++;
            }
            else
            {
                btn6.Text = "0";
                f = 0; draw++;
            }
            check();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn7.Text = "×";
                g = 1; draw++;
            }
            else
            {
                btn7.Text = "0";
                g = 0; draw++;
            }
            check();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn8.Text = "×";
                h = 1; draw++;
            }
            else
            {
                btn8.Text = "0";
                h = 0; draw++;
            }
            check();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                btn9.Text = "×";
                i = 1; draw++;
            }
            else
            {
                btn9.Text = "0";
                i = 0;draw++;
            }
            check();
        }
        void check()
        {
            if (a==1 && b==1 && c==1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10;
                draw = 0;
            }
            else if(a == 0 && b == 0 && c == 0)
            {
                
                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10;
                draw = 0;

            }
            else if (d == 0 && e1 == 0 && f == 0)
            {

                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10;
                draw = 0;

            }
            else if (d == 1 && e1 == 1 && f == 1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10;
                draw = 0;
            }
            else if (g == 0 && h == 0 && i == 0)
            {

                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10;
                draw = 0;
            }
            else if (g == 1 && h == 1 && i == 1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;
            }

            //horizontal

            if (a == 1 && d == 1 && g == 1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;
            }
            else if (a == 0 && d == 0 && g == 0)
            {

                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;

            }
            else if (b == 0 && e1 == 0 && h == 0)
            {

                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;

            }
            else if (b == 1 && e1 == 1 && h == 1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;
            }
            else if (e1 == 0 && f == 0 && i == 0)
            {

                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;

            }
            else if (e1 == 1 && f == 1 && i == 1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;
            }

            //diagonal
            else if (a== 0 && e1 == 0 && i == 0)
            {

                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;

            }
            else if (a == 1 && e1 == 1 && i == 1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;
            }
            else if (c == 0 && e1 == 0 && g == 0)
            {

                MessageBox.Show(Value.First + " win the game.");
                p1++;
                label3.Text = p1.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;

            }
            else if (c == 1 && e1 == 1 && g == 1)
            {
                MessageBox.Show(Value.Second + " win the game.");
                p2++;
                label4.Text = p2.ToString();
                btnPlay.Show();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10; draw = 0;
            }
            else if(draw==9){
                draw = 0;
                MessageBox.Show("Game is Draw!!!");
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
                a = b = c = d = e1 = f = g = h = i = 10;
               
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            a = b = c = d = e1 = f = g = h = i = 10;

        }

    }
}
