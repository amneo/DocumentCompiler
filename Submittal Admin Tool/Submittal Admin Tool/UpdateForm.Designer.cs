namespace Submittal_Admin_Tool
{
    partial class UpdateFormELV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFormELV));
            this.partno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newcddno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Selection = new System.Windows.Forms.GroupBox();
            this.cddselect = new System.Windows.Forms.Button();
            this.durationSelect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.issuedate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseButtonTp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.approvalFileTp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.thirdPartyNo = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.approvalFile = new System.Windows.Forms.TextBox();
            this.durationDigit = new System.Windows.Forms.TextBox();
            this.DatabaseDisplay = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Selection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // partno
            // 
            this.partno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.partno.Location = new System.Drawing.Point(12, 32);
            this.partno.Name = "partno";
            this.partno.Size = new System.Drawing.Size(127, 20);
            this.partno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PART NUMBER";
            // 
            // newcddno
            // 
            this.newcddno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.newcddno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcddno.Location = new System.Drawing.Point(10, 32);
            this.newcddno.Name = "newcddno";
            this.newcddno.Size = new System.Drawing.Size(163, 20);
            this.newcddno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "AHJ NEW APPROVAL NUMBER";
            // 
            // Selection
            // 
            this.Selection.Controls.Add(this.cddselect);
            this.Selection.Controls.Add(this.partno);
            this.Selection.Controls.Add(this.label1);
            this.Selection.Location = new System.Drawing.Point(12, 13);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(171, 154);
            this.Selection.TabIndex = 0;
            this.Selection.TabStop = false;
            this.Selection.Text = "SELECTION";
            // 
            // cddselect
            // 
            this.cddselect.Location = new System.Drawing.Point(12, 81);
            this.cddselect.Name = "cddselect";
            this.cddselect.Size = new System.Drawing.Size(127, 23);
            this.cddselect.TabIndex = 2;
            this.cddselect.Text = "SELECT";
            this.cddselect.UseVisualStyleBackColor = true;
            this.cddselect.Click += new System.EventHandler(this.Cddselect_Click);
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
            this.durationSelect.Location = new System.Drawing.Point(359, 32);
            this.durationSelect.Name = "durationSelect";
            this.durationSelect.Size = new System.Drawing.Size(73, 21);
            this.durationSelect.Sorted = true;
            this.durationSelect.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "VALIDITY DURATION";
            // 
            // issuedate
            // 
            this.issuedate.CustomFormat = "yyyy-MM-dd";
            this.issuedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.issuedate.Location = new System.Drawing.Point(184, 32);
            this.issuedate.Name = "issuedate";
            this.issuedate.Size = new System.Drawing.Size(106, 20);
            this.issuedate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ISSUE DATE";
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(551, 81);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(134, 23);
            this.updatebutton.TabIndex = 16;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.browseButtonTp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.approvalFileTp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.thirdPartyNo);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.approvalFile);
            this.groupBox1.Controls.Add(this.durationDigit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.updatebutton);
            this.groupBox1.Controls.Add(this.issuedate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newcddno);
            this.groupBox1.Controls.Add(this.durationSelect);
            this.groupBox1.Location = new System.Drawing.Point(222, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE";
            // 
            // browseButtonTp
            // 
            this.browseButtonTp.Location = new System.Drawing.Point(330, 81);
            this.browseButtonTp.Name = "browseButtonTp";
            this.browseButtonTp.Size = new System.Drawing.Size(75, 23);
            this.browseButtonTp.TabIndex = 15;
            this.browseButtonTp.Text = "Browse";
            this.browseButtonTp.UseVisualStyleBackColor = true;
            this.browseButtonTp.Click += new System.EventHandler(this.browseButtonTp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "THIRD PARTY APPROVAL FILE";
            // 
            // approvalFileTp
            // 
            this.approvalFileTp.Location = new System.Drawing.Point(184, 82);
            this.approvalFileTp.Name = "approvalFileTp";
            this.approvalFileTp.ReadOnly = true;
            this.approvalFileTp.ShortcutsEnabled = false;
            this.approvalFileTp.Size = new System.Drawing.Size(140, 20);
            this.approvalFileTp.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "THIRD PARTY LISTING / NO";
            // 
            // thirdPartyNo
            // 
            this.thirdPartyNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.thirdPartyNo.Location = new System.Drawing.Point(10, 82);
            this.thirdPartyNo.Name = "thirdPartyNo";
            this.thirdPartyNo.Size = new System.Drawing.Size(163, 20);
            this.thirdPartyNo.TabIndex = 12;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(610, 31);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "APPROVAL FILE";
            // 
            // approvalFile
            // 
            this.approvalFile.Location = new System.Drawing.Point(456, 32);
            this.approvalFile.Name = "approvalFile";
            this.approvalFile.ReadOnly = true;
            this.approvalFile.ShortcutsEnabled = false;
            this.approvalFile.Size = new System.Drawing.Size(148, 20);
            this.approvalFile.TabIndex = 9;
            // 
            // durationDigit
            // 
            this.durationDigit.Location = new System.Drawing.Point(305, 32);
            this.durationDigit.MaxLength = 2;
            this.durationDigit.Name = "durationDigit";
            this.durationDigit.Size = new System.Drawing.Size(48, 20);
            this.durationDigit.TabIndex = 5;
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.AutoSize = true;
            this.DatabaseDisplay.Location = new System.Drawing.Point(9, 185);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(112, 13);
            this.DatabaseDisplay.TabIndex = 0;
            this.DatabaseDisplay.Text = "DATABASE DISPLAY";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(901, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "pdf";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PDF Files (.pdf)|*.pdf";
            this.openFileDialog1.InitialDirectory = "c:";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // UpdateFormELV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(925, 508);
            this.Controls.Add(this.DatabaseDisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFormELV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.Selection.ResumeLayout(false);
            this.Selection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newcddno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Selection;
        private System.Windows.Forms.Button cddselect;
        private System.Windows.Forms.ComboBox durationSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker issuedate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DatabaseDisplay;
        private System.Windows.Forms.TextBox durationDigit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox approvalFile;
        private System.Windows.Forms.Button browseButton;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox thirdPartyNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox approvalFileTp;
        private System.Windows.Forms.Button browseButtonTp;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}