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
            this.yearselect = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.issuedate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DatabaseDisplay = new System.Windows.Forms.Label();
            this.Selection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // partno
            // 
            this.partno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.partno.Location = new System.Drawing.Point(12, 59);
            this.partno.Name = "partno";
            this.partno.Size = new System.Drawing.Size(127, 20);
            this.partno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PART NUMBER";
            // 
            // newcddno
            // 
            this.newcddno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.newcddno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcddno.Location = new System.Drawing.Point(29, 59);
            this.newcddno.Name = "newcddno";
            this.newcddno.Size = new System.Drawing.Size(121, 20);
            this.newcddno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NEW APPROVAL NUMBER";
            // 
            // Selection
            // 
            this.Selection.Controls.Add(this.cddselect);
            this.Selection.Controls.Add(this.partno);
            this.Selection.Controls.Add(this.label1);
            this.Selection.Location = new System.Drawing.Point(23, 13);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(171, 198);
            this.Selection.TabIndex = 0;
            this.Selection.TabStop = false;
            this.Selection.Text = "SELECTION";
            // 
            // cddselect
            // 
            this.cddselect.Location = new System.Drawing.Point(12, 104);
            this.cddselect.Name = "cddselect";
            this.cddselect.Size = new System.Drawing.Size(127, 23);
            this.cddselect.TabIndex = 2;
            this.cddselect.Text = "SELECT";
            this.cddselect.UseVisualStyleBackColor = true;
            this.cddselect.Click += new System.EventHandler(this.Cddselect_Click);
            // 
            // yearselect
            // 
            this.yearselect.AutoCompleteCustomSource.AddRange(new string[] {
            "1 YEAR",
            "2 YEAR",
            "3 YEAR",
            "4 YEAR"});
            this.yearselect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.yearselect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearselect.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.yearselect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearselect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yearselect.Items.AddRange(new object[] {
            "1 YEAR",
            "2 YEAR",
            "3 YEAR",
            "4 YEAR"});
            this.yearselect.Location = new System.Drawing.Point(252, 55);
            this.yearselect.Name = "yearselect";
            this.yearselect.Size = new System.Drawing.Size(134, 21);
            this.yearselect.Sorted = true;
            this.yearselect.TabIndex = 1;
            this.yearselect.SelectedIndexChanged += new System.EventHandler(this.yearselect_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "VALID FOR YEARS";
            // 
            // issuedate
            // 
            this.issuedate.CustomFormat = "yyyy-MM-dd";
            this.issuedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.issuedate.Location = new System.Drawing.Point(435, 133);
            this.issuedate.Name = "issuedate";
            this.issuedate.Size = new System.Drawing.Size(131, 20);
            this.issuedate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISSUE DATE";
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(252, 117);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(134, 23);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updatebutton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.newcddno);
            this.groupBox1.Controls.Add(this.yearselect);
            this.groupBox1.Location = new System.Drawing.Point(222, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(901, 154);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // DatabaseDisplay
            // 
            this.DatabaseDisplay.AutoSize = true;
            this.DatabaseDisplay.Location = new System.Drawing.Point(20, 310);
            this.DatabaseDisplay.Name = "DatabaseDisplay";
            this.DatabaseDisplay.Size = new System.Drawing.Size(112, 13);
            this.DatabaseDisplay.TabIndex = 0;
            this.DatabaseDisplay.Text = "DATABASE DISPLAY";
            // 
            // UpdateFormELV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(925, 508);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.issuedate);
            this.Controls.Add(this.DatabaseDisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFormELV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update ELV";
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
        private System.Windows.Forms.ComboBox yearselect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker issuedate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DatabaseDisplay;
    }
}