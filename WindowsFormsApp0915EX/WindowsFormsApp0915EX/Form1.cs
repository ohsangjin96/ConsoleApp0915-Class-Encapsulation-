using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp0915EX
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼클릭");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frm == null)
            {
                frm = new Form2();
            }
            
            frm.Show();

            frm = null;
        }
    }
}
