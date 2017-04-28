namespace Submittal_Admin_Tool
{
    partial class LogicalAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogicalAdd));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.isDataSheet = new System.Windows.Forms.CheckBox();
            this.statApprovalRequired = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tradeMECH = new System.Windows.Forms.RadioButton();
            this.tradeELV = new System.Windows.Forms.RadioButton();
            this.partNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.partNoLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseDataSheetFile = new System.Windows.Forms.Button();
            this.thirdParty = new System.Windows.Forms.TextBox();
            this.thirdPartyFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.browseThirdPartyFile = new System.Windows.Forms.Button();
            this.ahjApprovalNo = new System.Windows.Forms.TextBox();
            this.ahjFileLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.browseAHJFile = new System.Windows.Forms.Button();
            this.ajhApprovalDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.durationDigit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.durationSelect = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.coverFileLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.browseCoverFile = new System.Windows.Forms.Button();
            this.countryOfOrigin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDatasheet = new System.Windows.Forms.OpenFileDialog();
            this.openFileThirdParty = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.isDataSheet);
            this.groupBox1.Controls.Add(this.statApprovalRequired);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STATUTORY APPROVAL / DATASHEET";
            // 
            // isDataSheet
            // 
            this.isDataSheet.AutoCheck = false;
            this.isDataSheet.AutoSize = true;
            this.isDataSheet.Checked = true;
            this.isDataSheet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDataSheet.Cursor = System.Windows.Forms.Cursors.No;
            this.isDataSheet.Location = new System.Drawing.Point(240, 34);
            this.isDataSheet.Name = "isDataSheet";
            this.isDataSheet.Size = new System.Drawing.Size(123, 17);
            this.isDataSheet.TabIndex = 1;
            this.isDataSheet.Text = "IS A DATASHEET ?";
            this.isDataSheet.UseVisualStyleBackColor = true;
            // 
            // statApprovalRequired
            // 
            this.statApprovalRequired.AutoCheck = false;
            this.statApprovalRequired.AutoSize = true;
            this.statApprovalRequired.Checked = true;
            this.statApprovalRequired.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statApprovalRequired.Cursor = System.Windows.Forms.Cursors.No;
            this.statApprovalRequired.Location = new System.Drawing.Point(6, 34);
            this.statApprovalRequired.Name = "statApprovalRequired";
            this.statApprovalRequired.Size = new System.Drawing.Size(228, 17);
            this.statApprovalRequired.TabIndex = 1;
            this.statApprovalRequired.Text = "SATUTATORY APPROVAL REQUIRED ?";
            this.statApprovalRequired.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tradeMECH);
            this.groupBox2.Controls.Add(this.tradeELV);
            this.groupBox2.Location = new System.Drawing.Point(471, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TRADE";
            // 
            // tradeMECH
            // 
            this.tradeMECH.AutoSize = true;
            this.tradeMECH.Location = new System.Drawing.Point(147, 35);
            this.tradeMECH.Name = "tradeMECH";
            this.tradeMECH.Size = new System.Drawing.Size(141, 17);
            this.tradeMECH.TabIndex = 1;
            this.tradeMECH.TabStop = true;
            this.tradeMECH.Text = "MECHANICAL SYSTEM";
            this.tradeMECH.UseVisualStyleBackColor = true;
            // 
            // tradeELV
            // 
            this.tradeELV.AutoSize = true;
            this.tradeELV.Location = new System.Drawing.Point(16, 35);
            this.tradeELV.Name = "tradeELV";
            this.tradeELV.Size = new System.Drawing.Size(92, 17);
            this.tradeELV.TabIndex = 0;
            this.tradeELV.TabStop = true;
            this.tradeELV.Text = "ELV SYSTEM";
            this.tradeELV.UseVisualStyleBackColor = true;
            // 
            // partNo
            // 
            this.partNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.partNo.Location = new System.Drawing.Point(32, 150);
            this.partNo.Name = "partNo";
            this.partNo.Size = new System.Drawing.Size(126, 20);
            this.partNo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PART NUMBER";
            // 
            // partNoLocation
            // 
            this.partNoLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.partNoLocation.Location = new System.Drawing.Point(32, 189);
            this.partNoLocation.Name = "partNoLocation";
            this.partNoLocation.ReadOnly = true;
            this.partNoLocation.Size = new System.Drawing.Size(126, 20);
            this.partNoLocation.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATASHEET FILE";
            // 
            // browseDataSheetFile
            // 
            this.browseDataSheetFile.Location = new System.Drawing.Point(176, 189);
            this.browseDataSheetFile.Name = "browseDataSheetFile";
            this.browseDataSheetFile.Size = new System.Drawing.Size(75, 20);
            this.browseDataSheetFile.TabIndex = 7;
            this.browseDataSheetFile.Text = "Browse";
            this.browseDataSheetFile.UseVisualStyleBackColor = true;
            this.browseDataSheetFile.Click += new System.EventHandler(this.browseDataSheetFile_Click);
            // 
            // thirdParty
            // 
            this.thirdParty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.thirdParty.Location = new System.Drawing.Point(269, 150);
            this.thirdParty.Name = "thirdParty";
            this.thirdParty.Size = new System.Drawing.Size(149, 20);
            this.thirdParty.TabIndex = 9;
            // 
            // thirdPartyFile
            // 
            this.thirdPartyFile.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.thirdPartyFile.Location = new System.Drawing.Point(269, 189);
            this.thirdPartyFile.Name = "thirdPartyFile";
            this.thirdPartyFile.ReadOnly = true;
            this.thirdPartyFile.Size = new System.Drawing.Size(149, 20);
            this.thirdPartyFile.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "THIRD PARTY LISTING / NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "THIRD PARTY FILE";
            // 
            // browseThirdPartyFile
            // 
            this.browseThirdPartyFile.Location = new System.Drawing.Point(425, 189);
            this.browseThirdPartyFile.Name = "browseThirdPartyFile";
            this.browseThirdPartyFile.Size = new System.Drawing.Size(75, 20);
            this.browseThirdPartyFile.TabIndex = 12;
            this.browseThirdPartyFile.Text = "Browse";
            this.browseThirdPartyFile.UseVisualStyleBackColor = true;
            this.browseThirdPartyFile.Click += new System.EventHandler(this.browseThirdPartyFile_Click);
            // 
            // ahjApprovalNo
            // 
            this.ahjApprovalNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ahjApprovalNo.Location = new System.Drawing.Point(517, 150);
            this.ahjApprovalNo.Name = "ahjApprovalNo";
            this.ahjApprovalNo.Size = new System.Drawing.Size(149, 20);
            this.ahjApprovalNo.TabIndex = 14;
            // 
            // ahjFileLocation
            // 
            this.ahjFileLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ahjFileLocation.Location = new System.Drawing.Point(517, 189);
            this.ahjFileLocation.Name = "ahjFileLocation";
            this.ahjFileLocation.ReadOnly = true;
            this.ahjFileLocation.Size = new System.Drawing.Size(149, 20);
            this.ahjFileLocation.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "AHJ APPROVAL NUMBER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "AHJ File";
            // 
            // browseAHJFile
            // 
            this.browseAHJFile.Location = new System.Drawing.Point(673, 189);
            this.browseAHJFile.Name = "browseAHJFile";
            this.browseAHJFile.Size = new System.Drawing.Size(75, 20);
            this.browseAHJFile.TabIndex = 19;
            this.browseAHJFile.Text = "Browse";
            this.browseAHJFile.UseVisualStyleBackColor = true;
            // 
            // ajhApprovalDate
            // 
            this.ajhApprovalDate.CustomFormat = "yyyy-mm-dd";
            this.ajhApprovalDate.Location = new System.Drawing.Point(673, 150);
            this.ajhApprovalDate.Name = "ajhApprovalDate";
            this.ajhApprovalDate.Size = new System.Drawing.Size(193, 20);
            this.ajhApprovalDate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "APPROVAL DATE";
            // 
            // durationDigit
            // 
            this.durationDigit.Location = new System.Drawing.Point(757, 189);
            this.durationDigit.MaxLength = 2;
            this.durationDigit.Name = "durationDigit";
            this.durationDigit.Size = new System.Drawing.Size(48, 20);
            this.durationDigit.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(754, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "VALIDITY DURATION";
            // 
            // durationSelect
            // 
            this.durationSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "DAYS",
            "MONTHS",
            "YEARS"});
            this.durationSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.durationSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.durationSelect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.durationSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.durationSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.durationSelect.Items.AddRange(new object[] {
            "DAYS",
            "MONTHS",
            "YEARS"});
            this.durationSelect.Location = new System.Drawing.Point(811, 189);
            this.durationSelect.Name = "durationSelect";
            this.durationSelect.Size = new System.Drawing.Size(73, 21);
            this.durationSelect.Sorted = true;
            this.durationSelect.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(27, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(891, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DOCUMENT MAPING";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.countryOfOrigin);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.coverFileLocation);
            this.groupBox4.Controls.Add(this.browseCoverFile);
            this.groupBox4.Location = new System.Drawing.Point(27, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(891, 112);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DESCRIPTION / COO / ETC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "DESCRPTION";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(5, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 36);
            this.textBox1.TabIndex = 1;
            // 
            // coverFileLocation
            // 
            this.coverFileLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.coverFileLocation.Location = new System.Drawing.Point(210, 60);
            this.coverFileLocation.Name = "coverFileLocation";
            this.coverFileLocation.ReadOnly = true;
            this.coverFileLocation.Size = new System.Drawing.Size(126, 20);
            this.coverFileLocation.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "COVER FILE";
            // 
            // browseCoverFile
            // 
            this.browseCoverFile.Location = new System.Drawing.Point(354, 60);
            this.browseCoverFile.Name = "browseCoverFile";
            this.browseCoverFile.Size = new System.Drawing.Size(75, 20);
            this.browseCoverFile.TabIndex = 4;
            this.browseCoverFile.Text = "Browse";
            this.browseCoverFile.UseVisualStyleBackColor = true;
            // 
            // countryOfOrigin
            // 
            this.countryOfOrigin.Location = new System.Drawing.Point(460, 59);
            this.countryOfOrigin.Name = "countryOfOrigin";
            this.countryOfOrigin.Size = new System.Drawing.Size(195, 20);
            this.countryOfOrigin.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "COUNTRY OF ORIGIN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 416);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(891, 205);
            this.dataGridView1.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "DOCUMENT ADDED TODAY";
            // 
            // openFileDatasheet
            // 
            this.openFileDatasheet.AddExtension = false;
            this.openFileDatasheet.DefaultExt = "pdf";
            this.openFileDatasheet.FileName = "openFileDatasheet";
            this.openFileDatasheet.Filter = "(*.pdf)|*.pdf";
            this.openFileDatasheet.InitialDirectory = "C:\\";
            this.openFileDatasheet.Title = "FIND DATASHEET";
            // 
            // openFileThirdParty
            // 
            this.openFileThirdParty.DefaultExt = "pdf";
            this.openFileThirdParty.FileName = "openFileThirdParty";
            this.openFileThirdParty.Filter = "(*.pdf)|*.pdf";
            this.openFileThirdParty.InitialDirectory = "C:\\";
            this.openFileThirdParty.Title = "FIND THIRD PARTY TEST CERTIFICATE";
            // 
            // LogicalAdd
            // 
            this.AccessibleName = "LogicalAdd";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 643);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.durationDigit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.durationSelect);
            this.Controls.Add(this.ajhApprovalDate);
            this.Controls.Add(this.browseAHJFile);
            this.Controls.Add(this.browseThirdPartyFile);
            this.Controls.Add(this.browseDataSheetFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ahjFileLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thirdPartyFile);
            this.Controls.Add(this.ahjApprovalNo);
            this.Controls.Add(this.partNoLocation);
            this.Controls.Add(this.thirdParty);
            this.Controls.Add(this.partNo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogicalAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Part Numbers , AHJ and Third Party Documents";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox isDataSheet;
        private System.Windows.Forms.CheckBox statApprovalRequired;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton tradeMECH;
        private System.Windows.Forms.RadioButton tradeELV;
        private System.Windows.Forms.TextBox partNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partNoLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseDataSheetFile;
        private System.Windows.Forms.TextBox thirdParty;
        private System.Windows.Forms.TextBox thirdPartyFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseThirdPartyFile;
        private System.Windows.Forms.TextBox ahjApprovalNo;
        private System.Windows.Forms.TextBox ahjFileLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button browseAHJFile;
        private System.Windows.Forms.DateTimePicker ajhApprovalDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox durationDigit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox durationSelect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox coverFileLocation;
        private System.Windows.Forms.Button browseCoverFile;
        private System.Windows.Forms.TextBox countryOfOrigin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDatasheet;
        private System.Windows.Forms.OpenFileDialog openFileThirdParty;
    }
}