using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignORReg
{
    
    public partial class Form2 : Form
    {
        public Form2(string a)
        {
            InitializeComponent();
            a = textBox2.Text;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
                MessageBox.Show("You have to agree with our rules");
        }
      
    }
}
