﻿using System;
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
        static public string name;
        public Form2()
        {
            InitializeComponent();
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && log1.Text!="" && pass1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else if(checkBox1.Checked == false)
            {
                MessageBox.Show("You have to agree with our rules");
            }
            else 
            {
                MessageBox.Show("You have to write your Login, Password, Phone number and Name");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
