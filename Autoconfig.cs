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
using System.Data;
using System.Data.SqlClient;

namespace Autoconfig
{
    public partial class Autoconfig : Form
    {
        DBAccess dbAccess = new DBAccess();
        public Autoconfig()
        {
            InitializeComponent();
        }

        private void BCreateUpdate_Click(object sender, EventArgs e)
        {
            string path = @"Autoconfig\Autoconfig\bin\Debug\Auto-config.cfg";
            if (!File.Exists(path))
                Console.WriteLine("File Exists.");
            else
                Console.WriteLine("File Does not exist so creating one!.");
            File.Create("Auto-config.cfg");
       

           // StreamWriter conFile = new StreamWriter("C:/Users/Public/Desktop/Auto-config.cfg");
           // Console.WriteLine(File.Exists(conFile) ? "" : "");
           // File.Write("");
           // File.Close();
        }

        private void BImplement_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Autoconfig_Load(object sender, EventArgs e)
        {
          
            this.auto_configTableAdapter.Fill(this._Auto_configDataSet._auto_config);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.auto_configTableAdapter.FillBy(this._Auto_configDataSet._auto_config);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
