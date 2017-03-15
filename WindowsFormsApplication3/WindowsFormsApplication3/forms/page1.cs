using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.forms
{
    public partial class page1 : Form
    {
        public page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterPage temp = new RegisterPage();
            this.Hide();
            temp.Show();
            temp.MaximizeBox = false;
            temp.Location = this.Location;
            temp.FormBorderStyle = FormBorderStyle.FixedDialog;
            temp.Width = this.Width;
            temp.Height = this.Height;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterPage temp=new EnterPage();
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
