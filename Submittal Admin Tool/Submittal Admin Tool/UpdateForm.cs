using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Submittal_Admin_Tool
{

    public partial class UpdateFormELV : Form
    {
        private string approvalFileDestination, approvalFileDestinationTp; //CDD file name variable
        private DateTime myFileDate = DateTime.Now; // Attributes to be updated.
        Data_connection dbobject = new Data_connection();
        SQLiteConnection SQLconnect = new SQLiteConnection();
        public UpdateFormELV()
        {
            InitializeComponent();
        }

        /// On Load function
        /// Check if the SQLite database is assesable and connected.
        private void UpdateForm_Load(object sender, EventArgs e)
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
                    //partno.Text = dataGridView1.G;
                }
                else
                {
                    MessageBox.Show("No Data Exist in Table");
                }

            }


        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (newcddno.Text != "" && thirdPartyNo.Text != "" && approvalFile.Text != "" && approvalFileTp.Text != "" && durationDigit.Text != "")
            {
                string mynewquery = string.Format("update simplex set cddno = \"{0}\" , cddissue =\"{1}\" ,duration = \"{2}\" , cdd = \"{0}\" , ul = \"{4}\"  where partno='{3}\'", newcddno.Text.Trim(), issuedate.Text.Trim(), durationDigit.Text.Trim() + " " + durationSelect.Text.Trim(), partno.Text.Trim(), thirdPartyNo.Text.Trim() + "-UL");
                //MessageBox.Show(mynewquery);
                SQLiteCommand cmd = new SQLiteCommand(mynewquery, SQLconnect);
                cmd.ExecuteNonQuery();
                partno.Text = partno.Text;  //Not required since updating with part numbers
                Cddselect_Click(sender, e);
                File.Copy(approvalFile.Text, approvalFileDestination, true);
                File.Copy(approvalFileTp.Text, approvalFileDestinationTp, true);
                File.SetLastWriteTime(approvalFileDestination, myFileDate);  // This is to ensure that the files are touched (Linux) and have latest write date set on them
                File.SetLastWriteTime(approvalFileDestinationTp, myFileDate); // This is to ensure that the files are touched (Linux) and have latest write date set on them
                //ensuring all fields are null again
                approvalFile.Text = approvalFileTp.Text = thirdPartyNo.Text = newcddno.Text = durationDigit.Text = "";
            }
            else
            {
                MessageBox.Show("All Fields are mandatory");

            }


        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // properties to be checked and code removed might be hogging memory
            openFileDialog1.InitialDirectory = @"C:\"; // properties to be checked and code removed might be hogging memory
            openFileDialog1.Title = "Browse Approval PDF Files"; // properties to be checked and code removed might be hogging memory
            openFileDialog1.CheckFileExists = true; // properties to be checked and code removed might be hogging memory
            openFileDialog1.CheckPathExists = true; // properties to be checked and code removed might be hogging memory
            openFileDialog1.DefaultExt = "pdf"; // properties to be checked and code removed might be hogging memory
            openFileDialog1.Filter = "PDF File (*.pdf)|*.pdf"; // properties to be checked and code removed might be hogging memory
            openFileDialog1.FilterIndex = 1; // properties to be checked and code removed might be hogging memory
            openFileDialog1.RestoreDirectory = true; // properties to be checked and code removed might be hogging memory
            openFileDialog1.ReadOnlyChecked = true; // properties to be checked and code removed might be hogging memory
            openFileDialog1.ShowReadOnly = false; // properties to be checked and code removed might be hogging memory
            openFileDialog1.Multiselect = false; // properties to be checked and code removed might be hogging memory
            openFileDialog1.ShowDialog();
            approvalFile.Text = openFileDialog1.FileName;
            approvalFileDestination = "X:\\ELV-Subs\\facpsimplex\\CDD\\" + newcddno.Text + ".pdf";
          //  MessageBox.Show(approvalFileDestination); //enabling for debuging
          //  MessageBox.Show("The Date is " + myFileDate);
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
            OpenFileDialog openFileDialog2 = new OpenFileDialog(); // properties to be checked and code removed might be hogging memory
            openFileDialog2.InitialDirectory = @"C:\"; // properties to be checked and code removed might be hogging memory
            openFileDialog2.Title = "Browse Third Party PDF Files"; // properties to be checked and code removed might be hogging memory
            openFileDialog2.CheckFileExists = true; // properties to be checked and code removed might be hogging memory
            openFileDialog2.CheckPathExists = true; // properties to be checked and code removed might be hogging memory
            openFileDialog2.DefaultExt = "pdf"; // properties to be checked and code removed might be hogging memory
            openFileDialog2.Filter = "PDF File (*.pdf)|*.pdf"; // properties to be checked and code removed might be hogging memory
            openFileDialog2.FilterIndex = 1; // properties to be checked and code removed might be hogging memory
            openFileDialog2.RestoreDirectory = true; // properties to be checked and code removed might be hogging memory
            openFileDialog2.ReadOnlyChecked = false; // properties to be checked and code removed might be hogging memory
            openFileDialog2.ShowReadOnly = true; // properties to be checked and code removed might be hogging memory
            openFileDialog2.Multiselect = false; // properties to be checked and code removed might be hogging memory
            openFileDialog2.ShowDialog();
            approvalFileTp.Text = openFileDialog2.FileName;
            approvalFileDestinationTp = "X:\\ELV-Subs\\facpsimplex\\UL\\" + thirdPartyNo.Text + "-UL" + ".pdf"; //destination file name is thirdparty listing text
           // MessageBox.Show(approvalFileDestinationTp); //enabling for debuging
        }
    }
}
