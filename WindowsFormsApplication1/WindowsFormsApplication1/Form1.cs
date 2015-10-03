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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            Secondary ob1 = new Secondary();
            ob1.Show();
            
            
            
        }

        private void btnOnePlayer_Click(object sender, EventArgs e)
        {
            OnePlayer ob2 = new OnePlayer();
            ob2.Show();
        }
    }
}
