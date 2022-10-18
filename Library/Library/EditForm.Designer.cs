namespace Library
{
    partial class EditForm
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
            this.comboBox_Book_id = new System.Windows.Forms.ComboBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
            this.comboBox_Author_id = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.authorsTableAdapter = new Library.LibraryDataSetTableAdapters.AuthorsTableAdapter();
            this.book_AuthorTableAdapter1 = new Library.LibraryDataSetTableAdapters.Book_AuthorTableAdapter();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Book_id
            // 
            this.comboBox_Book_id.DataSource = this.booksBindingSource;
            this.comboBox_Book_id.DisplayMember = "Title";
            this.comboBox_Book_id.FormattingEnabled = true;
            this.comboBox_Book_id.Location = new System.Drawing.Point(620, 71);
            this.comboBox_Book_id.Name = "comboBox_Book_id";
            this.comboBox_Book_id.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Book_id.TabIndex = 0;
            this.comboBox_Book_id.ValueMember = "Book_id";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.libraryDataSet;
            this.bindingSource1.Position = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_Author_id
            // 
            this.comboBox_Author_id.DataSource = this.authorsBindingSource;
            this.comboBox_Author_id.DisplayMember = "Author_id";
            this.comboBox_Author_id.FormattingEnabled = true;
            this.comboBox_Author_id.Location = new System.Drawing.Point(620, 132);
            this.comboBox_Author_id.Name = "comboBox_Author_id";
            this.comboBox_Author_id.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Author_id.TabIndex = 0;
            this.comboBox_Author_id.ValueMember = "Author_id";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.bindingSource1;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // book_AuthorTableAdapter1
            // 
            this.book_AuthorTableAdapter1.ClearBeforeFill = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(461, 246);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "button1";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click_1);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(501, 360);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "button1";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click_1);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 594);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_Author_id);
            this.Controls.Add(this.comboBox_Book_id);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Book_id;
        private System.Windows.Forms.ComboBox comboBox_Author_id;
        private System.Windows.Forms.BindingSource bindingSource1;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private LibraryDataSetTableAdapters.Book_AuthorTableAdapter book_AuthorTableAdapter1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}