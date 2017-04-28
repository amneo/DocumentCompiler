using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Submittal_Admin_Tool
{
    public partial class MainWindow : Form
    {

        Data_connection dbobject = new Data_connection();
        SQLiteConnection SQLconnect = new SQLiteConnection();
    
        public MainWindow()
        {

            InitializeComponent();

        }

        private void MainWindow_Load(object sender, EventArgs e)
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

        private void eLVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form m = new UpdateFormELV();
            m.MdiParent = this;
            m.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLconnect.Close();
            this.Close();
        }

        private void eLVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           // Form m = new AddELV();
            //m.MdiParent = this;
           // m.Show();
           
        }

        private void mECHToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            Form m = new UpdateMech();
//            m.MdiParent = this;
//            m.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form m = new UpdateFormELV();
            m.MdiParent = this;
            m.Show();
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form m = new UpdateFormELV();
            m.MdiParent = this;
            m.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          Form m = new LogicalAdd();
          m.MdiParent = this;
          m.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form m = new AboutBox1();
            m.MdiParent = this;
            m.Show();
        }
    }
}
