using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submittal_Admin_Tool
{
    public partial class LogicalAdd : Form
    {
        public LogicalAdd()
        {
            InitializeComponent();
        }

        private void browseDataSheetFile_Click(object sender, EventArgs e)
        {
            openFileDatasheet.ShowDialog();
            partNoLocation.Text = openFileDatasheet.FileName;
            //MessageBox.Show("The File is in location" + partNoLocation.Text);
        }

        private void browseThirdPartyFile_Click(object sender, EventArgs e)
        {
            openFileThirdParty.ShowDialog();
            thirdPartyFile.Text = openFileThirdParty.FileName;
              
        }
    }
}
