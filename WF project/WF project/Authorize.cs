using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF_project
{
    public partial class Authorize : Form
    {
        public Authorize()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            MyDataBase.logUser(login, password);
            if(DataControl.Check == true)
            {
                Hide();
                DataControl.thisLogin = login;
                UserList userlist = new UserList();
                userlist.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Неверные данные");
                return;
            }
        }
    }
}
