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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        public static bool tf = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (tf)
            {
                case false:
                    tf = true; textBox2.PasswordChar = '\0';
                    break;
                case true:
                    tf = false; textBox2.PasswordChar = '*';
                    break;

            }
               

        }

        private void sign_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=WIN-8B7JOVS4DVJ\SQLEXPRESS;Initial Catalog=Testing;Integrated Security=True";
            //строка подключения к твоей БД
           
            MyDataClassDataContext db = new MyDataClassDataContext(conn);//подключение к БД            
            Table inst = (from X in db.Table
                          where X.Login.Contains("b")
                          select X).Single<Table>();
            //запрос в таблицу данных - по уникальному признаку, в данном случае
            //где поле desr содержит в себе "88"
            inst.descr = "Changes were here"; //изменения интересующего тебя поля
            db.SubmitChanges();//опять же сохранение изменений в базе.

        }
    }
}
