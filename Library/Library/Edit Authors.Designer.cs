namespace Library
{
    partial class Edit_Authors
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
            System.Windows.Forms.Label author_idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label date_of_birthLabel;
            System.Windows.Forms.Label date_of_deathLabel;
            System.Windows.Forms.Label nationalityLabel;
            System.Windows.Forms.Label genderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Authors));
            this.libraryDataSet = new Library.LibraryDataSet();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new Library.LibraryDataSetTableAdapters.AuthorsTableAdapter();
            this.tableAdapterManager = new Library.LibraryDataSetTableAdapters.TableAdapterManager();
            this.book_AuthorTableAdapter = new Library.LibraryDataSetTableAdapters.Book_AuthorTableAdapter();
            this.authorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.authorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.author_idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.date_of_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_of_deathDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.book_AuthorDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_AuthorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            author_idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            date_of_birthLabel = new System.Windows.Forms.Label();
            date_of_deathLabel = new System.Windows.Forms.Label();
            nationalityLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingNavigator)).BeginInit();
            this.authorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // author_idLabel
            // 
            author_idLabel.AutoSize = true;
            author_idLabel.Location = new System.Drawing.Point(12, 40);
            author_idLabel.Name = "author_idLabel";
            author_idLabel.Size = new System.Drawing.Size(62, 16);
            author_idLabel.TabIndex = 1;
            author_idLabel.Text = "Author id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 16);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(12, 96);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(64, 16);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(12, 124);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(77, 16);
            patronymicLabel.TabIndex = 7;
            patronymicLabel.Text = "Patronymic:";
            // 
            // date_of_birthLabel
            // 
            date_of_birthLabel.AutoSize = true;
            date_of_birthLabel.Location = new System.Drawing.Point(12, 153);
            date_of_birthLabel.Name = "date_of_birthLabel";
            date_of_birthLabel.Size = new System.Drawing.Size(81, 16);
            date_of_birthLabel.TabIndex = 9;
            date_of_birthLabel.Text = "Date of birth:";
            // 
            // date_of_deathLabel
            // 
            date_of_deathLabel.AutoSize = true;
            date_of_deathLabel.Location = new System.Drawing.Point(12, 181);
            date_of_deathLabel.Name = "date_of_deathLabel";
            date_of_deathLabel.Size = new System.Drawing.Size(90, 16);
            date_of_deathLabel.TabIndex = 11;
            date_of_deathLabel.Text = "Date of death:";
            // 
            // nationalityLabel
            // 
            nationalityLabel.AutoSize = true;
            nationalityLabel.Location = new System.Drawing.Point(12, 208);
            nationalityLabel.Name = "nationalityLabel";
            nationalityLabel.Size = new System.Drawing.Size(73, 16);
            nationalityLabel.TabIndex = 13;
            nationalityLabel.Text = "Nationality:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(12, 236);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(55, 16);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "Gender:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_AuthorTableAdapter = this.book_AuthorTableAdapter;
            this.tableAdapterManager.Book_PublisherTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // book_AuthorTableAdapter
            // 
            this.book_AuthorTableAdapter.ClearBeforeFill = true;
            // 
            // authorsBindingNavigator
            // 
            this.authorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.authorsBindingNavigator.BindingSource = this.authorsBindingSource;
            this.authorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.authorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.authorsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.authorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.authorsBindingNavigatorSaveItem});
            this.authorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.authorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.authorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.authorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.authorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.authorsBindingNavigator.Name = "authorsBindingNavigator";
            this.authorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.authorsBindingNavigator.Size = new System.Drawing.Size(1129, 27);
            this.authorsBindingNavigator.TabIndex = 0;
            this.authorsBindingNavigator.Text = "bindingNavigator1";
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
            // authorsBindingNavigatorSaveItem
            // 
            this.authorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.authorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("authorsBindingNavigatorSaveItem.Image")));
            this.authorsBindingNavigatorSaveItem.Name = "authorsBindingNavigatorSaveItem";
            this.authorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.authorsBindingNavigatorSaveItem.Text = "Save Data";
            this.authorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.authorsBindingNavigatorSaveItem_Click);
            // 
            // author_idTextBox
            // 
            this.author_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "Author_id", true));
            this.author_idTextBox.Location = new System.Drawing.Point(108, 37);
            this.author_idTextBox.Name = "author_idTextBox";
            this.author_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.author_idTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(108, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(108, 93);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(200, 22);
            this.surnameTextBox.TabIndex = 6;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(108, 121);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(200, 22);
            this.patronymicTextBox.TabIndex = 8;
            // 
            // date_of_birthDateTimePicker
            // 
            this.date_of_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.authorsBindingSource, "Date of birth", true));
            this.date_of_birthDateTimePicker.Location = new System.Drawing.Point(108, 149);
            this.date_of_birthDateTimePicker.Name = "date_of_birthDateTimePicker";
            this.date_of_birthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_of_birthDateTimePicker.TabIndex = 10;
            // 
            // date_of_deathDateTimePicker
            // 
            this.date_of_deathDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.authorsBindingSource, "Date of death", true));
            this.date_of_deathDateTimePicker.Location = new System.Drawing.Point(108, 177);
            this.date_of_deathDateTimePicker.Name = "date_of_deathDateTimePicker";
            this.date_of_deathDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_of_deathDateTimePicker.TabIndex = 12;
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "Nationality", true));
            this.nationalityTextBox.Location = new System.Drawing.Point(108, 205);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(200, 22);
            this.nationalityTextBox.TabIndex = 14;
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.authorsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(108, 233);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 22);
            this.genderTextBox.TabIndex = 16;
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
            this.book_AuthorDataGridView.Location = new System.Drawing.Point(15, 284);
            this.book_AuthorDataGridView.Name = "book_AuthorDataGridView";
            this.book_AuthorDataGridView.RowHeadersWidth = 51;
            this.book_AuthorDataGridView.RowTemplate.Height = 24;
            this.book_AuthorDataGridView.Size = new System.Drawing.Size(500, 125);
            this.book_AuthorDataGridView.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.book_AuthorBindingSource.DataMember = "AuthorsBook_Author";
            this.book_AuthorBindingSource.DataSource = this.authorsBindingSource;
            // 
            // Edit_Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.book_AuthorDataGridView);
            this.Controls.Add(author_idLabel);
            this.Controls.Add(this.author_idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(date_of_birthLabel);
            this.Controls.Add(this.date_of_birthDateTimePicker);
            this.Controls.Add(date_of_deathLabel);
            this.Controls.Add(this.date_of_deathDateTimePicker);
            this.Controls.Add(nationalityLabel);
            this.Controls.Add(this.nationalityTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.authorsBindingNavigator);
            this.Name = "Edit_Authors";
            this.Text = "Edit Authors";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingNavigator)).EndInit();
            this.authorsBindingNavigator.ResumeLayout(false);
            this.authorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_AuthorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator authorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton authorsBindingNavigatorSaveItem;
        private LibraryDataSetTableAdapters.Book_AuthorTableAdapter book_AuthorTableAdapter;
        private System.Windows.Forms.TextBox author_idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.DateTimePicker date_of_birthDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_of_deathDateTimePicker;
        private System.Windows.Forms.TextBox nationalityTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.BindingSource book_AuthorBindingSource;
        private System.Windows.Forms.DataGridView book_AuthorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
    }
}