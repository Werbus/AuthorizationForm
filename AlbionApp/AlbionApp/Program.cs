using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public static class ControlID
    {
        public static string GetTableName { get; set; }
        public static int GetPastTier { get; set; }
        public static string GetPastName { get; set; }
        public static string TextData { get; set; }
        public static string TextData1 { get; set; }
        public static int IntData1 { get; set; }
        public static int IntData2 { get; set; }
        public static int IntData3 { get; set; }
        public static int IntData4 { get; set; }
        public static int IntData5 { get; set; }
        public static int IntData6 { get; set; }
    }
    public static class GetTable
    {
        public static DataTable data { get; set; }
    }
    public static class GetLocation
    {
        public static int Location_X { get; set; }
        public static int Location_Y { get; set; }
    }
    public class ItemParams
    {
        public string  parname;
        public int partier;
        public int parcost;
        public int parammount;
        public ItemParams(string parname, int partier, int parcost, int parammount)
        {
            this.parname = parname;
            this.partier = partier;
            this.parcost = parcost;
            this.parammount = parammount;
        }
    }
}
