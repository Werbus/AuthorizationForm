using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace AlbionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyDataBase.Connect("mydatabaseforalbion.db");
            MyDataBase.CreateTable("CREATE TABLE IF NOT EXISTS [Items]([ID] INTEGER PRIMARY KEY NOT NULL, [Name] STRING, [Tier] INT, [Cost] INT);");
            MyDataBase.CreateTable("CREATE TABLE IF NOT EXISTS [AllItems]([ID] INTEGER PRIMARY KEY NOT NULL, [Name] STRING, [Tier] INT, [Cost] INT);");
            MyDataBase.CreateTable("CREATE TABLE IF NOT EXISTS [Crafts]([ID] INTEGER PRIMARY KEY NOT NULL, [Name] STRING, [Tier] INT, [Cost] INT, [CraftCost] INT, [Recipe] STRING);");
            MyDataBase.CreateTable("CREATE TABLE IF NOT EXISTS [History]([ID] INTEGER PRIMARY KEY NOT NULL, [Name] STRING, [Ammount] INT, [Profit] INT, [Subsidence] INT, [Net_profit] INT);");

            MyDataBase.AddItemTable(GetTable.data, "Items");
            dataGridView1.DataSource = GetTable.data;
            ControlID.GetTableName = "Items";
            dataGridView1.ClearSelection();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void предметToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addItemForm toAdd = new addItemForm();
            if(toAdd.ShowDialog() == DialogResult.OK)
            {
                string getname = ControlID.TextData;
                int gettier = ControlID.IntData1;
                int getcost = ControlID.IntData2;
                MyDataBase.AddItem(getname, gettier, getcost);               
                if(ControlID.GetTableName == "Items")
                {
                    MyDataBase.AddItemTable(GetTable.data, "Items");
                    dataGridView1.DataSource = GetTable.data;
                    ControlID.GetTableName = "Items";
                    dataGridView1.ClearSelection();
                }
            }            
        }
        private void таблицаПредметовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlID.GetTableName = "Items";
            MyDataBase.AddItemTable(GetTable.data, "Items");
            dataGridView1.DataSource = GetTable.data;
            dataGridView1.ClearSelection();
        }

        private void таблицаКрафтовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlID.GetTableName = "Crafts";
            MyDataBase.AddCraftTable(GetTable.data, "Crafts");
            dataGridView1.DataSource = GetTable.data;
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
                if(ControlID.GetTableName == "Items")
                {
                    string cellValue = Convert.ToString(selectedRow.Cells["Name"].Value);
                    int cellValue1 = Convert.ToInt32(selectedRow.Cells["Tier"].Value);
                    int cellValue2 = Convert.ToInt32(selectedRow.Cells["Cost"].Value);
                    ControlID.GetPastName = cellValue;
                    ControlID.GetPastTier = cellValue1;
                    ControlID.TextData = cellValue;
                    ControlID.IntData1 = cellValue1;
                    ControlID.IntData2 = cellValue2;
                }
                if (ControlID.GetTableName == "Crafts")
                {
                    string cellValue = Convert.ToString(selectedRow.Cells["Name"].Value);
                    int cellValue1 = Convert.ToInt32(selectedRow.Cells["Tier"].Value);
                    int cellValue2 = Convert.ToInt32(selectedRow.Cells["Cost"].Value);
                    int cellValue3 = Convert.ToInt32(selectedRow.Cells["CraftCost"].Value);
                    ControlID.GetPastName = cellValue;
                    ControlID.GetPastTier = cellValue1;
                    ControlID.TextData = cellValue;
                    ControlID.IntData1 = cellValue1;
                    ControlID.IntData2 = cellValue2;
                    ControlID.IntData3 = cellValue3;
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControlID.GetTableName == "Items")
            {
                string getname = ControlID.TextData;
                int gettier = ControlID.IntData1;
                MyDataBase.DeleteItemCommand(getname, gettier);
                MyDataBase.AddItemTable(GetTable.data, "Items");
                dataGridView1.DataSource = GetTable.data;
            }
            if (ControlID.GetTableName == "Crafts")
            {
                string getname = ControlID.TextData;
                int gettier = ControlID.IntData1;
                MyDataBase.DeleteCraftCommand(getname, gettier);
                MyDataBase.AddItemTable(GetTable.data, "Crafts");
                dataGridView1.DataSource = GetTable.data;
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ControlID.GetTableName == "Items")
            {
                changeItemForm ToItemChange = new changeItemForm();
                if (ToItemChange.ShowDialog() == DialogResult.OK)
                {
                    string pastname = ControlID.GetPastName;
                    string getname = ControlID.TextData;
                    int gettier = ControlID.IntData1;
                    int getcost = ControlID.IntData2;
                    int pasttier = ControlID.GetPastTier;
                    MyDataBase.ChangeItemCommand(pastname, pasttier, getname, gettier, getcost);
                    MyDataBase.AddItemTable(GetTable.data, "Items");
                    dataGridView1.DataSource = GetTable.data;
                    ControlID.GetTableName = "Items";
                    dataGridView1.ClearSelection();
                }
            }
            if(ControlID.GetTableName == "Crafts")
            {
                Form5 ToCraftChange = new Form5();
                if (ToCraftChange.ShowDialog() == DialogResult.OK)
                {
                    string _pastname = ControlID.GetPastName;
                    string _getname = ControlID.TextData;
                    int _gettier = ControlID.IntData1;
                    int _getcost = ControlID.IntData2;
                    int _getcraftcost = ControlID.IntData3;
                    int _recipe = ControlID.IntData4;
                    int _pasttier = ControlID.GetPastTier;
                    MyDataBase.ChangeCraftCommand(_pastname, _pasttier, _getname, _gettier, _getcost, _getcraftcost, _recipe);
                    MyDataBase.AddCraftTable(GetTable.data, "Crafts");
                    dataGridView1.DataSource = GetTable.data;
                    ControlID.GetTableName = "Crafts";
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void крафтToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 _AddCraft = new Form4();
            if (_AddCraft.ShowDialog() == DialogResult.OK)
            {
                string _getname = ControlID.TextData;
                int _gettier = ControlID.IntData1;
                int _getcost = ControlID.IntData2;
                int _getcraftcost = ControlID.IntData3;
                int _recipe = ControlID.IntData4;
                MyDataBase.AddCraft(_getname, _gettier, _getcost, _getcraftcost, _recipe);
                if(ControlID.GetTableName == "Crafts")
                {
                    MyDataBase.AddCraftTable(GetTable.data, "Crafts");
                    dataGridView1.DataSource = GetTable.data;
                    ControlID.GetTableName = "Crafts";
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void счётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 sum = new Form7();
            sum.ShowDialog();
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 history = new Form8();
            history.ShowDialog();
        }
    }
}
