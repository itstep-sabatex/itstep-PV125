namespace WindowsFormsExplorer
{
    partial class UserForm
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
            this.demoDataSet = new WindowsFormsExplorer.DemoDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new WindowsFormsExplorer.DemoDataSetTableAdapters.UserTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bigintFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smallintFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinyintFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decimalNumericDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floatRealFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitFieldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.charFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncharFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varcharFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvarCharFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvarCharMaxFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntextFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageFieldDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.binaryFieldDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.varbinaryFieldDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime2FieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smalldatetimeFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeoffsetFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bigintFieldDataGridViewTextBoxColumn,
            this.smallintFieldDataGridViewTextBoxColumn,
            this.tinyintFieldDataGridViewTextBoxColumn,
            this.uidFieldDataGridViewTextBoxColumn,
            this.decimalNumericDataGridViewTextBoxColumn,
            this.floatRealFieldDataGridViewTextBoxColumn,
            this.moneyFieldDataGridViewTextBoxColumn,
            this.bitFieldDataGridViewCheckBoxColumn,
            this.charFieldDataGridViewTextBoxColumn,
            this.ncharFieldDataGridViewTextBoxColumn,
            this.varcharFieldDataGridViewTextBoxColumn,
            this.nvarCharFieldDataGridViewTextBoxColumn,
            this.nvarCharMaxFieldDataGridViewTextBoxColumn,
            this.textFieldDataGridViewTextBoxColumn,
            this.ntextFieldDataGridViewTextBoxColumn,
            this.imageFieldDataGridViewImageColumn,
            this.binaryFieldDataGridViewImageColumn,
            this.varbinaryFieldDataGridViewImageColumn,
            this.dateFieldDataGridViewTextBoxColumn,
            this.timeFieldDataGridViewTextBoxColumn,
            this.datetimeFieldDataGridViewTextBoxColumn,
            this.datetime2FieldDataGridViewTextBoxColumn,
            this.smalldatetimeFieldDataGridViewTextBoxColumn,
            this.datetimeoffsetFieldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "DemoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.demoDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // bigintFieldDataGridViewTextBoxColumn
            // 
            this.bigintFieldDataGridViewTextBoxColumn.DataPropertyName = "bigintField";
            this.bigintFieldDataGridViewTextBoxColumn.HeaderText = "bigintField";
            this.bigintFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bigintFieldDataGridViewTextBoxColumn.Name = "bigintFieldDataGridViewTextBoxColumn";
            this.bigintFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // smallintFieldDataGridViewTextBoxColumn
            // 
            this.smallintFieldDataGridViewTextBoxColumn.DataPropertyName = "smallintField";
            this.smallintFieldDataGridViewTextBoxColumn.HeaderText = "smallintField";
            this.smallintFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.smallintFieldDataGridViewTextBoxColumn.Name = "smallintFieldDataGridViewTextBoxColumn";
            this.smallintFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // tinyintFieldDataGridViewTextBoxColumn
            // 
            this.tinyintFieldDataGridViewTextBoxColumn.DataPropertyName = "tinyintField";
            this.tinyintFieldDataGridViewTextBoxColumn.HeaderText = "tinyintField";
            this.tinyintFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tinyintFieldDataGridViewTextBoxColumn.Name = "tinyintFieldDataGridViewTextBoxColumn";
            this.tinyintFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // uidFieldDataGridViewTextBoxColumn
            // 
            this.uidFieldDataGridViewTextBoxColumn.DataPropertyName = "uidField";
            this.uidFieldDataGridViewTextBoxColumn.HeaderText = "uidField";
            this.uidFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.uidFieldDataGridViewTextBoxColumn.Name = "uidFieldDataGridViewTextBoxColumn";
            this.uidFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // decimalNumericDataGridViewTextBoxColumn
            // 
            this.decimalNumericDataGridViewTextBoxColumn.DataPropertyName = "decimalNumeric";
            this.decimalNumericDataGridViewTextBoxColumn.HeaderText = "decimalNumeric";
            this.decimalNumericDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.decimalNumericDataGridViewTextBoxColumn.Name = "decimalNumericDataGridViewTextBoxColumn";
            this.decimalNumericDataGridViewTextBoxColumn.Width = 150;
            // 
            // floatRealFieldDataGridViewTextBoxColumn
            // 
            this.floatRealFieldDataGridViewTextBoxColumn.DataPropertyName = "floatRealField";
            this.floatRealFieldDataGridViewTextBoxColumn.HeaderText = "floatRealField";
            this.floatRealFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.floatRealFieldDataGridViewTextBoxColumn.Name = "floatRealFieldDataGridViewTextBoxColumn";
            this.floatRealFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // moneyFieldDataGridViewTextBoxColumn
            // 
            this.moneyFieldDataGridViewTextBoxColumn.DataPropertyName = "moneyField";
            this.moneyFieldDataGridViewTextBoxColumn.HeaderText = "moneyField";
            this.moneyFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.moneyFieldDataGridViewTextBoxColumn.Name = "moneyFieldDataGridViewTextBoxColumn";
            this.moneyFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // bitFieldDataGridViewCheckBoxColumn
            // 
            this.bitFieldDataGridViewCheckBoxColumn.DataPropertyName = "bitField";
            this.bitFieldDataGridViewCheckBoxColumn.HeaderText = "bitField";
            this.bitFieldDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.bitFieldDataGridViewCheckBoxColumn.Name = "bitFieldDataGridViewCheckBoxColumn";
            this.bitFieldDataGridViewCheckBoxColumn.Width = 150;
            // 
            // charFieldDataGridViewTextBoxColumn
            // 
            this.charFieldDataGridViewTextBoxColumn.DataPropertyName = "charField";
            this.charFieldDataGridViewTextBoxColumn.HeaderText = "charField";
            this.charFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.charFieldDataGridViewTextBoxColumn.Name = "charFieldDataGridViewTextBoxColumn";
            this.charFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // ncharFieldDataGridViewTextBoxColumn
            // 
            this.ncharFieldDataGridViewTextBoxColumn.DataPropertyName = "ncharField";
            this.ncharFieldDataGridViewTextBoxColumn.HeaderText = "ncharField";
            this.ncharFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ncharFieldDataGridViewTextBoxColumn.Name = "ncharFieldDataGridViewTextBoxColumn";
            this.ncharFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // varcharFieldDataGridViewTextBoxColumn
            // 
            this.varcharFieldDataGridViewTextBoxColumn.DataPropertyName = "varcharField";
            this.varcharFieldDataGridViewTextBoxColumn.HeaderText = "varcharField";
            this.varcharFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.varcharFieldDataGridViewTextBoxColumn.Name = "varcharFieldDataGridViewTextBoxColumn";
            this.varcharFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // nvarCharFieldDataGridViewTextBoxColumn
            // 
            this.nvarCharFieldDataGridViewTextBoxColumn.DataPropertyName = "nvarCharField";
            this.nvarCharFieldDataGridViewTextBoxColumn.HeaderText = "nvarCharField";
            this.nvarCharFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nvarCharFieldDataGridViewTextBoxColumn.Name = "nvarCharFieldDataGridViewTextBoxColumn";
            this.nvarCharFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // nvarCharMaxFieldDataGridViewTextBoxColumn
            // 
            this.nvarCharMaxFieldDataGridViewTextBoxColumn.DataPropertyName = "nvarCharMaxField";
            this.nvarCharMaxFieldDataGridViewTextBoxColumn.HeaderText = "nvarCharMaxField";
            this.nvarCharMaxFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nvarCharMaxFieldDataGridViewTextBoxColumn.Name = "nvarCharMaxFieldDataGridViewTextBoxColumn";
            this.nvarCharMaxFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // textFieldDataGridViewTextBoxColumn
            // 
            this.textFieldDataGridViewTextBoxColumn.DataPropertyName = "textField";
            this.textFieldDataGridViewTextBoxColumn.HeaderText = "textField";
            this.textFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.textFieldDataGridViewTextBoxColumn.Name = "textFieldDataGridViewTextBoxColumn";
            this.textFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // ntextFieldDataGridViewTextBoxColumn
            // 
            this.ntextFieldDataGridViewTextBoxColumn.DataPropertyName = "ntextField";
            this.ntextFieldDataGridViewTextBoxColumn.HeaderText = "ntextField";
            this.ntextFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ntextFieldDataGridViewTextBoxColumn.Name = "ntextFieldDataGridViewTextBoxColumn";
            this.ntextFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // imageFieldDataGridViewImageColumn
            // 
            this.imageFieldDataGridViewImageColumn.DataPropertyName = "imageField";
            this.imageFieldDataGridViewImageColumn.HeaderText = "imageField";
            this.imageFieldDataGridViewImageColumn.MinimumWidth = 8;
            this.imageFieldDataGridViewImageColumn.Name = "imageFieldDataGridViewImageColumn";
            this.imageFieldDataGridViewImageColumn.Width = 150;
            // 
            // binaryFieldDataGridViewImageColumn
            // 
            this.binaryFieldDataGridViewImageColumn.DataPropertyName = "binaryField";
            this.binaryFieldDataGridViewImageColumn.HeaderText = "binaryField";
            this.binaryFieldDataGridViewImageColumn.MinimumWidth = 8;
            this.binaryFieldDataGridViewImageColumn.Name = "binaryFieldDataGridViewImageColumn";
            this.binaryFieldDataGridViewImageColumn.Width = 150;
            // 
            // varbinaryFieldDataGridViewImageColumn
            // 
            this.varbinaryFieldDataGridViewImageColumn.DataPropertyName = "varbinaryField";
            this.varbinaryFieldDataGridViewImageColumn.HeaderText = "varbinaryField";
            this.varbinaryFieldDataGridViewImageColumn.MinimumWidth = 8;
            this.varbinaryFieldDataGridViewImageColumn.Name = "varbinaryFieldDataGridViewImageColumn";
            this.varbinaryFieldDataGridViewImageColumn.Width = 150;
            // 
            // dateFieldDataGridViewTextBoxColumn
            // 
            this.dateFieldDataGridViewTextBoxColumn.DataPropertyName = "dateField";
            this.dateFieldDataGridViewTextBoxColumn.HeaderText = "dateField";
            this.dateFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateFieldDataGridViewTextBoxColumn.Name = "dateFieldDataGridViewTextBoxColumn";
            this.dateFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeFieldDataGridViewTextBoxColumn
            // 
            this.timeFieldDataGridViewTextBoxColumn.DataPropertyName = "timeField";
            this.timeFieldDataGridViewTextBoxColumn.HeaderText = "timeField";
            this.timeFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeFieldDataGridViewTextBoxColumn.Name = "timeFieldDataGridViewTextBoxColumn";
            this.timeFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // datetimeFieldDataGridViewTextBoxColumn
            // 
            this.datetimeFieldDataGridViewTextBoxColumn.DataPropertyName = "datetimeField";
            this.datetimeFieldDataGridViewTextBoxColumn.HeaderText = "datetimeField";
            this.datetimeFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datetimeFieldDataGridViewTextBoxColumn.Name = "datetimeFieldDataGridViewTextBoxColumn";
            this.datetimeFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // datetime2FieldDataGridViewTextBoxColumn
            // 
            this.datetime2FieldDataGridViewTextBoxColumn.DataPropertyName = "datetime2Field";
            this.datetime2FieldDataGridViewTextBoxColumn.HeaderText = "datetime2Field";
            this.datetime2FieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datetime2FieldDataGridViewTextBoxColumn.Name = "datetime2FieldDataGridViewTextBoxColumn";
            this.datetime2FieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // smalldatetimeFieldDataGridViewTextBoxColumn
            // 
            this.smalldatetimeFieldDataGridViewTextBoxColumn.DataPropertyName = "smalldatetimeField";
            this.smalldatetimeFieldDataGridViewTextBoxColumn.HeaderText = "smalldatetimeField";
            this.smalldatetimeFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.smalldatetimeFieldDataGridViewTextBoxColumn.Name = "smalldatetimeFieldDataGridViewTextBoxColumn";
            this.smalldatetimeFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // datetimeoffsetFieldDataGridViewTextBoxColumn
            // 
            this.datetimeoffsetFieldDataGridViewTextBoxColumn.DataPropertyName = "datetimeoffsetField";
            this.datetimeoffsetFieldDataGridViewTextBoxColumn.HeaderText = "datetimeoffsetField";
            this.datetimeoffsetFieldDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.datetimeoffsetFieldDataGridViewTextBoxColumn.Name = "datetimeoffsetFieldDataGridViewTextBoxColumn";
            this.datetimeoffsetFieldDataGridViewTextBoxColumn.Width = 150;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DemoDataSet demoDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DemoDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bigintFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smallintFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinyintFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decimalNumericDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floatRealFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitFieldDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncharFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varcharFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvarCharFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvarCharMaxFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntextFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageFieldDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn binaryFieldDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn varbinaryFieldDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime2FieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn smalldatetimeFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeoffsetFieldDataGridViewTextBoxColumn;
    }
}