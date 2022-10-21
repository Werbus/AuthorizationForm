using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WF_project
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
            MyDataBase.Connect();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            string login = DataControl.thisLogin;
            label2.Text = login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDataBase.TakeData();
            dataGridView1.DataSource = DataControl.data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            DataControl.thisLogin = null;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Point position = Cursor.Position;
            contextMenuStrip1.Show(position);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int cellValue = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string cellValue2 = Convert.ToString(selectedRow.Cells["Username"].Value);
            string cellValue3 = Convert.ToString(selectedRow.Cells["Password"].Value);
            if (cellValue2 == label2.Text)
            {
                Hide();
                DataControl.thisLogin = null;
                MessageBox.Show("Вы удалили текущего пользователя");
                Close();
            }
            MyDataBase.deleteData(cellValue, cellValue2, cellValue3);
            dataGridView1.DataSource = DataControl.data;
        }
    }
}
