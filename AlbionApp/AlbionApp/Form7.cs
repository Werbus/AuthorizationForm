using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionApp
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            MyDataBase.Connect("mydatabaseforalbion.db");
            MyDataBase.GetSum(GetTable.data);
            dataGridView1.DataSource = GetTable.data;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Name"].Value);
                int cellValue1 = Convert.ToInt32(selectedRow.Cells["Tier"].Value);
                int cellValue2 = Convert.ToInt32(selectedRow.Cells["Cost"].Value);
                int cellValue3 = Convert.ToInt32(selectedRow.Cells["CraftCost"].Value);
                int cellValue4 = Convert.ToInt32(selectedRow.Cells["Recipe"].Value);
                ControlID.TextData = cellValue;
                ControlID.IntData1 = cellValue1;
                ControlID.IntData2 = cellValue2;
                ControlID.IntData3 = cellValue3;
                ControlID.IntData4 = cellValue4;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form6 getammount = new Form6();
           if(getammount.ShowDialog() == DialogResult.OK)
            {
                int getsum = ControlID.IntData6 * ControlID.IntData2;
                int getsum1 = ControlID.IntData6 * ControlID.IntData4 + ControlID.IntData6 * ControlID.IntData3;
                label4.Text = ControlID.TextData + " T" + Convert.ToString(ControlID.IntData1);
                label7.Text = Convert.ToString(ControlID.IntData6);               
                label5.Text = Convert.ToString(getsum);               
                label6.Text = Convert.ToString(getsum1);
                label10.Text = Convert.ToString(getsum - getsum1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(label4.Text == "" || label7.Text == "" || label5.Text == "" || label6.Text == "" || label10.Text == "")
            {
                MessageBox.Show("Объект не выбран");
                return;
            }
            string name = label4.Text;
            int ammount = int.Parse(label7.Text);
            int profit = int.Parse(label5.Text);
            int subsidence = int.Parse(label6.Text);
            int net_profit = int.Parse(label10.Text);
            MyDataBase.AddHistory(name, ammount, profit, subsidence, net_profit);
            MessageBox.Show("Запись сохранена");
            label4.Text = "";
            label7.Text = "";
            label5.Text = "";
            label6.Text = "";
            label10.Text = "";
        }
    }
}
