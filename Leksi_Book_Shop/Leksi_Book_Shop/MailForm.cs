﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;

namespace Leksi_Book_Shop
{
    public partial class MailForm : Form
    {
        MimeMessage message = new MimeMessage();
        CustomerForm customer=new CustomerForm();
       
        public MailForm()
        {
            InitializeComponent();
            customer.Show();
            customer.Hide();    
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //sender (onoma pou emfanizi ,mail pou stelni)
            //message.From.Add(new MailboxAddress("Βιβλιοπωλείο λέξη", " "));
            foreach(var customer in customer.CustomerList)
            {
                message.To.Add(MailboxAddress.Parse(customer.Email));
                message.Subject = "INFO";
                message.Body = new TextPart("plain")
                {
                    Text = mailTxtBox.Text
                };
                SmtpClient client = new SmtpClient();
                try
                {
                    //gia na boresi na kani enable ton paroxeapou stelni 
                    client.Connect("smtp.gmail.com", 465, true);
                    //authentication of sender (email tou apostolea, o kodikos tou email tou apostolea)
                    //client.Authenticate(" ", " ");
                    client.Send(message);
                    MessageBox.Show("Email sent!", "SUCCESS!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
