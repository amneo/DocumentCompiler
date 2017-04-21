using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Submittal_Admin_Tool
{

    public partial class UpdateFormELV : Form
    {
        private string approvalFileDestination , approvalFileDestinationTp;
        Data_connection dbobject = new Data_connection();
        SQLiteConnection SQLconnect = new SQLiteConnection();
        public UpdateFormELV()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_elv_submDataSet.simplex' table. You can move, or remove it, as needed.
            // this.simplexTableAdapter.Fill(this._elv_submDataSet.simplex);
            // string approvalFileDestination = null;
         
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
            durationSelect.SelectedIndex = 0;
        }

        private void Cddselect_Click(object sender, EventArgs e)
        {
            if (partno.Text == "")
            {
                string mynewquery = string.Format("SELECT systrade, partno,  cdd, ul,  tittle, cddissue, cddno, duration, expirydt,coo,url,isdatasheet FROM simplex");
               //MessageBox.Show(mynewquery);
                SQLiteCommand cmd = new SQLiteCommand(mynewquery, SQLconnect);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Exist in Table");
                }

            }
            else
            {
                string mynewquery = string.Format("SELECT systrade, partno,  cdd, ul,  tittle, cddissue, cddno, duration, expirydt,coo,url,isdatasheet FROM simplex where partno = \'{0}\'", partno.Text);
              //  MessageBox.Show(mynewquery);
                SQLiteCommand cmd = new SQLiteCommand(mynewquery, SQLconnect);
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Data Exist in Table");
                }

            }


        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
           if (newcddno.Text != ""  && thirdPartyNo.Text != "" && approvalFile.Text != "" && approvalFileTp.Text != "" && durationDigit.Text != "" )
            {
                string mynewquery = string.Format("update simplex set cddno = \"{0}\" , cddissue =\"{1}\" ,duration = \"{2}\" , cdd = \"{0}\" , ul = \"{4}\"  where partno='{3}\'", newcddno.Text, issuedate.Text, durationDigit.Text + " "+ durationSelect.Text, partno.Text, thirdPartyNo.Text + "-UL");
                //MessageBox.Show(mynewquery);
                SQLiteCommand cmd = new SQLiteCommand(mynewquery, SQLconnect);
                cmd.ExecuteNonQuery();
                partno.Text = partno.Text;  //Not required since updating with part numbers
                Cddselect_Click(sender, e);
                File.Copy(approvalFile.Text, approvalFileDestination,true);
                File.Copy(approvalFileTp.Text, approvalFileDestinationTp, true);
                //ensuring all fields are null again
                approvalFile.Text = approvalFileTp.Text = thirdPartyNo.Text = newcddno.Text = durationDigit.Text = "" ;
            }
            else
            {
                MessageBox.Show("All Fields are mandatory");

            }


        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Approval PDF Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "pdf";
            openFileDialog1.Filter = "PDF File (*.pdf)|*.pdf";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
            approvalFile.Text = openFileDialog1.FileName;
            approvalFileDestination = "X:\\ELV-Subs\\facpsimplex\\CDD\\" + newcddno.Text + ".pdf";
            MessageBox.Show(approvalFileDestination); //enabling for debuging
        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLconnect.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }

        private void browseButtonTp_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = @"C:\";
            openFileDialog2.Title = "Browse Third Party PDF Files";
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.CheckPathExists = true;
            openFileDialog2.DefaultExt = "pdf";
            openFileDialog2.Filter = "PDF File (*.pdf)|*.pdf";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.ReadOnlyChecked = true;
            openFileDialog2.ShowReadOnly = true;
            openFileDialog2.Multiselect = false;
            openFileDialog2.ShowDialog();
            approvalFileTp.Text = openFileDialog2.FileName;
            approvalFileDestinationTp = "X:\\ELV-Subs\\facpsimplex\\UL\\" + thirdPartyNo.Text + "-UL" + ".pdf";
            MessageBox.Show(approvalFileDestinationTp); //enabling for debuging
        }
    }
}
