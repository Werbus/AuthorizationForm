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
    public partial class Form4 : Form
    {
        List<ItemParams> temp = new List<ItemParams>();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            ControlID.TextData = textBox1.Text;
            ControlID.IntData1 = int.Parse(textBox2.Text);
            ControlID.IntData2 = int.Parse(textBox3.Text);
            ControlID.IntData3 = int.Parse(textBox4.Text);
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                ControlID.IntData4 = ControlID.IntData4 + temp[a].parcost * temp[a].parammount;
                a++;
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MyDataBase.Connect("mydatabaseforalbion.db");
            MyDataBase.AddItemTableWithID(GetTable.data, "AllItems");
            ControlID.TextData = null;
            ControlID.IntData1 = 0;
            ControlID.IntData2 = 0;
            ControlID.IntData3 = 0;
            ControlID.IntData4 = 0;
            dataGridView1.DataSource = GetTable.data;
            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].HeaderText = "Name";
            dataGridView2.Columns[1].HeaderText = "Tier";
            dataGridView2.Columns[2].HeaderText = "Amount";
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
                ControlID.TextData = cellValue;
                ControlID.IntData1 = cellValue1;
                ControlID.IntData2 = cellValue2;
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 getammount = new Form6();
            if (getammount.ShowDialog() == DialogResult.OK && dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[ControlID.IntData5];
                selectedRow.Cells[2].Value = ControlID.IntData3;
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(ControlID.IntData5);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form6 getammount = new Form6();
            if (getammount.ShowDialog() == DialogResult.OK)
            {
                string getparname = ControlID.TextData;
                int getpartier = ControlID.IntData1;
                int getparcost = ControlID.IntData2;
                int getparammount = ControlID.IntData6;
                ItemParams partemp = new ItemParams(getparname, getpartier, getparcost, getparammount);
                temp.Add(partemp);
                dataGridView2.Rows.Add(temp[temp.Count - 1].parname, temp[temp.Count - 1].partier, temp[temp.Count - 1].parammount);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Point StripPosition = Cursor.Position;
            contextMenuStrip1.Show(StripPosition);
            int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
            ControlID.IntData5 = selectedrowindex;
        }
    }
}
