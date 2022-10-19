namespace Library
{
    partial class Edit_Books
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
            System.Windows.Forms.Label book_idLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label publication_yearLabel;
            System.Windows.Forms.Label brief_descriptionLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label original_languageLabel;
            System.Windows.Forms.Label number_of_pagesLabel;
            System.Windows.Forms.Label text_of_the_bookLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Books));
            this.libraryDataSet = new Library.LibraryDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Library.LibraryDataSetTableAdapters.TableAdapterManager();
            this.book_AuthorTableAdapter = new Library.LibraryDataSetTableAdapters.Book_AuthorTableAdapter();
            this.book_PublisherTableAdapter = new Library.LibraryDataSetTableAdapters.Book_PublisherTableAdapter();
            this.booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.book_idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.publication_yearTextBox = new System.Windows.Forms.TextBox();
            this.brief_descriptionTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.original_languageTextBox = new System.Windows.Forms.TextBox();
            this.number_of_pagesTextBox = new System.Windows.Forms.TextBox();
            this.text_of_the_bookTextBox = new System.Windows.Forms.TextBox();
            this.book_AuthorDataGridView = new System.Windows.Forms.DataGridView();
            this.book_PublisherDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_PublisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_AuthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            book_idLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            publication_yearLabel = new System.Windows.Forms.Label();
            brief_descriptionLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            original_languageLabel = new System.Windows.Forms.Label();
            number_of_pagesLabel = new System.Windows.Forms.Label();
            text_of_the_bookLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).BeginInit();
            this.booksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.Location = new System.Drawing.Point(12, 39);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(56, 16);
            book_idLabel.TabIndex = 1;
            book_idLabel.Text = "Book id:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 67);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 16);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // publication_yearLabel
            // 
            publication_yearLabel.AutoSize = true;
            publication_yearLabel.Location = new System.Drawing.Point(12, 95);
            publication_yearLabel.Name = "publication_yearLabel";
            publication_yearLabel.Size = new System.Drawing.Size(106, 16);
            publication_yearLabel.TabIndex = 5;
            publication_yearLabel.Text = "Publication year:";
            // 
            // brief_descriptionLabel
            // 
            brief_descriptionLabel.AutoSize = true;
            brief_descriptionLabel.Location = new System.Drawing.Point(11, 177);
            brief_descriptionLabel.Name = "brief_descriptionLabel";
            brief_descriptionLabel.Size = new System.Drawing.Size(106, 16);
            brief_descriptionLabel.TabIndex = 7;
            brief_descriptionLabel.Text = "Brief description:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(12, 249);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(47, 16);
            genreLabel.TabIndex = 9;
            genreLabel.Text = "Genre:";
            // 
            // original_languageLabel
            // 
            original_languageLabel.AutoSize = true;
            original_languageLabel.Location = new System.Drawing.Point(12, 277);
            original_languageLabel.Name = "original_languageLabel";
            original_languageLabel.Size = new System.Drawing.Size(116, 16);
            original_languageLabel.TabIndex = 11;
            original_languageLabel.Text = "Original language:";
            // 
            // number_of_pagesLabel
            // 
            number_of_pagesLabel.AutoSize = true;
            number_of_pagesLabel.Location = new System.Drawing.Point(12, 305);
            number_of_pagesLabel.Name = "number_of_pagesLabel";
            number_of_pagesLabel.Size = new System.Drawing.Size(114, 16);
            number_of_pagesLabel.TabIndex = 13;
            number_of_pagesLabel.Text = "Number of pages:";
            // 
            // text_of_the_bookLabel
            // 
            text_of_the_bookLabel.AutoSize = true;
            text_of_the_bookLabel.Location = new System.Drawing.Point(12, 333);
            text_of_the_bookLabel.Name = "text_of_the_bookLabel";
            text_of_the_bookLabel.Size = new System.Drawing.Size(105, 16);
            text_of_the_bookLabel.TabIndex = 15;
            text_of_the_bookLabel.Text = "Text of the book:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_AuthorTableAdapter = this.book_AuthorTableAdapter;
            this.tableAdapterManager.Book_PublisherTableAdapter = this.book_PublisherTableAdapter;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // book_AuthorTableAdapter
            // 
            this.book_AuthorTableAdapter.ClearBeforeFill = true;
            // 
            // book_PublisherTableAdapter
            // 
            this.book_PublisherTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingNavigator
            // 
            this.booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booksBindingNavigator.BindingSource = this.booksBindingSource;
            this.booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.booksBindingNavigatorSaveItem});
            this.booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booksBindingNavigator.Name = "booksBindingNavigator";
            this.booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booksBindingNavigator.Size = new System.Drawing.Size(1328, 27);
            this.booksBindingNavigator.TabIndex = 0;
            this.booksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // booksBindingNavigatorSaveItem
            // 
            this.booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booksBindingNavigatorSaveItem.Image")));
            this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
            this.booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.booksBindingNavigatorSaveItem.Text = "Save Data";
            this.booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.booksBindingNavigatorSaveItem_Click);
            // 
            // book_idTextBox
            // 
            this.book_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Book_id", true));
            this.book_idTextBox.Location = new System.Drawing.Point(134, 36);
            this.book_idTextBox.Name = "book_idTextBox";
            this.book_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.book_idTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(134, 64);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(320, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // publication_yearTextBox
            // 
            this.publication_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Publication year", true));
            this.publication_yearTextBox.Location = new System.Drawing.Point(134, 92);
            this.publication_yearTextBox.Name = "publication_yearTextBox";
            this.publication_yearTextBox.Size = new System.Drawing.Size(100, 22);
            this.publication_yearTextBox.TabIndex = 6;
            // 
            // brief_descriptionTextBox
            // 
            this.brief_descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Brief description", true));
            this.brief_descriptionTextBox.Location = new System.Drawing.Point(134, 120);
            this.brief_descriptionTextBox.Multiline = true;
            this.brief_descriptionTextBox.Name = "brief_descriptionTextBox";
            this.brief_descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.brief_descriptionTextBox.Size = new System.Drawing.Size(535, 120);
            this.brief_descriptionTextBox.TabIndex = 8;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(134, 246);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(320, 22);
            this.genreTextBox.TabIndex = 10;
            // 
            // original_languageTextBox
            // 
            this.original_languageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Original language", true));
            this.original_languageTextBox.Location = new System.Drawing.Point(134, 274);
            this.original_languageTextBox.Name = "original_languageTextBox";
            this.original_languageTextBox.Size = new System.Drawing.Size(320, 22);
            this.original_languageTextBox.TabIndex = 12;
            // 
            // number_of_pagesTextBox
            // 
            this.number_of_pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Number of pages", true));
            this.number_of_pagesTextBox.Location = new System.Drawing.Point(134, 302);
            this.number_of_pagesTextBox.Name = "number_of_pagesTextBox";
            this.number_of_pagesTextBox.Size = new System.Drawing.Size(100, 22);
            this.number_of_pagesTextBox.TabIndex = 14;
            // 
            // text_of_the_bookTextBox
            // 
            this.text_of_the_bookTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Text of the book", true));
            this.text_of_the_bookTextBox.Location = new System.Drawing.Point(134, 330);
            this.text_of_the_bookTextBox.Name = "text_of_the_bookTextBox";
            this.text_of_the_bookTextBox.Size = new System.Drawing.Size(320, 22);
            this.text_of_the_bookTextBox.TabIndex = 16;
            // 
            // book_AuthorDataGridView
            // 
            this.book_AuthorDataGridView.AutoGenerateColumns = false;
            this.book_AuthorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_AuthorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.book_AuthorDataGridView.DataSource = this.book_AuthorBindingSource;
            this.book_AuthorDataGridView.Location = new System.Drawing.Point(15, 383);
            this.book_AuthorDataGridView.Name = "book_AuthorDataGridView";
            this.book_AuthorDataGridView.RowHeadersWidth = 51;
            this.book_AuthorDataGridView.RowTemplate.Height = 24;
            this.book_AuthorDataGridView.Size = new System.Drawing.Size(663, 109);
            this.book_AuthorDataGridView.TabIndex = 17;
            // 
            // book_PublisherDataGridView
            // 
            this.book_PublisherDataGridView.AutoGenerateColumns = false;
            this.book_PublisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_PublisherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.book_PublisherDataGridView.DataSource = this.book_PublisherBindingSource;
            this.book_PublisherDataGridView.Location = new System.Drawing.Point(15, 498);
            this.book_PublisherDataGridView.Name = "book_PublisherDataGridView";
            this.book_PublisherDataGridView.RowHeadersWidth = 51;
            this.book_PublisherDataGridView.RowTemplate.Height = 24;
            this.book_PublisherDataGridView.Size = new System.Drawing.Size(663, 119);
            this.book_PublisherDataGridView.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 61);
            this.button1.TabIndex = 19;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Relation_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Relation_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Book_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Book_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Publisher_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "Publisher_id";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "The year of publishing";
            this.dataGridViewTextBoxColumn7.HeaderText = "The year of publishing";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // book_PublisherBindingSource
            // 
            this.book_PublisherBindingSource.DataMember = "BooksBook_Publisher";
            this.book_PublisherBindingSource.DataSource = this.booksBindingSource;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Relation_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Relation_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Book_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Book_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // book_AuthorBindingSource
            // 
            this.book_AuthorBindingSource.DataMember = "BooksBook_Author";
            this.book_AuthorBindingSource.DataSource = this.booksBindingSource;
            // 
            // Edit_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.book_PublisherDataGridView);
            this.Controls.Add(this.book_AuthorDataGridView);
            this.Controls.Add(book_idLabel);
            this.Controls.Add(this.book_idTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(publication_yearLabel);
            this.Controls.Add(this.publication_yearTextBox);
            this.Controls.Add(brief_descriptionLabel);
            this.Controls.Add(this.brief_descriptionTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(original_languageLabel);
            this.Controls.Add(this.original_languageTextBox);
            this.Controls.Add(number_of_pagesLabel);
            this.Controls.Add(this.number_of_pagesTextBox);
            this.Controls.Add(text_of_the_bookLabel);
            this.Controls.Add(this.text_of_the_bookTextBox);
            this.Controls.Add(this.booksBindingNavigator);
            this.Name = "Edit_Books";
            this.Text = "Edit_Books";
            this.Load += new System.EventHandler(this.Edit_Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).EndInit();
            this.booksBindingNavigator.ResumeLayout(false);
            this.booksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator booksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton booksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox book_idTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox publication_yearTextBox;
        private System.Windows.Forms.TextBox brief_descriptionTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox original_languageTextBox;
        private System.Windows.Forms.TextBox number_of_pagesTextBox;
        private System.Windows.Forms.TextBox text_of_the_bookTextBox;
        private LibraryDataSetTableAdapters.Book_AuthorTableAdapter book_AuthorTableAdapter;
        private System.Windows.Forms.BindingSource book_AuthorBindingSource;
        private LibraryDataSetTableAdapters.Book_PublisherTableAdapter book_PublisherTableAdapter;
        private System.Windows.Forms.DataGridView book_AuthorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource book_PublisherBindingSource;
        private System.Windows.Forms.DataGridView book_PublisherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button1;
    }
}