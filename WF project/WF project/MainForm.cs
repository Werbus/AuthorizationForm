using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MyDataBase.Connect();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Зарегистрируйте несколько пользователей");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorize authorize = new Authorize();
            authorize.ShowDialog();
            if(DataControl.Turn == false)
                this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            if (DataControl.Turn == false)
                this.Show();
        }
    }
    public static class DataControl
    {
        public static bool Turn;
        public static bool Check;
        public static DataTable data;
        public static string thisLogin;
    }
}
