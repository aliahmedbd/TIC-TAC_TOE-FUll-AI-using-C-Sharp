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
    public partial class Secondary : Form
    {
        public string first,second;

        public Secondary()
        {
            InitializeComponent();
        }

        private void Secondary_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Value.First = txtpl1.Text;
            Value.Second = txtpl2.Text;

            
       
               
                TwoPlayers ob = new TwoPlayers();
                ob.Show();
                this.Hide();
            
        }
    }
}
