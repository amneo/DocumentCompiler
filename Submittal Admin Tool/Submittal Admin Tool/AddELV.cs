using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Submittal_Admin_Tool
{
    public partial class AddELV : Form
    {

        Data_connection dbobject = new Data_connection();
        SQLiteConnection SQLconnect = new SQLiteConnection();
        private String SQLInsert = "insert into simplex(partno,url,cdd,ul,tittle,cddissue,cddno,duration) values(?,?,?,?,?,?,?,?)";
 /*       private String datapartno = "";
        private String dataurl = "";
        private String datacdd = "";
        private String dataul = "";
        private String datatittle = "";
        private String datacddissue = "";
        private String datacddno = "";
        private String dataduration = "1 YEAR";*/

        public AddELV()
        {
            InitializeComponent();
        }

        private void AddELV_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            SQLiteCommand command = SQLconnect.CreateCommand();
            command.CommandText = SQLInsert;


/*            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    command.Parameters.AddWithValue("partno", row.Cells[0].Value);
                    command.Parameters.AddWithValue("url", row.Cells[1].Value);
                    command.Parameters.AddWithValue("cdd", row.Cells[2].Value);
                    command.Parameters.AddWithValue("ul", row.Cells[3].Value);
                    command.Parameters.AddWithValue("tittle", row.Cells[4].Value);
                    command.Parameters.AddWithValue("cddissue", row.Cells[5].Value);
                    command.Parameters.AddWithValue("cddno", row.Cells[5].Value);
                    command.Parameters.AddWithValue("duration", row.Cells[6].Value);
                    try
                    {
                        command.ExecuteNonQuery();
                        Save.Dispose();
                        }
                    catch (SQLiteException Ex)
                    {
                        MessageBox.Show("We Encountered an error please fix the error as follows \nERROR CODE:SUBERR002 \n\n" + Ex.Message);
                    }
                }
              }
  */          
            SQLconnect.Close();
        }

        private void AddELV_Load(object sender, EventArgs e)
        {
            try
            {
                SQLconnect.ConnectionString = @"DateTimeFormat=ISO8601;DateTimeKind=local;FailIfMissing=True;Data Source=X:\ELV-Subs\elv-subm";
                SQLconnect.Open();
                
            }
            catch (SQLiteException Ex)
            {
                MessageBox.Show("We Encountered an error please fix the error as follows \nERROR CODE:SUBERR001 \n\n" + Ex.Message);
                this.Close();
            }
      
        }
    }
}
