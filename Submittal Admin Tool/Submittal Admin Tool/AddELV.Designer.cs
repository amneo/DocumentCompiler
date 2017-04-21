namespace Submittal_Admin_Tool
{
    partial class AddELV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddELV));
            this._elv_submDataSet = new Submittal_Admin_Tool._elv_submDataSet();
            this.simplexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simplexTableAdapter = new Submittal_Admin_Tool._elv_submDataSetTableAdapters.simplexTableAdapter();
            this.tableAdapterManager = new Submittal_Admin_Tool._elv_submDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this._elv_submDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplexBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _elv_submDataSet
            // 
            this._elv_submDataSet.DataSetName = "_elv_submDataSet";
            this._elv_submDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simplexBindingSource
            // 
            this.simplexBindingSource.DataMember = "simplex";
            this.simplexBindingSource.DataSource = this._elv_submDataSet;
            // 
            // simplexTableAdapter
            // 
            this.simplexTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.simplexTableAdapter = this.simplexTableAdapter;
            this.tableAdapterManager.UpdateOrder = Submittal_Admin_Tool._elv_submDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddELV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(925, 508);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddELV";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELV Add Data";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddELV_FormClosed);
            this.Load += new System.EventHandler(this.AddELV_Load);
            ((System.ComponentModel.ISupportInitialize)(this._elv_submDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simplexBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _elv_submDataSet _elv_submDataSet;
        private System.Windows.Forms.BindingSource simplexBindingSource;
        private _elv_submDataSetTableAdapters.simplexTableAdapter simplexTableAdapter;
        private _elv_submDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}