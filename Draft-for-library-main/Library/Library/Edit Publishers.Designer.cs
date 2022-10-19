namespace Library
{
    partial class Edit_Publishers
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
            System.Windows.Forms.Label publisher_idLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label foundation_yearLabel;
            System.Windows.Forms.Label director_s_full_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Publishers));
            this.libraryDataSet = new Library.LibraryDataSet();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersTableAdapter = new Library.LibraryDataSetTableAdapters.PublishersTableAdapter();
            this.tableAdapterManager = new Library.LibraryDataSetTableAdapters.TableAdapterManager();
            this.book_PublisherTableAdapter = new Library.LibraryDataSetTableAdapters.Book_PublisherTableAdapter();
            this.publishersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.publishersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.publisher_idTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.foundation_yearTextBox = new System.Windows.Forms.TextBox();
            this.director_s_full_nameTextBox = new System.Windows.Forms.TextBox();
            this.book_PublisherDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_PublisherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            publisher_idLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            foundation_yearLabel = new System.Windows.Forms.Label();
            director_s_full_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingNavigator)).BeginInit();
            this.publishersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // publisher_idLabel
            // 
            publisher_idLabel.AutoSize = true;
            publisher_idLabel.Location = new System.Drawing.Point(12, 39);
            publisher_idLabel.Name = "publisher_idLabel";
            publisher_idLabel.Size = new System.Drawing.Size(80, 16);
            publisher_idLabel.TabIndex = 1;
            publisher_idLabel.Text = "Publisher id:";
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
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(12, 95);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(55, 16);
            countryLabel.TabIndex = 5;
            countryLabel.Text = "Country:";
            // 
            // foundation_yearLabel
            // 
            foundation_yearLabel.AutoSize = true;
            foundation_yearLabel.Location = new System.Drawing.Point(12, 123);
            foundation_yearLabel.Name = "foundation_yearLabel";
            foundation_yearLabel.Size = new System.Drawing.Size(107, 16);
            foundation_yearLabel.TabIndex = 7;
            foundation_yearLabel.Text = "Foundation year:";
            // 
            // director_s_full_nameLabel
            // 
            director_s_full_nameLabel.AutoSize = true;
            director_s_full_nameLabel.Location = new System.Drawing.Point(12, 151);
            director_s_full_nameLabel.Name = "director_s_full_nameLabel";
            director_s_full_nameLabel.Size = new System.Drawing.Size(123, 16);
            director_s_full_nameLabel.TabIndex = 9;
            director_s_full_nameLabel.Text = "Director\'s full name:";
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Book_AuthorTableAdapter = null;
            this.tableAdapterManager.Book_PublisherTableAdapter = this.book_PublisherTableAdapter;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.PublishersTableAdapter = this.publishersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // book_PublisherTableAdapter
            // 
            this.book_PublisherTableAdapter.ClearBeforeFill = true;
            // 
            // publishersBindingNavigator
            // 
            this.publishersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.publishersBindingNavigator.BindingSource = this.publishersBindingSource;
            this.publishersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.publishersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.publishersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.publishersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.publishersBindingNavigatorSaveItem});
            this.publishersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.publishersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.publishersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.publishersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.publishersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.publishersBindingNavigator.Name = "publishersBindingNavigator";
            this.publishersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.publishersBindingNavigator.Size = new System.Drawing.Size(1339, 27);
            this.publishersBindingNavigator.TabIndex = 0;
            this.publishersBindingNavigator.Text = "bindingNavigator1";
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
            // publishersBindingNavigatorSaveItem
            // 
            this.publishersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.publishersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("publishersBindingNavigatorSaveItem.Image")));
            this.publishersBindingNavigatorSaveItem.Name = "publishersBindingNavigatorSaveItem";
            this.publishersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.publishersBindingNavigatorSaveItem.Text = "Save Data";
            this.publishersBindingNavigatorSaveItem.Click += new System.EventHandler(this.publishersBindingNavigatorSaveItem_Click);
            // 
            // publisher_idTextBox
            // 
            this.publisher_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "Publisher_id", true));
            this.publisher_idTextBox.Location = new System.Drawing.Point(141, 36);
            this.publisher_idTextBox.Name = "publisher_idTextBox";
            this.publisher_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.publisher_idTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(141, 64);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(366, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(141, 92);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(366, 22);
            this.countryTextBox.TabIndex = 6;
            // 
            // foundation_yearTextBox
            // 
            this.foundation_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "Foundation year", true));
            this.foundation_yearTextBox.Location = new System.Drawing.Point(141, 120);
            this.foundation_yearTextBox.Name = "foundation_yearTextBox";
            this.foundation_yearTextBox.Size = new System.Drawing.Size(100, 22);
            this.foundation_yearTextBox.TabIndex = 8;
            // 
            // director_s_full_nameTextBox
            // 
            this.director_s_full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publishersBindingSource, "Director\'s full name", true));
            this.director_s_full_nameTextBox.Location = new System.Drawing.Point(141, 148);
            this.director_s_full_nameTextBox.Name = "director_s_full_nameTextBox";
            this.director_s_full_nameTextBox.Size = new System.Drawing.Size(366, 22);
            this.director_s_full_nameTextBox.TabIndex = 10;
            // 
            // book_PublisherDataGridView
            // 
            this.book_PublisherDataGridView.AutoGenerateColumns = false;
            this.book_PublisherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_PublisherDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.book_PublisherDataGridView.DataSource = this.book_PublisherBindingSource;
            this.book_PublisherDataGridView.Location = new System.Drawing.Point(12, 187);
            this.book_PublisherDataGridView.Name = "book_PublisherDataGridView";
            this.book_PublisherDataGridView.RowHeadersWidth = 51;
            this.book_PublisherDataGridView.RowTemplate.Height = 24;
            this.book_PublisherDataGridView.Size = new System.Drawing.Size(589, 150);
            this.book_PublisherDataGridView.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 65);
            this.button1.TabIndex = 12;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Publisher_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Publisher_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "The year of publishing";
            this.dataGridViewTextBoxColumn4.HeaderText = "The year of publishing";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // book_PublisherBindingSource
            // 
            this.book_PublisherBindingSource.DataMember = "PublishersBook_Publisher";
            this.book_PublisherBindingSource.DataSource = this.publishersBindingSource;
            // 
            // Edit_Publishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.book_PublisherDataGridView);
            this.Controls.Add(publisher_idLabel);
            this.Controls.Add(this.publisher_idTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(foundation_yearLabel);
            this.Controls.Add(this.foundation_yearTextBox);
            this.Controls.Add(director_s_full_nameLabel);
            this.Controls.Add(this.director_s_full_nameTextBox);
            this.Controls.Add(this.publishersBindingNavigator);
            this.Name = "Edit_Publishers";
            this.Text = "Edit Publishers";
            this.Load += new System.EventHandler(this.Edit_Publishers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingNavigator)).EndInit();
            this.publishersBindingNavigator.ResumeLayout(false);
            this.publishersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_PublisherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LibraryDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator publishersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton publishersBindingNavigatorSaveItem;
        private LibraryDataSetTableAdapters.Book_PublisherTableAdapter book_PublisherTableAdapter;
        private System.Windows.Forms.TextBox publisher_idTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox foundation_yearTextBox;
        private System.Windows.Forms.TextBox director_s_full_nameTextBox;
        private System.Windows.Forms.BindingSource book_PublisherBindingSource;
        private System.Windows.Forms.DataGridView book_PublisherDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}