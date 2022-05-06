﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace Leksi_Book_Shop
{
    public partial class MainForm : Form
    {
        BookForm books= new BookForm();
        CustomerForm customers= new CustomerForm();  
        EmployeesForm employees= new EmployeesForm();
        Employee curent=new Employee();
       
        public MainForm(bool admin,Employee employee)
        {
            customers.Show();
            customers.Hide();
            books.Show();
            books.Hide();
            employees.Show();
            employees.Hide();
            InitializeComponent();
            BarcodeScanner scanner = new BarcodeScanner(barcodeTxtBox);
            scanner.BarcodeScanned += Scanner_BarcodeScanned;  
            curent.Copy(employee);
            if (admin== false)
            {
                employeesButton.Visible = false;
            }
        }

        private void Scanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            barcodeTxtBox.Text=e.Barcode;
            foreach (var book in books.BooksList)
            {
                if (book.ISBN == int.Parse(barcodeTxtBox.Text))
                {
                    
                    break;
                }
               
            }

        }

        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            employees.ShowDialog();
            this.Show();
        }
        private void companieLogoPictureBox_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            customers.ShowDialog();
            this.Show();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            books.ShowDialog();
            this.Show();    
        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailForm mailForm = new MailForm();
            mailForm.ShowDialog();
            this.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.lexi_BookshopDataSet.ORDER);

        }

        private void dailyTotalButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void payButton_Click(object sender, EventArgs e)
        {

        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            foreach (var customer in customers.CustomerList)
            {
                if (customer.Phone == int.Parse(customerTxtBox.Text))
                {
                    nameSurnameTxttBox.Text = $"{customer.Firstname} {customer.Lastname}";
                    pointsTxtBox.Text =$"{customer.Points}";
                    break;
                }
                else if (customer.Customer_id == int.Parse(customerTxtBox.Text))
                {
                    nameSurnameTxttBox.Text = $"{customer.Firstname} {customer.Lastname}";
                    pointsTxtBox.Text = $"{customer.Points}";
                    break;
                }
            }
        }
    }
}
