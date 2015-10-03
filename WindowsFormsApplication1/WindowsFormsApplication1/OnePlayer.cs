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
    public partial class OnePlayer : Form
    {
        bool turn = true;
        int you = 0, computer = 0;
   
        int turn_count = 0;
        public OnePlayer()
        {
            InitializeComponent();
        }

       
        private void button_click(object sender,EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (turn)
                {
                    b.Text = "X";
                }
                else
                    b.Text = "O";
                turn = !turn;
                // b.Enabled = false;
                turn_count++;
                check();
                if (!turn)
                    computer_make_move();
            }
            catch (Exception) { }

        }
        private void computer_make_move()
        {
            Button move = null;
            move = look_for_win_or_block("O");
            if (move == null)
            {
                move = look_for_win_or_block("X");
                if (move == null)
                {
                    move = look_for_corner();
                    if (move == null)
                    {
                        move = look_for_open_space();
                    }
                   
                }
               
            }
          
            try {
                move.PerformClick();
            }catch(NullReferenceException e)
            {
                MessageBox.Show("Match Drawn");
            }
        }
        private Button look_for_win_or_block(string mark)
        {
            Console.WriteLine("");
            //vertical
            if ((btn1.Text == mark) && (btn2.Text == mark) && (btn3.Text == ""))
                return btn3;
            if ((btn1.Text == mark) && (btn2.Text == "") && (btn3.Text == mark))
                return btn2;
            if ((btn1.Text == "") && (btn2.Text == mark) && (btn3.Text == mark))
                return btn1;

            if ((btn4.Text == mark) && (btn5.Text == mark) && (btn6.Text == ""))
                return btn6;
            if ((btn4.Text == mark) && (btn5.Text == "") && (btn6.Text == mark))
                return btn5;
            if ((btn4.Text == "") && (btn5.Text == mark) && (btn6.Text == mark))
                return btn4;

            if ((btn7.Text == mark) && (btn8.Text == mark) && (btn9.Text == ""))
                return btn9;
            if ((btn7.Text == mark) && (btn8.Text == "") && (btn9.Text == mark))
                return btn8;
            if ((btn7.Text == "") && (btn8.Text == mark) && (btn9.Text == mark))
                return btn7;

            //horizontal
            if ((btn1.Text == mark) && (btn4.Text == mark) && (btn7.Text == ""))
                return btn7;
            if ((btn1.Text == mark) && (btn4.Text == "") && (btn7.Text == mark))
                return btn4;
            if ((btn1.Text == "") && (btn4.Text == mark) && (btn7.Text == mark))
                return btn1;

            if ((btn2.Text == mark) && (btn5.Text == mark) && (btn8.Text == ""))
                return btn8;
            if ((btn2.Text == mark) && (btn5.Text == "") && (btn8.Text == mark))
                return btn5;
            if ((btn2.Text == "") && (btn5.Text == mark) && (btn8.Text == mark))
                return btn2;

            if ((btn3.Text == mark) && (btn6.Text == mark) && (btn9.Text == ""))
                return btn9;
            if ((btn3.Text == mark) && (btn6.Text == "") && (btn9.Text == mark))
                return btn6;
            if ((btn3.Text == "") && (btn6.Text == mark) && (btn9.Text == mark))
                return btn3;

            //diagonally

            if ((btn1.Text == mark) && (btn5.Text == mark) && (btn9.Text == ""))
                return btn9;
            if ((btn1.Text == mark) && (btn5.Text == "") && (btn9.Text == mark))
                return btn5;
            if ((btn1.Text == "") && (btn5.Text == mark) && (btn9.Text == mark))
                return btn1;

            if ((btn3.Text == mark) && (btn5.Text == mark) && (btn7.Text == ""))
                return btn7;
            if ((btn3.Text == mark) && (btn5.Text == "") && (btn7.Text == mark))
                return btn5;
            if ((btn3.Text == "") && (btn5.Text == mark) && (btn7.Text == mark))
                return btn3;

            return null;


        }
        private Button look_for_corner()
        {
            Console.WriteLine("");
            if (btn1.Text == "O")
            {
                if (btn3.Text == "")
                    return btn3;
                if (btn7.Text == "")
                    return btn7;
                if (btn9.Text == "")
                    return btn9;
            }
            if (btn3.Text == "O")
            {
                if (btn1.Text == "")
                    return btn1;
                if (btn7.Text == "")
                    return btn7;
                if (btn9.Text == "")
                    return btn9;
            }
            if (btn7.Text == "O")
            {
                if (btn3.Text == "")
                    return btn3;
                if (btn1.Text == "")
                    return btn1;
                if (btn9.Text == "")
                    return btn9;
            }
            if (btn9.Text == "O")
            {
                if (btn3.Text == "")
                    return btn3;
                if (btn7.Text == "")
                    return btn7;
                if (btn1.Text == "")
                    return btn1;
            }
         if(btn3.Text=="")
            {
                return btn3;
            }
            if (btn7.Text == "")
            {
                return btn7;
            }
            if (btn9.Text == "")
            {
                return btn9;
            }
            if (btn1.Text == "")
            {
                return btn1;
            }
            


            return null;
        }
        private Button look_for_open_space()
        {
            Console.WriteLine();
            Button b = null;
            foreach(Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";

        }

        
        void check()
        {
            if (btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
            {
                MessageBox.Show("You win!");
                you++;
                label3.Text = you.ToString();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            }
            else if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
                btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            }
            else if (btn6.Text == "X" && btn4.Text == "X" && btn5.Text == "X")
            {
                MessageBox.Show("You Win!!!");
                you++;
                label3.Text = you.ToString();

            }
            else if (btn6.Text == "O" && btn4.Text == "O" && btn5.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
            }
            else if (btn8.Text == "X" && btn7.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("You Win!!!");
                you++;
                label3.Text = you.ToString();
            }
            else if (btn8.Text == "O" && btn7.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
            }

            else if (btn1.Text == "O" && btn7.Text == "O" && btn4.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
            }
            else if (btn1.Text == "X" && btn7.Text == "X" && btn4.Text == "X")
            {
                MessageBox.Show("You Win!!");
                you++;
                label3.Text = you.ToString();
            }
            else if (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
            }
            else if (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                MessageBox.Show("You Win!!");
                you++;
                label3.Text = you.ToString();
            }
            else if (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("You Win!!");
                you++;
                label3.Text = you.ToString();
            }
            else if (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
            }

            else if (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
            }
            else if (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
            {
                MessageBox.Show("You Win!!");
                you++;
                label3.Text = you.ToString();
            }
            else if (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("You Win!!");
                you++;
                label3.Text = you.ToString();
            }
            else if (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("Computer Win!!!");
                computer++;
                label4.Text = computer.ToString();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
        }

        private void OnePlayer_Load(object sender, EventArgs e)
        {

        }
    }
}
