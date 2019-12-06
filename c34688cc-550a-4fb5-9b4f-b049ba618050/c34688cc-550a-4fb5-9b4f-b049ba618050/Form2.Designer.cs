namespace c34688cc_550a_4fb5_9b4f_b049ba618050
{
    partial class Form2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColonnedeComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSourceOfCombo = new System.Windows.Forms.BindingSource(this.components);
            this.aAADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eEEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fFFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new c34688cc_550a_4fb5_9b4f_b049ba618050.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOfCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColonnedeComboBox,
            this.aAADataGridViewTextBoxColumn,
            this.bBBDataGridViewTextBoxColumn,
            this.cCCDataGridViewTextBoxColumn,
            this.dDDDataGridViewTextBoxColumn,
            this.eEEDataGridViewTextBoxColumn,
            this.fFFDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(89, 76);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(655, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellValueChanged);
            // 
            // ColonnedeComboBox
            // 
            this.ColonnedeComboBox.DataSource = this.bindingSourceOfCombo;
            this.ColonnedeComboBox.HeaderText = "ColonnedeComboBox";
            this.ColonnedeComboBox.Name = "ColonnedeComboBox";
            // 
            // aAADataGridViewTextBoxColumn
            // 
            this.aAADataGridViewTextBoxColumn.DataPropertyName = "AAA";
            this.aAADataGridViewTextBoxColumn.HeaderText = "AAA";
            this.aAADataGridViewTextBoxColumn.Name = "aAADataGridViewTextBoxColumn";
            // 
            // bBBDataGridViewTextBoxColumn
            // 
            this.bBBDataGridViewTextBoxColumn.DataPropertyName = "BBB";
            this.bBBDataGridViewTextBoxColumn.HeaderText = "BBB";
            this.bBBDataGridViewTextBoxColumn.Name = "bBBDataGridViewTextBoxColumn";
            // 
            // cCCDataGridViewTextBoxColumn
            // 
            this.cCCDataGridViewTextBoxColumn.DataPropertyName = "CCC";
            this.cCCDataGridViewTextBoxColumn.HeaderText = "CCC";
            this.cCCDataGridViewTextBoxColumn.Name = "cCCDataGridViewTextBoxColumn";
            // 
            // dDDDataGridViewTextBoxColumn
            // 
            this.dDDDataGridViewTextBoxColumn.DataPropertyName = "DDD";
            this.dDDDataGridViewTextBoxColumn.HeaderText = "DDD";
            this.dDDDataGridViewTextBoxColumn.Name = "dDDDataGridViewTextBoxColumn";
            // 
            // eEEDataGridViewTextBoxColumn
            // 
            this.eEEDataGridViewTextBoxColumn.DataPropertyName = "EEE";
            this.eEEDataGridViewTextBoxColumn.HeaderText = "EEE";
            this.eEEDataGridViewTextBoxColumn.Name = "eEEDataGridViewTextBoxColumn";
            // 
            // fFFDataGridViewTextBoxColumn
            // 
            this.fFFDataGridViewTextBoxColumn.DataPropertyName = "FFF";
            this.fFFDataGridViewTextBoxColumn.HeaderText = "FFF";
            this.fFFDataGridViewTextBoxColumn.Name = "fFFDataGridViewTextBoxColumn";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "DataTable2";
            this.bindingSource2.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 424);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOfCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSourceOfCombo;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColonnedeComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eEEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fFFDataGridViewTextBoxColumn;
    }
}