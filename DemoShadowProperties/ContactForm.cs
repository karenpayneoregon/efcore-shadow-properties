﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.Context;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoShadowProperties
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Provides immediate updates to the DataGridView
        /// in tangent with INotifyPropertyChanged implemented
        /// in Contact model
        /// </summary>
        private BindingList<Contact> _bindingListContacts =
            new BindingList<Contact>();

        /// <summary>
        /// Work with one context rather than attaching to a new context
        /// </summary>
        private Context _context = new Context();

        public ContactForm()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            var contacts = await _context.Contacts.ToListAsync();
            if (contacts.Count >0)
            {
                CurrentContactButton.Enabled = true;
                UpdateCurrentContactButton.Enabled = true;
            }

            _bindingListContacts = new BindingList<Contact>(contacts);
            dataGridView1.DataSource = _bindingListContacts;

            /*
             * Data bind all exists contacts
             */
            FirstNameEditTextBox.DataBindings.Add("Text", _bindingListContacts, "FirstName");
            LastNameEditTextBox.DataBindings.Add("Text", _bindingListContacts, "LastName");
        }
        /// <summary>
        /// Provides add capabilities to database table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewContactButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameAddTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameAddTextBox.Text))
            {
                var contact = new Contact()
                {
                    FirstName = FirstNameAddTextBox.Text,
                    LastName = LastNameAddTextBox.Text
                };

                _context.Add(contact);
                _context.SaveChanges();
                _bindingListContacts.Add(contact);

                CurrentContactButton.Enabled = true;
                UpdateCurrentContactButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Requires both first and last name to add a new contact");
            }
        }
        /// <summary>
        /// Provides update capabilities to current contact shown in the
        /// DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCurrentContactButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(FirstNameEditTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameEditTextBox.Text))
            {
                var contact = _bindingListContacts[dataGridView1.CurrentRow.Index];

                contact.FirstName = FirstNameEditTextBox.Text;
                contact.LastName = LastNameEditTextBox.Text;

                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Requires both first and last name to save current contact");
            }
        }
        /// <summary>
        /// Demos how to see values for shadow properties when they
        /// are not in the model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentContactButton_Click(object sender, EventArgs e)
        {
            var contact = _bindingListContacts[dataGridView1.CurrentRow.Index];           
            var lastUser = (string)_context.Entry(contact).Property("LastUser").CurrentValue;
            var lastUpdated = (DateTime?)_context.Entry(contact).Property("LastUpdated").CurrentValue;

            MessageBox.Show($"{contact.FirstName} {contact.LastName}\n{lastUpdated.Value:g} - {lastUser}");

        }
    }
}
