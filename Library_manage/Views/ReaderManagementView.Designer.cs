namespace Library_manage.Views
{
    partial class ReaderManagementView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageTitle = new System.Windows.Forms.Label();
            this.readerIdFilterCaption = new System.Windows.Forms.Label();
            this.readerIdFilter = new System.Windows.Forms.TextBox();
            this.readerNameFilterCaption = new System.Windows.Forms.Label();
            this.readerNameFilter = new System.Windows.Forms.TextBox();
            this.statusCaption = new System.Windows.Forms.Label();
            this.readerStateFilter = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.toolbarLine = new System.Windows.Forms.Panel();
            this.readersListLabel = new System.Windows.Forms.Label();
            this.newReaderButton = new System.Windows.Forms.Button();
            this.editReaderButton = new System.Windows.Forms.Button();
            this.stopReaderButton = new System.Windows.Forms.Button();
            this.readersGrid = new System.Windows.Forms.DataGridView();
            this.readersGridId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersGridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersGridDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersGridState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersGridIris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordCount = new System.Windows.Forms.Label();
            this.irisRegistrationButton = new System.Windows.Forms.Button();
            this.readerEditor = new System.Windows.Forms.Panel();
            this.readerEditorTitle = new System.Windows.Forms.Label();
            this.readerIdTextBoxCaption = new System.Windows.Forms.Label();
            this.readerIdTextBox = new System.Windows.Forms.TextBox();
            this.readerNameTextBoxCaption = new System.Windows.Forms.Label();
            this.readerNameTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBoxCaption = new System.Windows.Forms.Label();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBoxCaption = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.readerStateCaption = new System.Windows.Forms.Label();
            this.readerStateCombo = new System.Windows.Forms.ComboBox();
            this.saveReaderButton = new System.Windows.Forms.Button();
            this.cancelReaderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.readersGrid)).BeginInit();
            this.readerEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.pageTitle.Location = new System.Drawing.Point(16, 9);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(875, 42);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "读者管理";
            // 
            // readerIdFilterCaption
            // 
            this.readerIdFilterCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readerIdFilterCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerIdFilterCaption.Location = new System.Drawing.Point(22, 72);
            this.readerIdFilterCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerIdFilterCaption.Name = "readerIdFilterCaption";
            this.readerIdFilterCaption.Size = new System.Drawing.Size(225, 30);
            this.readerIdFilterCaption.TabIndex = 2;
            this.readerIdFilterCaption.Text = "读者编号";
            // 
            // readerIdFilter
            // 
            this.readerIdFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readerIdFilter.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.readerIdFilter.Location = new System.Drawing.Point(22, 112);
            this.readerIdFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerIdFilter.Name = "readerIdFilter";
            this.readerIdFilter.Size = new System.Drawing.Size(224, 31);
            this.readerIdFilter.TabIndex = 3;
            // 
            // readerNameFilterCaption
            // 
            this.readerNameFilterCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readerNameFilterCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerNameFilterCaption.Location = new System.Drawing.Point(274, 72);
            this.readerNameFilterCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerNameFilterCaption.Name = "readerNameFilterCaption";
            this.readerNameFilterCaption.Size = new System.Drawing.Size(225, 30);
            this.readerNameFilterCaption.TabIndex = 4;
            this.readerNameFilterCaption.Text = "姓名";
            // 
            // readerNameFilter
            // 
            this.readerNameFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readerNameFilter.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.readerNameFilter.Location = new System.Drawing.Point(274, 112);
            this.readerNameFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerNameFilter.Name = "readerNameFilter";
            this.readerNameFilter.Size = new System.Drawing.Size(224, 31);
            this.readerNameFilter.TabIndex = 5;
            // 
            // statusCaption
            // 
            this.statusCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.statusCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.statusCaption.Location = new System.Drawing.Point(528, 72);
            this.statusCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusCaption.Name = "statusCaption";
            this.statusCaption.Size = new System.Drawing.Size(175, 30);
            this.statusCaption.TabIndex = 6;
            this.statusCaption.Text = "状态";
            // 
            // readerStateFilter
            // 
            this.readerStateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readerStateFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readerStateFilter.Items.AddRange(new object[] {
            "全部",
            "正常",
            "停用",
            "注销"});
            this.readerStateFilter.Location = new System.Drawing.Point(528, 112);
            this.readerStateFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerStateFilter.Name = "readerStateFilter";
            this.readerStateFilter.Size = new System.Drawing.Size(178, 28);
            this.readerStateFilter.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchButton.Location = new System.Drawing.Point(736, 109);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 50);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "查询";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.resetButton.Location = new System.Drawing.Point(884, 109);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(131, 50);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "重置";
            this.resetButton.UseVisualStyleBackColor = false;
            // 
            // toolbarLine
            // 
            this.toolbarLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.toolbarLine.Location = new System.Drawing.Point(0, 189);
            this.toolbarLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolbarLine.Name = "toolbarLine";
            this.toolbarLine.Size = new System.Drawing.Size(1310, 1);
            this.toolbarLine.TabIndex = 10;
            // 
            // readersListLabel
            // 
            this.readersListLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.readersListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readersListLabel.Location = new System.Drawing.Point(0, 221);
            this.readersListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readersListLabel.Name = "readersListLabel";
            this.readersListLabel.Size = new System.Drawing.Size(400, 38);
            this.readersListLabel.TabIndex = 11;
            this.readersListLabel.Text = "读者档案";
            // 
            // newReaderButton
            // 
            this.newReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.newReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.newReaderButton.FlatAppearance.BorderSize = 0;
            this.newReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.newReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newReaderButton.Location = new System.Drawing.Point(482, 211);
            this.newReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newReaderButton.Name = "newReaderButton";
            this.newReaderButton.Size = new System.Drawing.Size(149, 48);
            this.newReaderButton.TabIndex = 12;
            this.newReaderButton.Text = "新增读者";
            this.newReaderButton.UseVisualStyleBackColor = false;
            // 
            // editReaderButton
            // 
            this.editReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.editReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.editReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.editReaderButton.Location = new System.Drawing.Point(646, 211);
            this.editReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editReaderButton.Name = "editReaderButton";
            this.editReaderButton.Size = new System.Drawing.Size(100, 48);
            this.editReaderButton.TabIndex = 13;
            this.editReaderButton.Text = "修改";
            this.editReaderButton.UseVisualStyleBackColor = false;
            // 
            // stopReaderButton
            // 
            this.stopReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stopReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.stopReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.stopReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.stopReaderButton.Location = new System.Drawing.Point(761, 211);
            this.stopReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopReaderButton.Name = "stopReaderButton";
            this.stopReaderButton.Size = new System.Drawing.Size(150, 48);
            this.stopReaderButton.TabIndex = 14;
            this.stopReaderButton.Text = "停用 / 恢复";
            this.stopReaderButton.UseVisualStyleBackColor = false;
            this.stopReaderButton.Click += new System.EventHandler(this.stopReaderButton_Click);
            // 
            // readersGrid
            // 
            this.readersGrid.AllowUserToAddRows = false;
            this.readersGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.readersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.readersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.readersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.readersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.readersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.readersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.readersGrid.ColumnHeadersHeight = 40;
            this.readersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.readersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readersGridId,
            this.readersGridName,
            this.readersGridDepartment,
            this.readersGridState,
            this.readersGridIris});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.readersGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.readersGrid.EnableHeadersVisualStyles = false;
            this.readersGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.readersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.readersGrid.Location = new System.Drawing.Point(0, 279);
            this.readersGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readersGrid.MultiSelect = false;
            this.readersGrid.Name = "readersGrid";
            this.readersGrid.ReadOnly = true;
            this.readersGrid.RowHeadersVisible = false;
            this.readersGrid.RowTemplate.Height = 34;
            this.readersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readersGrid.Size = new System.Drawing.Size(911, 408);
            this.readersGrid.TabIndex = 15;
            // 
            // readersGridId
            // 
            this.readersGridId.HeaderText = "读者编号";
            this.readersGridId.Name = "readersGridId";
            this.readersGridId.ReadOnly = true;
            // 
            // readersGridName
            // 
            this.readersGridName.FillWeight = 75F;
            this.readersGridName.HeaderText = "姓名";
            this.readersGridName.Name = "readersGridName";
            this.readersGridName.ReadOnly = true;
            // 
            // readersGridDepartment
            // 
            this.readersGridDepartment.FillWeight = 120F;
            this.readersGridDepartment.HeaderText = "班级 / 部门";
            this.readersGridDepartment.Name = "readersGridDepartment";
            this.readersGridDepartment.ReadOnly = true;
            // 
            // readersGridState
            // 
            this.readersGridState.FillWeight = 65F;
            this.readersGridState.HeaderText = "状态";
            this.readersGridState.Name = "readersGridState";
            this.readersGridState.ReadOnly = true;
            // 
            // readersGridIris
            // 
            this.readersGridIris.FillWeight = 65F;
            this.readersGridIris.HeaderText = "虹膜";
            this.readersGridIris.Name = "readersGridIris";
            this.readersGridIris.ReadOnly = true;
            // 
            // recordCount
            // 
            this.recordCount.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.recordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.recordCount.Location = new System.Drawing.Point(1, 718);
            this.recordCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recordCount.Name = "recordCount";
            this.recordCount.Size = new System.Drawing.Size(375, 32);
            this.recordCount.TabIndex = 17;
            this.recordCount.Text = "0 条记录";
            // 
            // irisRegistrationButton
            // 
            this.irisRegistrationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.irisRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.irisRegistrationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.irisRegistrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.irisRegistrationButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.irisRegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.irisRegistrationButton.Location = new System.Drawing.Point(625, 706);
            this.irisRegistrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.irisRegistrationButton.Name = "irisRegistrationButton";
            this.irisRegistrationButton.Size = new System.Drawing.Size(286, 49);
            this.irisRegistrationButton.TabIndex = 18;
            this.irisRegistrationButton.Text = "为选中读者注册虹膜";
            this.irisRegistrationButton.UseVisualStyleBackColor = false;
            this.irisRegistrationButton.Click += new System.EventHandler(this.irisRegistrationButton_Click);
            // 
            // readerEditor
            // 
            this.readerEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.readerEditor.Controls.Add(this.readerEditorTitle);
            this.readerEditor.Controls.Add(this.readerIdTextBoxCaption);
            this.readerEditor.Controls.Add(this.readerIdTextBox);
            this.readerEditor.Controls.Add(this.readerNameTextBoxCaption);
            this.readerEditor.Controls.Add(this.readerNameTextBox);
            this.readerEditor.Controls.Add(this.departmentTextBoxCaption);
            this.readerEditor.Controls.Add(this.departmentTextBox);
            this.readerEditor.Controls.Add(this.phoneTextBoxCaption);
            this.readerEditor.Controls.Add(this.phoneTextBox);
            this.readerEditor.Controls.Add(this.readerStateCaption);
            this.readerEditor.Controls.Add(this.readerStateCombo);
            this.readerEditor.Controls.Add(this.saveReaderButton);
            this.readerEditor.Controls.Add(this.cancelReaderButton);
            this.readerEditor.Location = new System.Drawing.Point(939, 221);
            this.readerEditor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerEditor.Name = "readerEditor";
            this.readerEditor.Size = new System.Drawing.Size(371, 534);
            this.readerEditor.TabIndex = 19;
            // 
            // readerEditorTitle
            // 
            this.readerEditorTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.readerEditorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.readerEditorTitle.Location = new System.Drawing.Point(22, 18);
            this.readerEditorTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerEditorTitle.Name = "readerEditorTitle";
            this.readerEditorTitle.Size = new System.Drawing.Size(330, 39);
            this.readerEditorTitle.TabIndex = 0;
            this.readerEditorTitle.Text = "读者资料";
            // 
            // readerIdTextBoxCaption
            // 
            this.readerIdTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.readerIdTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerIdTextBoxCaption.Location = new System.Drawing.Point(22, 80);
            this.readerIdTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerIdTextBoxCaption.Name = "readerIdTextBoxCaption";
            this.readerIdTextBoxCaption.Size = new System.Drawing.Size(114, 32);
            this.readerIdTextBoxCaption.TabIndex = 1;
            this.readerIdTextBoxCaption.Text = "编号";
            // 
            // readerIdTextBox
            // 
            this.readerIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readerIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.readerIdTextBox.Location = new System.Drawing.Point(138, 75);
            this.readerIdTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerIdTextBox.Name = "readerIdTextBox";
            this.readerIdTextBox.Size = new System.Drawing.Size(211, 31);
            this.readerIdTextBox.TabIndex = 2;
            // 
            // readerNameTextBoxCaption
            // 
            this.readerNameTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.readerNameTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerNameTextBoxCaption.Location = new System.Drawing.Point(22, 138);
            this.readerNameTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerNameTextBoxCaption.Name = "readerNameTextBoxCaption";
            this.readerNameTextBoxCaption.Size = new System.Drawing.Size(114, 32);
            this.readerNameTextBoxCaption.TabIndex = 3;
            this.readerNameTextBoxCaption.Text = "姓名";
            // 
            // readerNameTextBox
            // 
            this.readerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.readerNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.readerNameTextBox.Location = new System.Drawing.Point(138, 132);
            this.readerNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerNameTextBox.Name = "readerNameTextBox";
            this.readerNameTextBox.Size = new System.Drawing.Size(211, 31);
            this.readerNameTextBox.TabIndex = 4;
            // 
            // departmentTextBoxCaption
            // 
            this.departmentTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.departmentTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.departmentTextBoxCaption.Location = new System.Drawing.Point(22, 195);
            this.departmentTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departmentTextBoxCaption.Name = "departmentTextBoxCaption";
            this.departmentTextBoxCaption.Size = new System.Drawing.Size(114, 32);
            this.departmentTextBoxCaption.TabIndex = 5;
            this.departmentTextBoxCaption.Text = "班级 / 部门";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departmentTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.departmentTextBox.Location = new System.Drawing.Point(138, 190);
            this.departmentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(211, 31);
            this.departmentTextBox.TabIndex = 6;
            // 
            // phoneTextBoxCaption
            // 
            this.phoneTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.phoneTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.phoneTextBoxCaption.Location = new System.Drawing.Point(22, 252);
            this.phoneTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneTextBoxCaption.Name = "phoneTextBoxCaption";
            this.phoneTextBoxCaption.Size = new System.Drawing.Size(114, 32);
            this.phoneTextBoxCaption.TabIndex = 7;
            this.phoneTextBoxCaption.Text = "电话";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.phoneTextBox.Location = new System.Drawing.Point(138, 248);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(211, 31);
            this.phoneTextBox.TabIndex = 8;
            // 
            // readerStateCaption
            // 
            this.readerStateCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.readerStateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.readerStateCaption.Location = new System.Drawing.Point(22, 310);
            this.readerStateCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readerStateCaption.Name = "readerStateCaption";
            this.readerStateCaption.Size = new System.Drawing.Size(114, 32);
            this.readerStateCaption.TabIndex = 9;
            this.readerStateCaption.Text = "状态";
            // 
            // readerStateCombo
            // 
            this.readerStateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readerStateCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readerStateCombo.Items.AddRange(new object[] {
            "正常",
            "停用",
            "注销"});
            this.readerStateCombo.Location = new System.Drawing.Point(138, 305);
            this.readerStateCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readerStateCombo.Name = "readerStateCombo";
            this.readerStateCombo.Size = new System.Drawing.Size(210, 28);
            this.readerStateCombo.TabIndex = 10;
            // 
            // saveReaderButton
            // 
            this.saveReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveReaderButton.FlatAppearance.BorderSize = 0;
            this.saveReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.saveReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveReaderButton.Location = new System.Drawing.Point(22, 442);
            this.saveReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveReaderButton.Name = "saveReaderButton";
            this.saveReaderButton.Size = new System.Drawing.Size(152, 50);
            this.saveReaderButton.TabIndex = 11;
            this.saveReaderButton.Text = "保存";
            this.saveReaderButton.UseVisualStyleBackColor = false;
            // 
            // cancelReaderButton
            // 
            this.cancelReaderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelReaderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelReaderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.cancelReaderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelReaderButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cancelReaderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.cancelReaderButton.Location = new System.Drawing.Point(191, 442);
            this.cancelReaderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelReaderButton.Name = "cancelReaderButton";
            this.cancelReaderButton.Size = new System.Drawing.Size(158, 50);
            this.cancelReaderButton.TabIndex = 12;
            this.cancelReaderButton.Text = "取消";
            this.cancelReaderButton.UseVisualStyleBackColor = false;
            // 
            // ReaderManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.readerIdFilterCaption);
            this.Controls.Add(this.readerIdFilter);
            this.Controls.Add(this.readerNameFilterCaption);
            this.Controls.Add(this.readerNameFilter);
            this.Controls.Add(this.statusCaption);
            this.Controls.Add(this.readerStateFilter);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.toolbarLine);
            this.Controls.Add(this.readersListLabel);
            this.Controls.Add(this.newReaderButton);
            this.Controls.Add(this.editReaderButton);
            this.Controls.Add(this.stopReaderButton);
            this.Controls.Add(this.readersGrid);
            this.Controls.Add(this.recordCount);
            this.Controls.Add(this.irisRegistrationButton);
            this.Controls.Add(this.readerEditor);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReaderManagementView";
            this.Size = new System.Drawing.Size(1312, 808);
            ((System.ComponentModel.ISupportInitialize)(this.readersGrid)).EndInit();
            this.readerEditor.ResumeLayout(false);
            this.readerEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label pageTitle;

        private System.Windows.Forms.Label readerIdFilterCaption;
        private System.Windows.Forms.TextBox readerIdFilter;
        private System.Windows.Forms.Label readerNameFilterCaption;
        private System.Windows.Forms.TextBox readerNameFilter;
        private System.Windows.Forms.Label statusCaption;
        private System.Windows.Forms.ComboBox readerStateFilter;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Panel toolbarLine;
        private System.Windows.Forms.Label readersListLabel;
        private System.Windows.Forms.Button newReaderButton;
        private System.Windows.Forms.Button editReaderButton;
        private System.Windows.Forms.Button stopReaderButton;
        private System.Windows.Forms.DataGridView readersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn readersGridId;
        private System.Windows.Forms.DataGridViewTextBoxColumn readersGridName;
        private System.Windows.Forms.DataGridViewTextBoxColumn readersGridDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn readersGridState;
        private System.Windows.Forms.DataGridViewTextBoxColumn readersGridIris;

        private System.Windows.Forms.Label recordCount;
        private System.Windows.Forms.Button irisRegistrationButton;
        private System.Windows.Forms.Panel readerEditor;
        private System.Windows.Forms.Label readerEditorTitle;
        private System.Windows.Forms.Label readerIdTextBoxCaption;
        private System.Windows.Forms.TextBox readerIdTextBox;
        private System.Windows.Forms.Label readerNameTextBoxCaption;
        private System.Windows.Forms.TextBox readerNameTextBox;
        private System.Windows.Forms.Label departmentTextBoxCaption;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Label phoneTextBoxCaption;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label readerStateCaption;
        private System.Windows.Forms.ComboBox readerStateCombo;
        private System.Windows.Forms.Button saveReaderButton;
        private System.Windows.Forms.Button cancelReaderButton;
    }
}
