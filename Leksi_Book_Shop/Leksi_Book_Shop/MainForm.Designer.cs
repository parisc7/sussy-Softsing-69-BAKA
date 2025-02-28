﻿namespace Leksi_Book_Shop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.barcodeTxtBox = new System.Windows.Forms.TextBox();
            this.pointsTxtBox = new System.Windows.Forms.TextBox();
            this.companieLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.orderNoTxtBox = new System.Windows.Forms.TextBox();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.customerTxtBox = new System.Windows.Forms.TextBox();
            this.nameSurnameTxttBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.currentOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.booksButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.mailButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.oRDERTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.ORDERTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.oRDER_LISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDER_LISTTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.ORDER_LISTTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companieLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_LISTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.barcodeTxtBox);
            this.panel2.Controls.Add(this.pointsTxtBox);
            this.panel2.Controls.Add(this.companieLogoPictureBox);
            this.panel2.Controls.Add(this.orderNoTxtBox);
            this.panel2.Controls.Add(this.searchCustomerButton);
            this.panel2.Controls.Add(this.customerTxtBox);
            this.panel2.Controls.Add(this.nameSurnameTxttBox);
            this.panel2.Controls.Add(this.totalPriceLabel);
            this.panel2.Controls.Add(this.payButton);
            this.panel2.Controls.Add(this.currentOrderDataGridView);
            this.panel2.Location = new System.Drawing.Point(277, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 635);
            this.panel2.TabIndex = 2;
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.Enabled = false;
            this.barcodeTxtBox.Location = new System.Drawing.Point(505, 539);
            this.barcodeTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barcodeTxtBox.Name = "barcodeTxtBox";
            this.barcodeTxtBox.ReadOnly = true;
            this.barcodeTxtBox.Size = new System.Drawing.Size(9, 22);
            this.barcodeTxtBox.TabIndex = 11;
            this.barcodeTxtBox.Visible = false;
            // 
            // pointsTxtBox
            // 
            this.pointsTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pointsTxtBox.Enabled = false;
            this.pointsTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsTxtBox.Location = new System.Drawing.Point(664, 94);
            this.pointsTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pointsTxtBox.Name = "pointsTxtBox";
            this.pointsTxtBox.Size = new System.Drawing.Size(217, 41);
            this.pointsTxtBox.TabIndex = 10;
            this.pointsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companieLogoPictureBox
            // 
            this.companieLogoPictureBox.Image = global::Leksi_Book_Shop.Properties.Resources.Softtsing;
            this.companieLogoPictureBox.Location = new System.Drawing.Point(801, 599);
            this.companieLogoPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companieLogoPictureBox.Name = "companieLogoPictureBox";
            this.companieLogoPictureBox.Size = new System.Drawing.Size(80, 23);
            this.companieLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.companieLogoPictureBox.TabIndex = 9;
            this.companieLogoPictureBox.TabStop = false;
            this.companieLogoPictureBox.Click += new System.EventHandler(this.companieLogoPictureBox_Click);
            // 
            // orderNoTxtBox
            // 
            this.orderNoTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orderNoTxtBox.Enabled = false;
            this.orderNoTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNoTxtBox.Location = new System.Drawing.Point(45, 35);
            this.orderNoTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderNoTxtBox.Name = "orderNoTxtBox";
            this.orderNoTxtBox.Size = new System.Drawing.Size(207, 41);
            this.orderNoTxtBox.TabIndex = 8;
            this.orderNoTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchCustomerButton.FlatAppearance.BorderSize = 0;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomerButton.Image")));
            this.searchCustomerButton.Location = new System.Drawing.Point(829, 30);
            this.searchCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(59, 46);
            this.searchCustomerButton.TabIndex = 7;
            this.searchCustomerButton.UseVisualStyleBackColor = false;
            this.searchCustomerButton.Click += new System.EventHandler(this.searchCustomerButton_Click);
            // 
            // customerTxtBox
            // 
            this.customerTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTxtBox.Location = new System.Drawing.Point(616, 34);
            this.customerTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerTxtBox.Name = "customerTxtBox";
            this.customerTxtBox.Size = new System.Drawing.Size(207, 41);
            this.customerTxtBox.TabIndex = 6;
            this.customerTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameSurnameTxttBox
            // 
            this.nameSurnameTxttBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameSurnameTxttBox.Enabled = false;
            this.nameSurnameTxttBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSurnameTxttBox.Location = new System.Drawing.Point(45, 94);
            this.nameSurnameTxttBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameSurnameTxttBox.Name = "nameSurnameTxttBox";
            this.nameSurnameTxttBox.ReadOnly = true;
            this.nameSurnameTxttBox.Size = new System.Drawing.Size(577, 41);
            this.nameSurnameTxttBox.TabIndex = 4;
            this.nameSurnameTxttBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(583, 569);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(0, 34);
            this.totalPriceLabel.TabIndex = 3;
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.payButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(45, 569);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(152, 46);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "&Pay";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // currentOrderDataGridView
            // 
            this.currentOrderDataGridView.AutoGenerateColumns = false;
            this.currentOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRICEDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn});
            this.currentOrderDataGridView.DataSource = this.oRDERBindingSource;
            this.currentOrderDataGridView.Location = new System.Drawing.Point(45, 151);
            this.currentOrderDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentOrderDataGridView.Name = "currentOrderDataGridView";
            this.currentOrderDataGridView.RowHeadersWidth = 51;
            this.currentOrderDataGridView.RowTemplate.Height = 24;
            this.currentOrderDataGridView.Size = new System.Drawing.Size(836, 382);
            this.currentOrderDataGridView.TabIndex = 0;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 165;
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            this.qUANTITYDataGridViewTextBoxColumn.Width = 151;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 165;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.Width = 300;
            // 
            // oRDERBindingSource
            // 
            this.oRDERBindingSource.DataMember = "ORDER";
            this.oRDERBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // lexi_BookshopDataSet
            // 
            this.lexi_BookshopDataSet.DataSetName = "Lexi_BookshopDataSet";
            this.lexi_BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.booksButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.mailButton);
            this.panel1.Controls.Add(this.employeesButton);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 635);
            this.panel1.TabIndex = 3;
            // 
            // booksButton
            // 
            this.booksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.booksButton.AutoSize = true;
            this.booksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.booksButton.FlatAppearance.BorderSize = 0;
            this.booksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Image = ((System.Drawing.Image)(resources.GetObject("booksButton.Image")));
            this.booksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksButton.Location = new System.Drawing.Point(20, 348);
            this.booksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(239, 70);
            this.booksButton.TabIndex = 5;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(20, 538);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(239, 70);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = " Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // mailButton
            // 
            this.mailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailButton.AutoSize = true;
            this.mailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.mailButton.FlatAppearance.BorderSize = 0;
            this.mailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailButton.Image = ((System.Drawing.Image)(resources.GetObject("mailButton.Image")));
            this.mailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailButton.Location = new System.Drawing.Point(20, 432);
            this.mailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(239, 70);
            this.mailButton.TabIndex = 6;
            this.mailButton.Text = "E-mail";
            this.mailButton.UseVisualStyleBackColor = false;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            // 
            // employeesButton
            // 
            this.employeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesButton.AutoSize = true;
            this.employeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.employeesButton.FlatAppearance.BorderSize = 0;
            this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButton.Image = ((System.Drawing.Image)(resources.GetObject("employeesButton.Image")));
            this.employeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesButton.Location = new System.Drawing.Point(20, 255);
            this.employeesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(239, 70);
            this.employeesButton.TabIndex = 4;
            this.employeesButton.Text = "Employees";
            this.employeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employeesButton.UseVisualStyleBackColor = false;
            this.employeesButton.Click += new System.EventHandler(this.employeesButton_Click);
            // 
            // customerButton
            // 
            this.customerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerButton.AutoSize = true;
            this.customerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.Image = ((System.Drawing.Image)(resources.GetObject("customerButton.Image")));
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(20, 160);
            this.customerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(261, 70);
            this.customerButton.TabIndex = 3;
            this.customerButton.Text = "     Customer";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(44, 17);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(191, 124);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // oRDERTableAdapter
            // 
            this.oRDERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.ORDER_LISTTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = this.oRDERTableAdapter;
            this.tableAdapterManager.TIMETABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oRDER_LISTBindingSource
            // 
            this.oRDER_LISTBindingSource.DataMember = "ORDER_LIST";
            this.oRDER_LISTBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // oRDER_LISTTableAdapter
            // 
            this.oRDER_LISTTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1197, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companieLogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDER_LISTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button mailButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView currentOrderDataGridView;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.TextBox nameSurnameTxttBox;
        private System.Windows.Forms.TextBox customerTxtBox;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.TextBox orderNoTxtBox;
        private System.Windows.Forms.PictureBox companieLogoPictureBox;
        private Lexi_BookshopDataSet lexi_BookshopDataSet;
        private System.Windows.Forms.BindingSource oRDERBindingSource;
        private Lexi_BookshopDataSetTableAdapters.ORDERTableAdapter oRDERTableAdapter;
        private Lexi_BookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox pointsTxtBox;
        private System.Windows.Forms.TextBox barcodeTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource oRDER_LISTBindingSource;
        private Lexi_BookshopDataSetTableAdapters.ORDER_LISTTableAdapter oRDER_LISTTableAdapter;
    }
}