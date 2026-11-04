namespace Library_manage.Views
{
    partial class BookManagementView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageTitle = new System.Windows.Forms.Label();
            this.bookTitleFilterCaption = new System.Windows.Forms.Label();
            this.bookTitleFilter = new System.Windows.Forms.TextBox();
            this.authorFilterCaption = new System.Windows.Forms.Label();
            this.authorFilter = new System.Windows.Forms.TextBox();
            this.isbnFilterCaption = new System.Windows.Forms.Label();
            this.isbnFilter = new System.Windows.Forms.TextBox();
            this.searchBooksButton = new System.Windows.Forms.Button();
            this.resetBooksButton = new System.Windows.Forms.Button();
            this.bookToolbarLine = new System.Windows.Forms.Panel();
            this.bookListLabel = new System.Windows.Forms.Label();
            this.newBookButton = new System.Windows.Forms.Button();
            this.editBookButton = new System.Windows.Forms.Button();
            this.deleteBookButton = new System.Windows.Forms.Button();
            this.booksGrid = new System.Windows.Forms.DataGridView();
            this.booksGridIsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksGridTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksGridAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksGridCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyListLabel = new System.Windows.Forms.Label();
            this.newCopyButton = new System.Windows.Forms.Button();
            this.editCopyButton = new System.Windows.Forms.Button();
            this.deleteCopyButton = new System.Windows.Forms.Button();
            this.copiesGrid = new System.Windows.Forms.DataGridView();
            this.copiesGridBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesGridLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesGridState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copiesGridDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookEditorTabs = new System.Windows.Forms.TabControl();
            this.bibliographyTab = new System.Windows.Forms.TabPage();
            this.isbnTextBoxCaption = new System.Windows.Forms.Label();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBoxCaption = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBoxCaption = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBoxCaption = new System.Windows.Forms.Label();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBoxCaption = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBoxCaption = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.saveBookButton = new System.Windows.Forms.Button();
            this.cancelBookButton = new System.Windows.Forms.Button();
            this.copyEditorTab = new System.Windows.Forms.TabPage();
            this.copyBarcodeTextBoxCaption = new System.Windows.Forms.Label();
            this.copyBarcodeTextBox = new System.Windows.Forms.TextBox();
            this.copyLocationTextBoxCaption = new System.Windows.Forms.Label();
            this.copyLocationTextBox = new System.Windows.Forms.TextBox();
            this.copyStateCaption = new System.Windows.Forms.Label();
            this.copyStateCombo = new System.Windows.Forms.ComboBox();
            this.saveCopyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesGrid)).BeginInit();
            this.bookEditorTabs.SuspendLayout();
            this.bibliographyTab.SuspendLayout();
            this.copyEditorTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageTitle
            // 
            this.pageTitle.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.pageTitle.Location = new System.Drawing.Point(21, 10);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(178, 42);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "图书管理";
            // 
            // bookTitleFilterCaption
            // 
            this.bookTitleFilterCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.bookTitleFilterCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.bookTitleFilterCaption.Location = new System.Drawing.Point(24, 72);
            this.bookTitleFilterCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookTitleFilterCaption.Name = "bookTitleFilterCaption";
            this.bookTitleFilterCaption.Size = new System.Drawing.Size(292, 30);
            this.bookTitleFilterCaption.TabIndex = 2;
            this.bookTitleFilterCaption.Text = "书名";
            // 
            // bookTitleFilter
            // 
            this.bookTitleFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookTitleFilter.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.bookTitleFilter.Location = new System.Drawing.Point(24, 112);
            this.bookTitleFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookTitleFilter.Name = "bookTitleFilter";
            this.bookTitleFilter.Size = new System.Drawing.Size(292, 31);
            this.bookTitleFilter.TabIndex = 3;
            // 
            // authorFilterCaption
            // 
            this.authorFilterCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.authorFilterCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.authorFilterCaption.Location = new System.Drawing.Point(335, 72);
            this.authorFilterCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorFilterCaption.Name = "authorFilterCaption";
            this.authorFilterCaption.Size = new System.Drawing.Size(199, 30);
            this.authorFilterCaption.TabIndex = 4;
            this.authorFilterCaption.Text = "作者";
            // 
            // authorFilter
            // 
            this.authorFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorFilter.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.authorFilter.Location = new System.Drawing.Point(339, 112);
            this.authorFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorFilter.Name = "authorFilter";
            this.authorFilter.Size = new System.Drawing.Size(198, 31);
            this.authorFilter.TabIndex = 5;
            // 
            // isbnFilterCaption
            // 
            this.isbnFilterCaption.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.isbnFilterCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.isbnFilterCaption.Location = new System.Drawing.Point(560, 72);
            this.isbnFilterCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbnFilterCaption.Name = "isbnFilterCaption";
            this.isbnFilterCaption.Size = new System.Drawing.Size(289, 30);
            this.isbnFilterCaption.TabIndex = 6;
            this.isbnFilterCaption.Text = "ISBN";
            // 
            // isbnFilter
            // 
            this.isbnFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isbnFilter.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.isbnFilter.Location = new System.Drawing.Point(564, 112);
            this.isbnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isbnFilter.Name = "isbnFilter";
            this.isbnFilter.Size = new System.Drawing.Size(288, 31);
            this.isbnFilter.TabIndex = 7;
            // 
            // searchBooksButton
            // 
            this.searchBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.searchBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBooksButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.searchBooksButton.FlatAppearance.BorderSize = 0;
            this.searchBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBooksButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.searchBooksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchBooksButton.Location = new System.Drawing.Point(913, 112);
            this.searchBooksButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBooksButton.Name = "searchBooksButton";
            this.searchBooksButton.Size = new System.Drawing.Size(131, 50);
            this.searchBooksButton.TabIndex = 8;
            this.searchBooksButton.Text = "查询";
            this.searchBooksButton.UseVisualStyleBackColor = false;
            // 
            // resetBooksButton
            // 
            this.resetBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resetBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBooksButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.resetBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBooksButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.resetBooksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.resetBooksButton.Location = new System.Drawing.Point(1076, 112);
            this.resetBooksButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetBooksButton.Name = "resetBooksButton";
            this.resetBooksButton.Size = new System.Drawing.Size(131, 50);
            this.resetBooksButton.TabIndex = 9;
            this.resetBooksButton.Text = "重置";
            this.resetBooksButton.UseVisualStyleBackColor = false;
            // 
            // bookToolbarLine
            // 
            this.bookToolbarLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(228)))), ((int)(((byte)(222)))));
            this.bookToolbarLine.Location = new System.Drawing.Point(0, 189);
            this.bookToolbarLine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookToolbarLine.Name = "bookToolbarLine";
            this.bookToolbarLine.Size = new System.Drawing.Size(1310, 1);
            this.bookToolbarLine.TabIndex = 10;
            // 
            // bookListLabel
            // 
            this.bookListLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.bookListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.bookListLabel.Location = new System.Drawing.Point(0, 221);
            this.bookListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookListLabel.Name = "bookListLabel";
            this.bookListLabel.Size = new System.Drawing.Size(375, 39);
            this.bookListLabel.TabIndex = 11;
            this.bookListLabel.Text = "图书书目";
            // 
            // newBookButton
            // 
            this.newBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.newBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.newBookButton.FlatAppearance.BorderSize = 0;
            this.newBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.newBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newBookButton.Location = new System.Drawing.Point(554, 211);
            this.newBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newBookButton.Name = "newBookButton";
            this.newBookButton.Size = new System.Drawing.Size(149, 48);
            this.newBookButton.TabIndex = 12;
            this.newBookButton.Text = "新增书目";
            this.newBookButton.UseVisualStyleBackColor = false;
            this.newBookButton.Click += new System.EventHandler(this.newBookButton_Click);
            // 
            // editBookButton
            // 
            this.editBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.editBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.editBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.editBookButton.Location = new System.Drawing.Point(719, 211);
            this.editBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBookButton.Name = "editBookButton";
            this.editBookButton.Size = new System.Drawing.Size(90, 48);
            this.editBookButton.TabIndex = 13;
            this.editBookButton.Text = "修改";
            this.editBookButton.UseVisualStyleBackColor = false;
            this.editBookButton.Click += new System.EventHandler(this.editBookButton_Click);
            // 
            // deleteBookButton
            // 
            this.deleteBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.deleteBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.deleteBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deleteBookButton.Location = new System.Drawing.Point(824, 211);
            this.deleteBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteBookButton.Name = "deleteBookButton";
            this.deleteBookButton.Size = new System.Drawing.Size(90, 48);
            this.deleteBookButton.TabIndex = 14;
            this.deleteBookButton.Text = "删除";
            this.deleteBookButton.UseVisualStyleBackColor = false;
            // 
            // booksGrid
            // 
            this.booksGrid.AllowUserToAddRows = false;
            this.booksGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.booksGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.booksGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.booksGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.booksGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.booksGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.booksGrid.ColumnHeadersHeight = 40;
            this.booksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.booksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booksGridIsbn,
            this.booksGridTitle,
            this.booksGridAuthor,
            this.booksGridCategory});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.booksGrid.EnableHeadersVisualStyles = false;
            this.booksGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.booksGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.booksGrid.Location = new System.Drawing.Point(0, 280);
            this.booksGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booksGrid.MultiSelect = false;
            this.booksGrid.Name = "booksGrid";
            this.booksGrid.ReadOnly = true;
            this.booksGrid.RowHeadersVisible = false;
            this.booksGrid.RowTemplate.Height = 34;
            this.booksGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGrid.Size = new System.Drawing.Size(914, 209);
            this.booksGrid.TabIndex = 15;
            // 
            // booksGridIsbn
            // 
            this.booksGridIsbn.FillWeight = 110F;
            this.booksGridIsbn.HeaderText = "ISBN";
            this.booksGridIsbn.Name = "booksGridIsbn";
            this.booksGridIsbn.ReadOnly = true;
            // 
            // booksGridTitle
            // 
            this.booksGridTitle.FillWeight = 180F;
            this.booksGridTitle.HeaderText = "书名";
            this.booksGridTitle.Name = "booksGridTitle";
            this.booksGridTitle.ReadOnly = true;
            // 
            // booksGridAuthor
            // 
            this.booksGridAuthor.FillWeight = 90F;
            this.booksGridAuthor.HeaderText = "作者";
            this.booksGridAuthor.Name = "booksGridAuthor";
            this.booksGridAuthor.ReadOnly = true;
            // 
            // booksGridCategory
            // 
            this.booksGridCategory.FillWeight = 75F;
            this.booksGridCategory.HeaderText = "分类";
            this.booksGridCategory.Name = "booksGridCategory";
            this.booksGridCategory.ReadOnly = true;
            // 
            // copyListLabel
            // 
            this.copyListLabel.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.copyListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.copyListLabel.Location = new System.Drawing.Point(0, 526);
            this.copyListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyListLabel.Name = "copyListLabel";
            this.copyListLabel.Size = new System.Drawing.Size(375, 39);
            this.copyListLabel.TabIndex = 17;
            this.copyListLabel.Text = "馆藏复本";
            // 
            // newCopyButton
            // 
            this.newCopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.newCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newCopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.newCopyButton.FlatAppearance.BorderSize = 0;
            this.newCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newCopyButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.newCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newCopyButton.Location = new System.Drawing.Point(554, 518);
            this.newCopyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newCopyButton.Name = "newCopyButton";
            this.newCopyButton.Size = new System.Drawing.Size(149, 48);
            this.newCopyButton.TabIndex = 18;
            this.newCopyButton.Text = "新增复本";
            this.newCopyButton.UseVisualStyleBackColor = false;
            this.newCopyButton.Click += new System.EventHandler(this.newCopyButton_Click);
            // 
            // editCopyButton
            // 
            this.editCopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.editCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editCopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.editCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCopyButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.editCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.editCopyButton.Location = new System.Drawing.Point(719, 518);
            this.editCopyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editCopyButton.Name = "editCopyButton";
            this.editCopyButton.Size = new System.Drawing.Size(90, 48);
            this.editCopyButton.TabIndex = 19;
            this.editCopyButton.Text = "修改";
            this.editCopyButton.UseVisualStyleBackColor = false;
            this.editCopyButton.Click += new System.EventHandler(this.editCopyButton_Click);
            // 
            // deleteCopyButton
            // 
            this.deleteCopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.deleteCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.deleteCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCopyButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.deleteCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.deleteCopyButton.Location = new System.Drawing.Point(824, 518);
            this.deleteCopyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCopyButton.Name = "deleteCopyButton";
            this.deleteCopyButton.Size = new System.Drawing.Size(90, 48);
            this.deleteCopyButton.TabIndex = 20;
            this.deleteCopyButton.Text = "删除";
            this.deleteCopyButton.UseVisualStyleBackColor = false;
            // 
            // copiesGrid
            // 
            this.copiesGrid.AllowUserToAddRows = false;
            this.copiesGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.copiesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.copiesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.copiesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.copiesGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copiesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.copiesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.copiesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.copiesGrid.ColumnHeadersHeight = 40;
            this.copiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.copiesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.copiesGridBarcode,
            this.copiesGridLocation,
            this.copiesGridState,
            this.copiesGridDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.copiesGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.copiesGrid.EnableHeadersVisualStyles = false;
            this.copiesGrid.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.copiesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(243)))));
            this.copiesGrid.Location = new System.Drawing.Point(0, 589);
            this.copiesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copiesGrid.MultiSelect = false;
            this.copiesGrid.Name = "copiesGrid";
            this.copiesGrid.ReadOnly = true;
            this.copiesGrid.RowHeadersVisible = false;
            this.copiesGrid.RowTemplate.Height = 34;
            this.copiesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.copiesGrid.Size = new System.Drawing.Size(914, 165);
            this.copiesGrid.TabIndex = 21;
            // 
            // copiesGridBarcode
            // 
            this.copiesGridBarcode.FillWeight = 120F;
            this.copiesGridBarcode.HeaderText = "复本条码";
            this.copiesGridBarcode.Name = "copiesGridBarcode";
            this.copiesGridBarcode.ReadOnly = true;
            // 
            // copiesGridLocation
            // 
            this.copiesGridLocation.FillWeight = 145F;
            this.copiesGridLocation.HeaderText = "馆藏位置";
            this.copiesGridLocation.Name = "copiesGridLocation";
            this.copiesGridLocation.ReadOnly = true;
            // 
            // copiesGridState
            // 
            this.copiesGridState.FillWeight = 80F;
            this.copiesGridState.HeaderText = "状态";
            this.copiesGridState.Name = "copiesGridState";
            this.copiesGridState.ReadOnly = true;
            // 
            // copiesGridDate
            // 
            this.copiesGridDate.FillWeight = 110F;
            this.copiesGridDate.HeaderText = "入库日期";
            this.copiesGridDate.Name = "copiesGridDate";
            this.copiesGridDate.ReadOnly = true;
            // 
            // bookEditorTabs
            // 
            this.bookEditorTabs.Controls.Add(this.bibliographyTab);
            this.bookEditorTabs.Controls.Add(this.copyEditorTab);
            this.bookEditorTabs.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.bookEditorTabs.Location = new System.Drawing.Point(940, 221);
            this.bookEditorTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookEditorTabs.Name = "bookEditorTabs";
            this.bookEditorTabs.SelectedIndex = 0;
            this.bookEditorTabs.Size = new System.Drawing.Size(370, 535);
            this.bookEditorTabs.TabIndex = 23;
            // 
            // bibliographyTab
            // 
            this.bibliographyTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.bibliographyTab.Controls.Add(this.isbnTextBoxCaption);
            this.bibliographyTab.Controls.Add(this.isbnTextBox);
            this.bibliographyTab.Controls.Add(this.bookTitleTextBoxCaption);
            this.bibliographyTab.Controls.Add(this.bookTitleTextBox);
            this.bibliographyTab.Controls.Add(this.authorTextBoxCaption);
            this.bibliographyTab.Controls.Add(this.authorTextBox);
            this.bibliographyTab.Controls.Add(this.publisherTextBoxCaption);
            this.bibliographyTab.Controls.Add(this.publisherTextBox);
            this.bibliographyTab.Controls.Add(this.categoryTextBoxCaption);
            this.bibliographyTab.Controls.Add(this.categoryTextBox);
            this.bibliographyTab.Controls.Add(this.yearTextBoxCaption);
            this.bibliographyTab.Controls.Add(this.yearTextBox);
            this.bibliographyTab.Controls.Add(this.saveBookButton);
            this.bibliographyTab.Controls.Add(this.cancelBookButton);
            this.bibliographyTab.Location = new System.Drawing.Point(4, 32);
            this.bibliographyTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bibliographyTab.Name = "bibliographyTab";
            this.bibliographyTab.Size = new System.Drawing.Size(362, 499);
            this.bibliographyTab.TabIndex = 0;
            this.bibliographyTab.Text = "书目资料";
            // 
            // isbnTextBoxCaption
            // 
            this.isbnTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.isbnTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.isbnTextBoxCaption.Location = new System.Drawing.Point(15, 28);
            this.isbnTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.isbnTextBoxCaption.Name = "isbnTextBoxCaption";
            this.isbnTextBoxCaption.Size = new System.Drawing.Size(85, 32);
            this.isbnTextBoxCaption.TabIndex = 0;
            this.isbnTextBoxCaption.Text = "ISBN";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isbnTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.isbnTextBox.Location = new System.Drawing.Point(104, 22);
            this.isbnTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(233, 31);
            this.isbnTextBox.TabIndex = 1;
            // 
            // bookTitleTextBoxCaption
            // 
            this.bookTitleTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.bookTitleTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.bookTitleTextBoxCaption.Location = new System.Drawing.Point(15, 82);
            this.bookTitleTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookTitleTextBoxCaption.Name = "bookTitleTextBoxCaption";
            this.bookTitleTextBoxCaption.Size = new System.Drawing.Size(85, 32);
            this.bookTitleTextBoxCaption.TabIndex = 2;
            this.bookTitleTextBoxCaption.Text = "书名";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookTitleTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.bookTitleTextBox.Location = new System.Drawing.Point(104, 78);
            this.bookTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(233, 31);
            this.bookTitleTextBox.TabIndex = 3;
            // 
            // authorTextBoxCaption
            // 
            this.authorTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.authorTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.authorTextBoxCaption.Location = new System.Drawing.Point(15, 138);
            this.authorTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorTextBoxCaption.Name = "authorTextBoxCaption";
            this.authorTextBoxCaption.Size = new System.Drawing.Size(85, 32);
            this.authorTextBoxCaption.TabIndex = 4;
            this.authorTextBoxCaption.Text = "作者";
            // 
            // authorTextBox
            // 
            this.authorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.authorTextBox.Location = new System.Drawing.Point(104, 132);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(233, 31);
            this.authorTextBox.TabIndex = 5;
            // 
            // publisherTextBoxCaption
            // 
            this.publisherTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.publisherTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.publisherTextBoxCaption.Location = new System.Drawing.Point(15, 192);
            this.publisherTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisherTextBoxCaption.Name = "publisherTextBoxCaption";
            this.publisherTextBoxCaption.Size = new System.Drawing.Size(85, 32);
            this.publisherTextBoxCaption.TabIndex = 6;
            this.publisherTextBoxCaption.Text = "出版社";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.publisherTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.publisherTextBox.Location = new System.Drawing.Point(104, 188);
            this.publisherTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(233, 31);
            this.publisherTextBox.TabIndex = 7;
            // 
            // categoryTextBoxCaption
            // 
            this.categoryTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.categoryTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.categoryTextBoxCaption.Location = new System.Drawing.Point(15, 248);
            this.categoryTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryTextBoxCaption.Name = "categoryTextBoxCaption";
            this.categoryTextBoxCaption.Size = new System.Drawing.Size(85, 32);
            this.categoryTextBoxCaption.TabIndex = 8;
            this.categoryTextBoxCaption.Text = "分类";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.categoryTextBox.Location = new System.Drawing.Point(104, 242);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(233, 31);
            this.categoryTextBox.TabIndex = 9;
            // 
            // yearTextBoxCaption
            // 
            this.yearTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.yearTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.yearTextBoxCaption.Location = new System.Drawing.Point(15, 302);
            this.yearTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearTextBoxCaption.Name = "yearTextBoxCaption";
            this.yearTextBoxCaption.Size = new System.Drawing.Size(85, 32);
            this.yearTextBoxCaption.TabIndex = 10;
            this.yearTextBoxCaption.Text = "年份";
            // 
            // yearTextBox
            // 
            this.yearTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.yearTextBox.Location = new System.Drawing.Point(104, 298);
            this.yearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(233, 31);
            this.yearTextBox.TabIndex = 11;
            // 
            // saveBookButton
            // 
            this.saveBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveBookButton.FlatAppearance.BorderSize = 0;
            this.saveBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.saveBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveBookButton.Location = new System.Drawing.Point(15, 406);
            this.saveBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBookButton.Name = "saveBookButton";
            this.saveBookButton.Size = new System.Drawing.Size(152, 49);
            this.saveBookButton.TabIndex = 12;
            this.saveBookButton.Text = "保存";
            this.saveBookButton.UseVisualStyleBackColor = false;
            // 
            // cancelBookButton
            // 
            this.cancelBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cancelBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(225)))), ((int)(((byte)(218)))));
            this.cancelBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBookButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.cancelBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.cancelBookButton.Location = new System.Drawing.Point(184, 406);
            this.cancelBookButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelBookButton.Name = "cancelBookButton";
            this.cancelBookButton.Size = new System.Drawing.Size(154, 49);
            this.cancelBookButton.TabIndex = 13;
            this.cancelBookButton.Text = "取消";
            this.cancelBookButton.UseVisualStyleBackColor = false;
            // 
            // copyEditorTab
            // 
            this.copyEditorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(245)))));
            this.copyEditorTab.Controls.Add(this.copyBarcodeTextBoxCaption);
            this.copyEditorTab.Controls.Add(this.copyBarcodeTextBox);
            this.copyEditorTab.Controls.Add(this.copyLocationTextBoxCaption);
            this.copyEditorTab.Controls.Add(this.copyLocationTextBox);
            this.copyEditorTab.Controls.Add(this.copyStateCaption);
            this.copyEditorTab.Controls.Add(this.copyStateCombo);
            this.copyEditorTab.Controls.Add(this.saveCopyButton);
            this.copyEditorTab.Location = new System.Drawing.Point(4, 32);
            this.copyEditorTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyEditorTab.Name = "copyEditorTab";
            this.copyEditorTab.Size = new System.Drawing.Size(362, 499);
            this.copyEditorTab.TabIndex = 1;
            this.copyEditorTab.Text = "复本资料";
            // 
            // copyBarcodeTextBoxCaption
            // 
            this.copyBarcodeTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.copyBarcodeTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.copyBarcodeTextBoxCaption.Location = new System.Drawing.Point(19, 25);
            this.copyBarcodeTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyBarcodeTextBoxCaption.Name = "copyBarcodeTextBoxCaption";
            this.copyBarcodeTextBoxCaption.Size = new System.Drawing.Size(312, 31);
            this.copyBarcodeTextBoxCaption.TabIndex = 0;
            this.copyBarcodeTextBoxCaption.Text = "复本条码";
            // 
            // copyBarcodeTextBox
            // 
            this.copyBarcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copyBarcodeTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.copyBarcodeTextBox.Location = new System.Drawing.Point(19, 68);
            this.copyBarcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyBarcodeTextBox.Name = "copyBarcodeTextBox";
            this.copyBarcodeTextBox.Size = new System.Drawing.Size(317, 31);
            this.copyBarcodeTextBox.TabIndex = 1;
            // 
            // copyLocationTextBoxCaption
            // 
            this.copyLocationTextBoxCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.copyLocationTextBoxCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.copyLocationTextBoxCaption.Location = new System.Drawing.Point(19, 122);
            this.copyLocationTextBoxCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyLocationTextBoxCaption.Name = "copyLocationTextBoxCaption";
            this.copyLocationTextBoxCaption.Size = new System.Drawing.Size(312, 31);
            this.copyLocationTextBoxCaption.TabIndex = 2;
            this.copyLocationTextBoxCaption.Text = "馆藏位置";
            // 
            // copyLocationTextBox
            // 
            this.copyLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copyLocationTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F);
            this.copyLocationTextBox.Location = new System.Drawing.Point(19, 165);
            this.copyLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyLocationTextBox.Name = "copyLocationTextBox";
            this.copyLocationTextBox.Size = new System.Drawing.Size(317, 31);
            this.copyLocationTextBox.TabIndex = 3;
            // 
            // copyStateCaption
            // 
            this.copyStateCaption.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.copyStateCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(122)))));
            this.copyStateCaption.Location = new System.Drawing.Point(19, 222);
            this.copyStateCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyStateCaption.Name = "copyStateCaption";
            this.copyStateCaption.Size = new System.Drawing.Size(318, 31);
            this.copyStateCaption.TabIndex = 4;
            this.copyStateCaption.Text = "馆藏状态";
            // 
            // copyStateCombo
            // 
            this.copyStateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.copyStateCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyStateCombo.Items.AddRange(new object[] {
            "可借",
            "借出",
            "遗失",
            "报废"});
            this.copyStateCombo.Location = new System.Drawing.Point(19, 265);
            this.copyStateCombo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyStateCombo.Name = "copyStateCombo";
            this.copyStateCombo.Size = new System.Drawing.Size(316, 31);
            this.copyStateCombo.TabIndex = 5;
            // 
            // saveCopyButton
            // 
            this.saveCopyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveCopyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCopyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(100)))), ((int)(((byte)(82)))));
            this.saveCopyButton.FlatAppearance.BorderSize = 0;
            this.saveCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveCopyButton.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.saveCopyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.saveCopyButton.Location = new System.Drawing.Point(19, 406);
            this.saveCopyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveCopyButton.Name = "saveCopyButton";
            this.saveCopyButton.Size = new System.Drawing.Size(318, 49);
            this.saveCopyButton.TabIndex = 6;
            this.saveCopyButton.Text = "保存复本";
            this.saveCopyButton.UseVisualStyleBackColor = false;
            // 
            // BookManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.pageTitle);
            this.Controls.Add(this.bookTitleFilterCaption);
            this.Controls.Add(this.bookTitleFilter);
            this.Controls.Add(this.authorFilterCaption);
            this.Controls.Add(this.authorFilter);
            this.Controls.Add(this.isbnFilterCaption);
            this.Controls.Add(this.isbnFilter);
            this.Controls.Add(this.searchBooksButton);
            this.Controls.Add(this.resetBooksButton);
            this.Controls.Add(this.bookToolbarLine);
            this.Controls.Add(this.bookListLabel);
            this.Controls.Add(this.newBookButton);
            this.Controls.Add(this.editBookButton);
            this.Controls.Add(this.deleteBookButton);
            this.Controls.Add(this.booksGrid);
            this.Controls.Add(this.copyListLabel);
            this.Controls.Add(this.newCopyButton);
            this.Controls.Add(this.editCopyButton);
            this.Controls.Add(this.deleteCopyButton);
            this.Controls.Add(this.copiesGrid);
            this.Controls.Add(this.bookEditorTabs);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookManagementView";
            this.Size = new System.Drawing.Size(1312, 808);
            ((System.ComponentModel.ISupportInitialize)(this.booksGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesGrid)).EndInit();
            this.bookEditorTabs.ResumeLayout(false);
            this.bibliographyTab.ResumeLayout(false);
            this.bibliographyTab.PerformLayout();
            this.copyEditorTab.ResumeLayout(false);
            this.copyEditorTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label pageTitle;

        private System.Windows.Forms.Label bookTitleFilterCaption;
        private System.Windows.Forms.TextBox bookTitleFilter;
        private System.Windows.Forms.Label authorFilterCaption;
        private System.Windows.Forms.TextBox authorFilter;
        private System.Windows.Forms.Label isbnFilterCaption;
        private System.Windows.Forms.TextBox isbnFilter;
        private System.Windows.Forms.Button searchBooksButton;
        private System.Windows.Forms.Button resetBooksButton;
        private System.Windows.Forms.Panel bookToolbarLine;
        private System.Windows.Forms.Label bookListLabel;
        private System.Windows.Forms.Button newBookButton;
        private System.Windows.Forms.Button editBookButton;
        private System.Windows.Forms.Button deleteBookButton;
        private System.Windows.Forms.DataGridView booksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksGridIsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksGridTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksGridAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksGridCategory;

        private System.Windows.Forms.Label copyListLabel;
        private System.Windows.Forms.Button newCopyButton;
        private System.Windows.Forms.Button editCopyButton;
        private System.Windows.Forms.Button deleteCopyButton;
        private System.Windows.Forms.DataGridView copiesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesGridBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesGridLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesGridState;
        private System.Windows.Forms.DataGridViewTextBoxColumn copiesGridDate;

        private System.Windows.Forms.TabControl bookEditorTabs;
        private System.Windows.Forms.TabPage bibliographyTab;
        private System.Windows.Forms.Label isbnTextBoxCaption;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label bookTitleTextBoxCaption;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Label authorTextBoxCaption;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label publisherTextBoxCaption;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.Label categoryTextBoxCaption;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label yearTextBoxCaption;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button saveBookButton;
        private System.Windows.Forms.Button cancelBookButton;
        private System.Windows.Forms.TabPage copyEditorTab;
        private System.Windows.Forms.Label copyBarcodeTextBoxCaption;
        private System.Windows.Forms.TextBox copyBarcodeTextBox;
        private System.Windows.Forms.Label copyLocationTextBoxCaption;
        private System.Windows.Forms.TextBox copyLocationTextBox;
        private System.Windows.Forms.Label copyStateCaption;
        private System.Windows.Forms.ComboBox copyStateCombo;
        private System.Windows.Forms.Button saveCopyButton;
    }
}
