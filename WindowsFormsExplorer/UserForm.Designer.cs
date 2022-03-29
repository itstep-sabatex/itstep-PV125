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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demoDataSet = new WindowsFormsExplorer.DemoDataSet();
            this.userTableAdapter = new WindowsFormsExplorer.DemoDataSetTableAdapters.UserTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 412);
            this.dataGridView1.TabIndex = 0;
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
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.demoDataSet;
            // 
            // demoDataSet
            // 
            this.demoDataSet.DataSetName = "DemoDataSet";
            this.demoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.userBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1149, 38);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(53, 33);
            this.toolStripButton1.Text = "Save";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}