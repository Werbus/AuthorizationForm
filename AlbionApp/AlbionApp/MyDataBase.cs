using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace AlbionApp
{

    internal class MyDataBase
    {
        static SQLiteConnection connection;
        static SQLiteCommand command;


        static public bool Connect(string fileName)
        {
            try
            {
                connection = new SQLiteConnection("Data Source=" + fileName + ";Version=3; FailIfMissing=False");
                connection.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка доступа к базе данных. Исключение: {ex.Message}");
                return false;
            }
        }
        static public void CreateTable(string createcommand)
        {
            command = new SQLiteCommand(connection)
            {
                CommandText = createcommand
            };
            command.ExecuteNonQuery();
        }
        static public void AddItem(string getname, int gettier, int getcost)
        {
            command = new SQLiteCommand(connection)
            {
                CommandText = "INSERT INTO Items (Name, Tier, Cost) VALUES (:name, :tier, :cost)"
            };
            command.Parameters.AddWithValue("name", getname);
            command.Parameters.AddWithValue("tier", gettier);
            command.Parameters.AddWithValue("cost", getcost);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(connection)
            {
                CommandText = "INSERT INTO AllItems (Name, Tier, Cost) VALUES (:name, :tier, :cost)"
            };
            command.Parameters.AddWithValue("name", getname);
            command.Parameters.AddWithValue("tier", gettier);
            command.Parameters.AddWithValue("cost", getcost);
            command.ExecuteNonQuery();
        }
        static public void AddCraft(string _getname, int _gettier, int _getcost, int _getcraftcost, int _recipe)
        {
            command = new SQLiteCommand(connection)
            {
                CommandText = "INSERT INTO Crafts (Name, Tier, Cost, CraftCost, Recipe) VALUES (:_name, :_tier, :_cost, :_craftcost, :_recipe)"
            };
            command.Parameters.AddWithValue("_name", _getname);
            command.Parameters.AddWithValue("_tier", _gettier);
            command.Parameters.AddWithValue("_cost", _getcost);
            command.Parameters.AddWithValue("_craftcost", _getcraftcost);
            command.Parameters.AddWithValue("_recipe", _recipe);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(connection)
            {
                CommandText = "INSERT INTO AllItems (Name, Tier, Cost) VALUES (:_name, :_tier, :_cost)"
            };
            command.Parameters.AddWithValue("_name", _getname);
            command.Parameters.AddWithValue("_tier", _gettier);
            command.Parameters.AddWithValue("_cost", _getcost);
            command.ExecuteNonQuery();
        }
        static public void AddItemTable(DataTable data, string table)
        {
            command.CommandText = "SELECT Name, Tier, Cost FROM " + table;
            data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);
            GetTable.data = data;
        }
        static public void AddItemTableWithID(DataTable data, string table)
        {
            command.CommandText = "SELECT ID, Name, Tier, Cost FROM " + table;
            data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);
            GetTable.data = data;
        }
        static public void AddCraftTable(DataTable data, string table)
        {
            command.CommandText = "SELECT Name, Tier, Cost, CraftCost FROM " + table;
            data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);
            GetTable.data = data;
        }
        static public void DeleteItemCommand(DataTable data, string getname, int gettier)
        {
            command = new SQLiteCommand(connection)
            {
                CommandText = "DELETE FROM Items WHERE (Name = :getname) AND (Tier = :gettier)"
            };
            command.Parameters.AddWithValue("getname", getname);
            command.Parameters.AddWithValue("gettier", gettier);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(connection)
            {
                CommandText = "DELETE FROM AllItems WHERE (Name = :getname) AND (Tier = :gettier)"
            };
            command.Parameters.AddWithValue("getname", getname);
            command.Parameters.AddWithValue("gettier", gettier);
            command.ExecuteNonQuery();
        }
        static public void DeleteCraftCommand(DataTable data, string getname, int gettier)
        {
            command = new SQLiteCommand(connection)
            {
                CommandText = "DELETE FROM Crafts WHERE (Name = :getname) AND (Tier = :gettier)"
            };
            command.Parameters.AddWithValue("getname", getname);
            command.Parameters.AddWithValue("gettier", gettier);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(connection)
            {
                CommandText = "DELETE FROM AllItems WHERE (Name = :getname) AND (Tier = :gettier)"
            };
            command.Parameters.AddWithValue("getname", getname);
            command.Parameters.AddWithValue("gettier", gettier);
            command.ExecuteNonQuery();
        }
        static public void ChangeItemCommand(string pastname, int pasttier, string getname, int gettier, int getcost)
        {
            command = new SQLiteCommand(connection)
            {
                CommandText = "UPDATE Items SET (Name, Tier, Cost) = (:name, :tier, :cost) WHERE Name = :_pastname AND Tier = :_pasttier"
            };
            command.Parameters.AddWithValue("_pasttier", pasttier);
            command.Parameters.AddWithValue("_pastname", pastname);
            command.Parameters.AddWithValue("name", getname);
            command.Parameters.AddWithValue("tier", gettier);
            command.Parameters.AddWithValue("cost", getcost);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(connection)
            {
                CommandText = "UPDATE AllItems SET (Name, Tier, Cost) = (:name, :tier, :cost) WHERE Name = :_pastname AND Tier = :_pasttier"
            };
            command.Parameters.AddWithValue("_pasttier", pasttier);
            command.Parameters.AddWithValue("_pastname", pastname);
            command.Parameters.AddWithValue("name", getname);
            command.Parameters.AddWithValue("tier", gettier);
            command.Parameters.AddWithValue("cost", getcost);
            command.ExecuteNonQuery();
        }
        static public void ChangeCraftCommand(string pastname, int pasttier, string getname, int gettier, int getcost, int craftcost, int recipe)
        {
            command = new SQLiteCommand(connection)
            {
                CommandText = "UPDATE Crafts SET (Name, Tier, Cost, CraftCost, Recipe) = (:name, :tier, :cost, :craftcost, :recipe) WHERE Name = :_pastname AND Tier = :_pasttier"
            };
            command.Parameters.AddWithValue("_pastname", pastname);
            command.Parameters.AddWithValue("_pasttier", pasttier);
            command.Parameters.AddWithValue("name", getname);
            command.Parameters.AddWithValue("tier", gettier);
            command.Parameters.AddWithValue("cost", getcost);
            command.Parameters.AddWithValue("craftcost", craftcost);
            command.Parameters.AddWithValue("recipe", recipe);
            command.ExecuteNonQuery();
            command = new SQLiteCommand(connection)
            {
                CommandText = "UPDATE AllItems SET (Name, Tier, Cost) = (:name, :tier, :cost) WHERE Name = :_pastname AND Tier = :_pasttier"
            };
            command.Parameters.AddWithValue("_pasttier", pasttier);
            command.Parameters.AddWithValue("_pastname", pastname);
            command.Parameters.AddWithValue("name", getname);
            command.Parameters.AddWithValue("tier", gettier);
            command.Parameters.AddWithValue("cost", getcost);
            command.ExecuteNonQuery();
        }
        static public void GetSum(DataTable data)
        {
            command.CommandText = "SELECT Name, Tier, Cost, CraftCost, Recipe FROM Crafts";
            data = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            adapter.Fill(data);
            GetTable.data = data;
        }
    }
}
