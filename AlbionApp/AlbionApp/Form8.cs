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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            MyDataBase.Connect("mydatabaseforalbion.db");
            MyDataBase.AddHistoryTable(GetTable.data, "History");
            dataGridView1.DataSource = GetTable.data;
            dataGridView1.Columns[0].HeaderText = "Название";
            dataGridView1.Columns[1].HeaderText = "Количество";
            dataGridView1.Columns[2].HeaderText = "Доход";
            dataGridView1.Columns[3].HeaderText = "Расход";
            dataGridView1.Columns[4].HeaderText = "Чистый доход";
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Point StripPosition = Cursor.Position;
            contextMenuStrip1.Show(StripPosition);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Name"].Value);
                int cellValue1 = Convert.ToInt32(selectedRow.Cells["Ammount"].Value);
                int cellValue2 = Convert.ToInt32(selectedRow.Cells["Profit"].Value);
                int cellValue3 = Convert.ToInt32(selectedRow.Cells["Subsidence"].Value);
                int cellValue4 = Convert.ToInt32(selectedRow.Cells["Net_profit"].Value);
                ControlID.TextData = cellValue;
                ControlID.IntData1 = cellValue1;
                ControlID.IntData2 = cellValue2;
                ControlID.IntData3 = cellValue3;
                ControlID.IntData4 = cellValue4;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = ControlID.TextData;
            int ammount = ControlID.IntData1;
            int profit = ControlID.IntData2;
            int subsidence = ControlID.IntData3;
            int net_profit = ControlID.IntData4;
            MyDataBase.DeleteHistory(name, ammount, profit, subsidence, net_profit);
            MyDataBase.Connect("mydatabaseforalbion.db");
            MyDataBase.AddHistoryTable(GetTable.data, "History");
            dataGridView1.DataSource = GetTable.data;
            dataGridView1.ClearSelection();
        }
    }
}
