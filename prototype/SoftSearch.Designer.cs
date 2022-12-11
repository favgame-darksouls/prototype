
namespace prototype
{
    partial class SoftSearch
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sql1804215DataSet = new prototype.sql1804215DataSet();
            this.hARDWAREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hARDWARETableAdapter = new prototype.sql1804215DataSetTableAdapters.HARDWARETableAdapter();
            this.oWNERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSTEMNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSVERSIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mANUFACTURERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql1804215DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARDWAREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oWNERNAMEDataGridViewTextBoxColumn,
            this.wORKERIDDataGridViewTextBoxColumn,
            this.mODELDataGridViewTextBoxColumn,
            this.nOTEDataGridViewTextBoxColumn,
            this.sYSTEMNAMEDataGridViewTextBoxColumn,
            this.iPADDRESSDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.oSVERSIONDataGridViewTextBoxColumn,
            this.mANUFACTURERDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hARDWAREBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(470, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "View all Software Info";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(727, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Local Software Info";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // sql1804215DataSet
            // 
            this.sql1804215DataSet.DataSetName = "sql1804215DataSet";
            this.sql1804215DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hARDWAREBindingSource
            // 
            this.hARDWAREBindingSource.DataMember = "HARDWARE";
            this.hARDWAREBindingSource.DataSource = this.sql1804215DataSet;
            // 
            // hARDWARETableAdapter
            // 
            this.hARDWARETableAdapter.ClearBeforeFill = true;
            // 
            // oWNERNAMEDataGridViewTextBoxColumn
            // 
            this.oWNERNAMEDataGridViewTextBoxColumn.DataPropertyName = "OWNER_NAME";
            this.oWNERNAMEDataGridViewTextBoxColumn.HeaderText = "OWNER_NAME";
            this.oWNERNAMEDataGridViewTextBoxColumn.Name = "oWNERNAMEDataGridViewTextBoxColumn";
            // 
            // wORKERIDDataGridViewTextBoxColumn
            // 
            this.wORKERIDDataGridViewTextBoxColumn.DataPropertyName = "WORKER_ID";
            this.wORKERIDDataGridViewTextBoxColumn.HeaderText = "WORKER_ID";
            this.wORKERIDDataGridViewTextBoxColumn.Name = "wORKERIDDataGridViewTextBoxColumn";
            // 
            // mODELDataGridViewTextBoxColumn
            // 
            this.mODELDataGridViewTextBoxColumn.DataPropertyName = "MODEL";
            this.mODELDataGridViewTextBoxColumn.HeaderText = "MODEL";
            this.mODELDataGridViewTextBoxColumn.Name = "mODELDataGridViewTextBoxColumn";
            // 
            // nOTEDataGridViewTextBoxColumn
            // 
            this.nOTEDataGridViewTextBoxColumn.DataPropertyName = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.HeaderText = "NOTE";
            this.nOTEDataGridViewTextBoxColumn.Name = "nOTEDataGridViewTextBoxColumn";
            // 
            // sYSTEMNAMEDataGridViewTextBoxColumn
            // 
            this.sYSTEMNAMEDataGridViewTextBoxColumn.DataPropertyName = "SYSTEM_NAME";
            this.sYSTEMNAMEDataGridViewTextBoxColumn.HeaderText = "SYSTEM_NAME";
            this.sYSTEMNAMEDataGridViewTextBoxColumn.Name = "sYSTEMNAMEDataGridViewTextBoxColumn";
            // 
            // iPADDRESSDataGridViewTextBoxColumn
            // 
            this.iPADDRESSDataGridViewTextBoxColumn.DataPropertyName = "IP_ADDRESS";
            this.iPADDRESSDataGridViewTextBoxColumn.HeaderText = "IP_ADDRESS";
            this.iPADDRESSDataGridViewTextBoxColumn.Name = "iPADDRESSDataGridViewTextBoxColumn";
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            // 
            // oSVERSIONDataGridViewTextBoxColumn
            // 
            this.oSVERSIONDataGridViewTextBoxColumn.DataPropertyName = "OS_VERSION";
            this.oSVERSIONDataGridViewTextBoxColumn.HeaderText = "OS_VERSION";
            this.oSVERSIONDataGridViewTextBoxColumn.Name = "oSVERSIONDataGridViewTextBoxColumn";
            // 
            // mANUFACTURERDataGridViewTextBoxColumn
            // 
            this.mANUFACTURERDataGridViewTextBoxColumn.DataPropertyName = "MANUFACTURER";
            this.mANUFACTURERDataGridViewTextBoxColumn.HeaderText = "MANUFACTURER";
            this.mANUFACTURERDataGridViewTextBoxColumn.Name = "mANUFACTURERDataGridViewTextBoxColumn";
            // 
            // SoftSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 560);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SoftSearch";
            this.Text = "SoftSearch";
            this.Load += new System.EventHandler(this.SoftSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql1804215DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hARDWAREBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private sql1804215DataSet sql1804215DataSet;
        private System.Windows.Forms.BindingSource hARDWAREBindingSource;
        private sql1804215DataSetTableAdapters.HARDWARETableAdapter hARDWARETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oWNERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sYSTEMNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSVERSIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANUFACTURERDataGridViewTextBoxColumn;
    }
}