using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System;
using System.Windows.Forms;

namespace Library_manage.Views
{
    public partial class BookManagementView : UserControl
    {
        public BookManagementView()
        {
            InitializeComponent();
            if (!ScreenData.IsDesignMode(this))
            {
                InitializeData();
            }
        }

        private void newBookButton_Click(object sender, EventArgs e)
        {
            BeginBook(true);
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            BeginBook(false);
        }

        private void newCopyButton_Click(object sender, EventArgs e)
        {
            BeginCopy(true);
        }

        private void editCopyButton_Click(object sender, EventArgs e)
        {
            BeginCopy(false);
        }
        private int editBook,editCopy,copyBook;
        private void InitializeData()
        {
            if (ScreenData.IsDesignMode(this)) return;
            saveBookButton.Enabled=false;saveCopyButton.Enabled=false;copyStateCombo.Items.Clear();copyStateCombo.Items.AddRange(new object[]{"可借","停用"});
            VisibleChanged+=delegate {if(!ScreenData.IsDesignMode(this) && Visible && Database.AdminID>0)ScreenData.Run(RefreshBooks);};
            searchBooksButton.Click+=delegate {ScreenData.Run(RefreshBooks);};
            resetBooksButton.Click+=delegate {bookTitleFilter.Clear();authorFilter.Clear();isbnFilter.Clear();ScreenData.Run(RefreshBooks);};
            booksGrid.SelectionChanged+=delegate {saveBookButton.Enabled=false;saveCopyButton.Enabled=false;ScreenData.Run(FillBook);};
            copiesGrid.SelectionChanged+=delegate {saveCopyButton.Enabled=false;FillCopy();};
            saveBookButton.Click+=delegate {ScreenData.Run(SaveBook);};cancelBookButton.Click+=delegate {saveBookButton.Enabled=false;ScreenData.Run(FillBook);};
            saveCopyButton.Click+=delegate {ScreenData.Run(SaveCopy);};
            deleteBookButton.Click+=delegate {ScreenData.Run(delegate {DataRow r=ScreenData.Need(booksGrid);if(MessageBox.Show("删除所选书目？已有馆藏复本的书目不能删除。","删除",MessageBoxButtons.OKCancel)!=DialogResult.OK)return;Database.Write("删除书目","Book",r["BookID"],"DELETE dbo.Book WHERE BookID=@id",Database.P("@id",r["BookID"]));RefreshBooks();});};
            deleteCopyButton.Click+=delegate {ScreenData.Run(delegate {DataRow r=ScreenData.Need(copiesGrid);if(r["Status"].ToString()!="可借" && r["Status"].ToString()!="停用")throw new Exception("在借或遗失复本不能删除。");if(MessageBox.Show("删除所选复本？有借阅历史的复本不能删除。","删除",MessageBoxButtons.OKCancel)!=DialogResult.OK)return;Database.Write("删除复本","BookCopy",r["CopyID"],"DELETE dbo.BookCopy WHERE CopyID=@id AND Status IN(N'可借',N'停用')",Database.P("@id",r["CopyID"]));FillBook();});};
        }
        private void RefreshBooks()
        {
            Database.RequireAdmin();saveBookButton.Enabled=false;saveCopyButton.Enabled=false;DataTable d=Database.Query("SELECT * FROM dbo.Book WHERE BookName LIKE @n AND ISNULL(Author,N'') LIKE @a AND ISNULL(ISBN,N'') LIKE @i ORDER BY BookID DESC",Database.P("@n","%"+bookTitleFilter.Text.Trim()+"%"),Database.P("@a","%"+authorFilter.Text.Trim()+"%"),Database.P("@i","%"+isbnFilter.Text.Trim()+"%"));
            ScreenData.Bind(booksGrid,d,"ISBN","BookName","Author","Category");FillBook();
        }
        private void FillBook()
        {
            DataRow r=ScreenData.Row(booksGrid);
            if(r==null){isbnTextBox.Clear();bookTitleTextBox.Clear();authorTextBox.Clear();publisherTextBox.Clear();categoryTextBox.Clear();yearTextBox.Clear();copiesGrid.DataSource=null;FillCopy();return;}
            isbnTextBox.Text=r["ISBN"].ToString();bookTitleTextBox.Text=r["BookName"].ToString();authorTextBox.Text=r["Author"].ToString();publisherTextBox.Text=r["Publisher"].ToString();categoryTextBox.Text=r["Category"].ToString();yearTextBox.Text=r["PublishYear"].ToString();
            ScreenData.Bind(copiesGrid,Database.Query("SELECT * FROM dbo.BookCopy WHERE BookID=@id ORDER BY CopyID",Database.P("@id",r["BookID"])),"Barcode","Location","Status","EntryDate");
        }
        private void FillCopy() {DataRow r=ScreenData.Row(copiesGrid);if(r==null){copyBarcodeTextBox.Clear();copyLocationTextBox.Clear();copyStateCombo.SelectedIndex=-1;return;}copyBarcodeTextBox.Text=r["Barcode"].ToString();copyLocationTextBox.Text=r["Location"].ToString();copyStateCombo.SelectedIndex=-1;if(copyStateCombo.Items.Contains(r["Status"].ToString()))copyStateCombo.Text=r["Status"].ToString();}
        private void BeginBook(bool create)
        {
            ScreenData.Run(delegate {editBook=create?0:Convert.ToInt32(ScreenData.Need(booksGrid)["BookID"]);if(create){isbnTextBox.Clear();bookTitleTextBox.Clear();authorTextBox.Clear();publisherTextBox.Clear();categoryTextBox.Clear();yearTextBox.Clear();}else FillBook();bookEditorTabs.SelectedTab=bibliographyTab;saveBookButton.Enabled=true;});
        }
        private void BeginCopy(bool create)
        {
            ScreenData.Run(delegate {copyBook=Convert.ToInt32(ScreenData.Need(booksGrid)["BookID"]);editCopy=create?0:Convert.ToInt32(ScreenData.Need(copiesGrid)["CopyID"]);if(!create){string s=ScreenData.Need(copiesGrid)["Status"].ToString();if(s!="可借" && s!="停用")throw new Exception("在借或遗失复本不能直接修改状态。");FillCopy();}else{copyBarcodeTextBox.Clear();copyLocationTextBox.Clear();copyStateCombo.Text="可借";}bookEditorTabs.SelectedTab=copyEditorTab;saveCopyButton.Enabled=true;});
        }
        private void SaveBook()
        {
            if(!saveBookButton.Enabled)throw new Exception("请先点击新增或修改书目。");
            int year;object y=null;if(yearTextBox.Text.Trim()!=""){if(!int.TryParse(yearTextBox.Text,out year)||year<1000||year>9999)throw new Exception("出版年份须为四位数字。");y=year;}
            Database.Write("书目维护","Book",editBook,editBook==0?"INSERT dbo.Book(ISBN,BookName,Author,Publisher,Category,PublishYear) VALUES(@i,@n,@a,@p,@c,@y)":"UPDATE dbo.Book SET ISBN=@i,BookName=@n,Author=@a,Publisher=@p,Category=@c,PublishYear=@y WHERE BookID=@id",Database.P("@id",editBook),Database.P("@i",string.IsNullOrWhiteSpace(isbnTextBox.Text)?null:isbnTextBox.Text.Trim()),Database.P("@n",ScreenData.Required(bookTitleTextBox,"书名")),Database.P("@a",authorTextBox.Text.Trim()),Database.P("@p",publisherTextBox.Text.Trim()),Database.P("@c",categoryTextBox.Text.Trim()),Database.P("@y",y));saveBookButton.Enabled=false;try{RefreshBooks();}catch(Exception ex){MessageBox.Show("书目已保存，但列表刷新失败，请重新查询。\n"+ex.Message,"保存结果");}
        }
        private void SaveCopy()
        {
            if(!saveCopyButton.Enabled)throw new Exception("请先点击新增或修改复本。");
            if(copyStateCombo.Text!="可借" && copyStateCombo.Text!="停用")throw new Exception("请选择有效的复本状态。");
            Database.Write("复本维护","BookCopy",editCopy,editCopy==0?"INSERT dbo.BookCopy(BookID,Barcode,Location,Status) VALUES(@book,@b,@l,@s)":"UPDATE dbo.BookCopy SET Barcode=@b,Location=@l,Status=@s WHERE CopyID=@id AND Status IN(N'可借',N'停用')",Database.P("@id",editCopy),Database.P("@book",copyBook),Database.P("@b",ScreenData.Required(copyBarcodeTextBox,"复本条码")),Database.P("@l",copyLocationTextBox.Text.Trim()),Database.P("@s",copyStateCombo.Text));saveCopyButton.Enabled=false;try{FillBook();}catch(Exception ex){MessageBox.Show("复本已保存，但列表刷新失败，请重新查询。\n"+ex.Message,"保存结果");}
        }
    }
}
