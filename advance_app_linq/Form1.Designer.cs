namespace advance_app_linq
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.yearPub_lable = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            this.pub_lable = new System.Windows.Forms.Label();
            this.title_lable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.price_txtBox = new System.Windows.Forms.TextBox();
            this.quant_txtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.output_gridView = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearPublishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linqDataSet = new advance_app_linq.linqDataSet();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_txtBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearFields_btn = new System.Windows.Forms.Button();
            this.addBook_btn = new System.Windows.Forms.Button();
            this.author_txtbox = new System.Windows.Forms.TextBox();
            this.pub_txtbox = new System.Windows.Forms.TextBox();
            this.quantity_txtbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.pubYear_txtbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.title_txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bookTableAdapter = new advance_app_linq.linqDataSetTableAdapters.bookTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output_gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 624);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.yearPub_lable);
            this.tabPage1.Controls.Add(this.author_label);
            this.tabPage1.Controls.Add(this.pub_lable);
            this.tabPage1.Controls.Add(this.title_lable);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.delete_btn);
            this.tabPage1.Controls.Add(this.update_btn);
            this.tabPage1.Controls.Add(this.price_txtBox);
            this.tabPage1.Controls.Add(this.quant_txtBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.output_gridView);
            this.tabPage1.Controls.Add(this.search_btn);
            this.tabPage1.Controls.Add(this.search_txtBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // yearPub_lable
            // 
            this.yearPub_lable.AutoSize = true;
            this.yearPub_lable.Location = new System.Drawing.Point(484, 398);
            this.yearPub_lable.Name = "yearPub_lable";
            this.yearPub_lable.Size = new System.Drawing.Size(0, 13);
            this.yearPub_lable.TabIndex = 17;
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(447, 353);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(0, 13);
            this.author_label.TabIndex = 16;
            // 
            // pub_lable
            // 
            this.pub_lable.AutoSize = true;
            this.pub_lable.Location = new System.Drawing.Point(121, 398);
            this.pub_lable.Name = "pub_lable";
            this.pub_lable.Size = new System.Drawing.Size(0, 13);
            this.pub_lable.TabIndex = 15;
            // 
            // title_lable
            // 
            this.title_lable.AutoSize = true;
            this.title_lable.Location = new System.Drawing.Point(118, 353);
            this.title_lable.Name = "title_lable";
            this.title_lable.Size = new System.Drawing.Size(0, 13);
            this.title_lable.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "You may click a book you wish to update or  delete";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(374, 511);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(138, 23);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.Text = "Delete Book";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(175, 511);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(133, 23);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Update Book";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // price_txtBox
            // 
            this.price_txtBox.Location = new System.Drawing.Point(426, 441);
            this.price_txtBox.Name = "price_txtBox";
            this.price_txtBox.Size = new System.Drawing.Size(172, 20);
            this.price_txtBox.TabIndex = 10;
            // 
            // quant_txtBox
            // 
            this.quant_txtBox.Location = new System.Drawing.Point(121, 441);
            this.quant_txtBox.Name = "quant_txtBox";
            this.quant_txtBox.Size = new System.Drawing.Size(155, 20);
            this.quant_txtBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year Published:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Publisher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title:";
            // 
            // output_gridView
            // 
            this.output_gridView.AutoGenerateColumns = false;
            this.output_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.yearPublishedDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.output_gridView.DataSource = this.bookBindingSource;
            this.output_gridView.Location = new System.Drawing.Point(17, 139);
            this.output_gridView.Name = "output_gridView";
            this.output_gridView.Size = new System.Drawing.Size(671, 193);
            this.output_gridView.TabIndex = 2;
            this.output_gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.output_gridView_CellContentClick);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "bookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // yearPublishedDataGridViewTextBoxColumn
            // 
            this.yearPublishedDataGridViewTextBoxColumn.DataPropertyName = "yearPublished";
            this.yearPublishedDataGridViewTextBoxColumn.HeaderText = "yearPublished";
            this.yearPublishedDataGridViewTextBoxColumn.Name = "yearPublishedDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.linqDataSet;
            // 
            // linqDataSet
            // 
            this.linqDataSet.DataSetName = "linqDataSet";
            this.linqDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(523, 59);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_txtBox
            // 
            this.search_txtBox.Location = new System.Drawing.Point(121, 59);
            this.search_txtBox.Name = "search_txtBox";
            this.search_txtBox.Size = new System.Drawing.Size(368, 20);
            this.search_txtBox.TabIndex = 0;
            this.search_txtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_txtBox_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearFields_btn);
            this.tabPage2.Controls.Add(this.addBook_btn);
            this.tabPage2.Controls.Add(this.author_txtbox);
            this.tabPage2.Controls.Add(this.pub_txtbox);
            this.tabPage2.Controls.Add(this.quantity_txtbox);
            this.tabPage2.Controls.Add(this.price_textbox);
            this.tabPage2.Controls.Add(this.pubYear_txtbox);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.title_txtbox);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add New Book";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearFields_btn
            // 
            this.clearFields_btn.Location = new System.Drawing.Point(403, 432);
            this.clearFields_btn.Name = "clearFields_btn";
            this.clearFields_btn.Size = new System.Drawing.Size(91, 23);
            this.clearFields_btn.TabIndex = 14;
            this.clearFields_btn.Text = "Clear Fields";
            this.clearFields_btn.UseVisualStyleBackColor = true;
            this.clearFields_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBook_btn
            // 
            this.addBook_btn.Location = new System.Drawing.Point(214, 432);
            this.addBook_btn.Name = "addBook_btn";
            this.addBook_btn.Size = new System.Drawing.Size(87, 23);
            this.addBook_btn.TabIndex = 13;
            this.addBook_btn.Text = "Add Book";
            this.addBook_btn.UseVisualStyleBackColor = true;
            this.addBook_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // author_txtbox
            // 
            this.author_txtbox.Location = new System.Drawing.Point(461, 108);
            this.author_txtbox.Name = "author_txtbox";
            this.author_txtbox.Size = new System.Drawing.Size(124, 20);
            this.author_txtbox.TabIndex = 12;
            // 
            // pub_txtbox
            // 
            this.pub_txtbox.Location = new System.Drawing.Point(142, 215);
            this.pub_txtbox.Name = "pub_txtbox";
            this.pub_txtbox.Size = new System.Drawing.Size(137, 20);
            this.pub_txtbox.TabIndex = 11;
            // 
            // quantity_txtbox
            // 
            this.quantity_txtbox.Location = new System.Drawing.Point(142, 311);
            this.quantity_txtbox.Name = "quantity_txtbox";
            this.quantity_txtbox.Size = new System.Drawing.Size(137, 20);
            this.quantity_txtbox.TabIndex = 10;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(461, 308);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(124, 20);
            this.price_textbox.TabIndex = 9;
            // 
            // pubYear_txtbox
            // 
            this.pubYear_txtbox.Location = new System.Drawing.Point(461, 215);
            this.pubYear_txtbox.Name = "pubYear_txtbox";
            this.pubYear_txtbox.Size = new System.Drawing.Size(124, 20);
            this.pubYear_txtbox.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 318);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Year Published";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Publisher";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Author";
            // 
            // title_txtbox
            // 
            this.title_txtbox.Location = new System.Drawing.Point(142, 112);
            this.title_txtbox.Name = "title_txtbox";
            this.title_txtbox.Size = new System.Drawing.Size(137, 20);
            this.title_txtbox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Please fill out form to add new book";
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 625);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "NCU Bookstore Book Database Forn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output_gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox quant_txtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView output_gridView;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txtBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox price_txtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private linqDataSet linqDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private linqDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearPublishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label yearPub_lable;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Label pub_lable;
        private System.Windows.Forms.Label title_lable;
        private System.Windows.Forms.TextBox title_txtbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearFields_btn;
        private System.Windows.Forms.Button addBook_btn;
        private System.Windows.Forms.TextBox author_txtbox;
        private System.Windows.Forms.TextBox pub_txtbox;
        private System.Windows.Forms.TextBox quantity_txtbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.TextBox pubYear_txtbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

