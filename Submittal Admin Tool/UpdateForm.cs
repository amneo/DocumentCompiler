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
    public partial class UpdateForm : Form
    {

        Data_connection dbobject = new Data_connection();
        SQLiteConnection SQLconnect = new SQLiteConnection();
        public UpdateForm()
        {
            InitializeComponent();
        }

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
            yearselect.SelectedIndex = 0;
        }

        private void cddselect_Click(object sender, EventArgs e)
        {
            if (cddvalue.Text == "")
            {
                string mynewquery = string.Format("select partno,url,cdd,ul,tittle,cddissue,cddno,duration,expirydt from simplex");
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
                string mynewquery = string.Format("select partno,url,cdd,ul,tittle,cddissue,cddno,duration,expirydt from simplex where cddno = \'{0}\'", cddvalue.Text);
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


        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            if (newcddno.Text != "")
            {
                string mynewquery = string.Format("update simplex set cddno = \"{0}\" , cddissue =\"{1}\" ,duration = \"{2}\" where cddno= \'{3}\'", newcddno.Text, issuedate.Text, yearselect.Text, cddvalue.Text);
                //MessageBox.Show(mynewquery);
                SQLiteCommand cmd = new SQLiteCommand(mynewquery, SQLconnect);
                cmd.ExecuteNonQuery();
                cddvalue.Text = newcddno.Text;
                cddselect_Click(sender, e);
                newcddno.Text = "";
            }
            else
            {
                MessageBox.Show("New CDD Document Number not provided");

            }


        }

        private void UpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLconnect.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.Dispose();
        }
    }
}
