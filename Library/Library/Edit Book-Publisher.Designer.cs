namespace Library
{
    partial class Edit_Book_Publisher
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
            System.Windows.Forms.Label relation_idLabel;
            System.Windows.Forms.Label book_idLabel;
            System.Windows.Forms.Label publisher_idLabel;
            System.Windows.Forms.Label the_year_of_publishingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Book_Publisher));
            this.libraryDataSet = new Library.LibraryDataSet();
            this.book_PublisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_PublisherTableAdapter = new Library.LibraryDataSetTableAdapters.Book_PublisherTableAdapter();
            this.tableAdapterManager = new Library.LibraryDataSetTableAdapters.TableAdapterManager();
            this.booksTableAdapter = new Library.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.book_PublisherBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.book_PublisherBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.relation_idTextBox = new System.Windows.Forms.TextBox();
            this.book_idTextBox = new System.Windows.Forms.TextBox();
            this.publisher_idTextBox = new System.Windows.Forms.TextBox();
            this.the_year_of_publishingTextBox = new System.Windows.Forms.TextBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersTableAdapter = new Library.LibraryDataSetTableAdapters.PublishersTableAdapter();
            this.publishersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            relation_idLabel = new System.Windows.Forms.Label();
            book_idLabel = new System.Windows.Forms.Label();
            publisher_idLabel = new System.Windows.Forms.Label();
            the_year_of_publishingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingNavigator)).BeginInit();
            this.book_PublisherBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relation_idLabel
            // 
            relation_idLabel.AutoSize = true;
            relation_idLabel.Location = new System.Drawing.Point(12, 43);
            relation_idLabel.Name = "relation_idLabel";
            relation_idLabel.Size = new System.Drawing.Size(74, 16);
            relation_idLabel.TabIndex = 1;
            relation_idLabel.Text = "Relation id:";
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.Location = new System.Drawing.Point(12, 71);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(56, 16);
            book_idLabel.TabIndex = 3;
            book_idLabel.Text = "Book id:";
            // 
            // publisher_idLabel
            // 
            publisher_idLabel.AutoSize = true;
            publisher_idLabel.Location = new System.Drawing.Point(12, 99);
            publisher_idLabel.Name = "publisher_idLabel";
            publisher_idLabel.Size = new System.Drawing.Size(80, 16);
            publisher_idLabel.TabIndex = 5;
            publisher_idLabel.Text = "Publisher id:";
            // 
            // the_year_of_publishingLabel
            // 
            the_year_of_publishingLabel.AutoSize = true;
            the_year_of_publishingLabel.Location = new System.Drawing.Point(12, 127);
            the_year_of_publishingLabel.Name = "the_year_of_publishingLabel";
            the_year_of_publishingLabel.Size = new System.Drawing.Size(142, 16);
            the_year_of_publishingLabel.TabIndex = 7;
            the_year_of_publishingLabel.Text = "The year of publishing:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_PublisherBindingSource
            // 
            this.book_PublisherBindingSource.DataMember = "Book_Publisher";
            this.book_PublisherBindingSource.DataSource = this.libraryDataSet;
            // 
            // book_PublisherTableAdapter
            // 
            this.book_PublisherTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_AuthorTableAdapter = null;
            this.tableAdapterManager.Book_PublisherTableAdapter = this.book_PublisherTableAdapter;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // book_PublisherBindingNavigator
            // 
            this.book_PublisherBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.book_PublisherBindingNavigator.BindingSource = this.book_PublisherBindingSource;
            this.book_PublisherBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.book_PublisherBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.book_PublisherBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.book_PublisherBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.book_PublisherBindingNavigatorSaveItem});
            this.book_PublisherBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.book_PublisherBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.book_PublisherBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.book_PublisherBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.book_PublisherBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.book_PublisherBindingNavigator.Name = "book_PublisherBindingNavigator";
            this.book_PublisherBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.book_PublisherBindingNavigator.Size = new System.Drawing.Size(1352, 27);
            this.book_PublisherBindingNavigator.TabIndex = 0;
            this.book_PublisherBindingNavigator.Text = "bindingNavigator1";
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
            // book_PublisherBindingNavigatorSaveItem
            // 
            this.book_PublisherBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.book_PublisherBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("book_PublisherBindingNavigatorSaveItem.Image")));
            this.book_PublisherBindingNavigatorSaveItem.Name = "book_PublisherBindingNavigatorSaveItem";
            this.book_PublisherBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.book_PublisherBindingNavigatorSaveItem.Text = "Save Data";
            this.book_PublisherBindingNavigatorSaveItem.Click += new System.EventHandler(this.book_PublisherBindingNavigatorSaveItem_Click);
            // 
            // relation_idTextBox
            // 
            this.relation_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.book_PublisherBindingSource, "Relation_id", true));
            this.relation_idTextBox.Location = new System.Drawing.Point(160, 40);
            this.relation_idTextBox.Name = "relation_idTextBox";
            this.relation_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.relation_idTextBox.TabIndex = 2;
            // 
            // book_idTextBox
            // 
            this.book_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.book_PublisherBindingSource, "Book_id", true));
            this.book_idTextBox.Location = new System.Drawing.Point(160, 68);
            this.book_idTextBox.Name = "book_idTextBox";
            this.book_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.book_idTextBox.TabIndex = 4;
            // 
            // publisher_idTextBox
            // 
            this.publisher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.book_PublisherBindingSource, "Publisher_id", true));
            this.publisher_idTextBox.Location = new System.Drawing.Point(160, 96);
            this.publisher_idTextBox.Name = "publisher_idTextBox";
            this.publisher_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.publisher_idTextBox.TabIndex = 6;
            // 
            // the_year_of_publishingTextBox
            // 
            this.the_year_of_publishingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.book_PublisherBindingSource, "The year of publishing", true));
            this.the_year_of_publishingTextBox.Location = new System.Drawing.Point(160, 124);
            this.the_year_of_publishingTextBox.Name = "the_year_of_publishingTextBox";
            this.the_year_of_publishingTextBox.Size = new System.Drawing.Size(100, 22);
            this.the_year_of_publishingTextBox.TabIndex = 8;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 186);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowHeadersWidth = 51;
            this.booksDataGridView.RowTemplate.Height = 24;
            this.booksDataGridView.Size = new System.Drawing.Size(1116, 168);
            this.booksDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Publication year";
            this.dataGridViewTextBoxColumn3.HeaderText = "Publication year";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Brief description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Brief description";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Original language";
            this.dataGridViewTextBoxColumn6.HeaderText = "Original language";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Number of pages";
            this.dataGridViewTextBoxColumn7.HeaderText = "Number of pages";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Text of the book";
            this.dataGridViewTextBoxColumn8.HeaderText = "Text of the book";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.libraryDataSet;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // publishersDataGridView
            // 
            this.publishersDataGridView.AutoGenerateColumns = false;
            this.publishersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publishersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.publishersDataGridView.DataSource = this.publishersBindingSource;
            this.publishersDataGridView.Location = new System.Drawing.Point(15, 377);
            this.publishersDataGridView.Name = "publishersDataGridView";
            this.publishersDataGridView.RowHeadersWidth = 51;
            this.publishersDataGridView.RowTemplate.Height = 24;
            this.publishersDataGridView.Size = new System.Drawing.Size(1113, 168);
            this.publishersDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Publisher_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Publisher_id";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn10.HeaderText = "Title";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn11.HeaderText = "Country";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Foundation year";
            this.dataGridViewTextBoxColumn12.HeaderText = "Foundation year";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Director\'s full name";
            this.dataGridViewTextBoxColumn13.HeaderText = "Director\'s full name";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit_Book_Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 759);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.publishersDataGridView);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(relation_idLabel);
            this.Controls.Add(this.relation_idTextBox);
            this.Controls.Add(book_idLabel);
            this.Controls.Add(this.book_idTextBox);
            this.Controls.Add(publisher_idLabel);
            this.Controls.Add(this.publisher_idTextBox);
            this.Controls.Add(the_year_of_publishingLabel);
            this.Controls.Add(this.the_year_of_publishingTextBox);
            this.Controls.Add(this.book_PublisherBindingNavigator);
            this.Name = "Edit_Book_Publisher";
            this.Text = "Edit Book-Publisher";
            this.Load += new System.EventHandler(this.Edit_Book_Publisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingNavigator)).EndInit();
            this.book_PublisherBindingNavigator.ResumeLayout(false);
            this.book_PublisherBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource book_PublisherBindingSource;
        private LibraryDataSetTableAdapters.Book_PublisherTableAdapter book_PublisherTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator book_PublisherBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton book_PublisherBindingNavigatorSaveItem;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.TextBox relation_idTextBox;
        private System.Windows.Forms.TextBox book_idTextBox;
        private System.Windows.Forms.TextBox publisher_idTextBox;
        private System.Windows.Forms.TextBox the_year_of_publishingTextBox;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LibraryDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.DataGridView publishersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button button1;
    }
}