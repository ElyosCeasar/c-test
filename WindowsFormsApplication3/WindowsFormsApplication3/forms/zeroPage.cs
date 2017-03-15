using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.forms
{
    public partial class zeroPage : Form
    {

        public zeroPage()
        {
            InitializeComponent();

        }

        private void zeroPage_Load(object sender, EventArgs e)
        {
        }



        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
           
      page1 temp = new page1();
            this.Hide();
            temp.Show();
            temp.MaximizeBox = false;
            temp.Location = this.Location;
            temp.FormBorderStyle = FormBorderStyle.FixedDialog;
            temp.Width = this.Width;
            temp.Height = this.Height;
           
      

        }

    }
}
