using System.Windows;
using BusinessLogic;
using System;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Input;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhonebookLogic pl = new PhonebookLogic();
        public MainWindow()
        {
            InitializeComponent();
            UpdateGrid();
        }

        /// <summary>
        /// Load grid records
        /// </summary>
        private void UpdateGrid()
        {
            dgContactsDisplay.ItemsSource = pl.GetAllContacts();
        }

        /// <summary>
        /// Add new contact
        /// </summary>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addContact = new AddEditContactWindow();
            addContact.lblWindowHeader.Content = "Add New Contact";
            addContact.ShowDialog();

            if (addContact.DialogResult.HasValue && addContact.DialogResult.Value)
            {
                try
                {
                    pl.AddContact(addContact.FirstName, addContact.LastName, addContact.GroupID + 1, addContact.Phones);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nYou must insert values to all fields", "Save failed", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
            }
            UpdateGrid();
        }



        /// <summary>
        /// Delete a contact by ID (optional: delete multiple records)
        /// </summary>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgContactsDisplay.SelectedItems.Count >= 1)
            {
                foreach (Person selected in dgContactsDisplay.SelectedItems)
                {
                    pl.DeletePerson(selected.ID);
                }
                MessageBox.Show("Delete successfully", "Delete", MessageBoxButton.OK, MessageBoxImage.Information);
                UpdateGrid();
            }
            else
                MessageBox.Show("No contact has been selected", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Update contact details
        /// </summary>
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgContactsDisplay.SelectedItems.Count == 1)
            {
                var selected = (Person)dgContactsDisplay.SelectedItem;
                var editContact = new AddEditContactWindow(selected);
                editContact.lblWindowHeader.Content = "Update a Contact";

                editContact.ShowDialog();


                if (editContact.DialogResult.HasValue && editContact.DialogResult.Value)
                {
                    // Delete unused phones
                    foreach (Phone phone in selected.Phones)
                    {
                        if (!editContact.Phones.Exists(p => p.PhoneID == phone.PhoneID))
                        {
                            if (phone.PhoneID.HasValue)
                            {
                                pl.DeletePhone(phone.PhoneID.Value);
                            }
                        }
                    }
                    
                    // Update any changes to contact
                    pl.UpdateContact(editContact.FirstName, editContact.LastName, editContact.GroupID + 1, editContact.Phones, Convert.ToInt32(editContact.txtID.Text));
                    MessageBox.Show("Update Successfully", "Update", MessageBoxButton.OK, MessageBoxImage.Information);
                    UpdateGrid();
                }
            }
            else if (dgContactsDisplay.SelectedItems.Count > 1)
                MessageBox.Show("Please select only one contact ", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
                MessageBox.Show("No contact has been selected", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }


        /// <summary>
        ///  Display details of a contact (phones) , by clicking double click on a row
        /// </summary>
        private void dgContactsDisplay_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgContactsDisplay.RowDetailsVisibilityMode == DataGridRowDetailsVisibilityMode.Collapsed)
            {
                var row = dgContactsDisplay.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.VisibleWhenSelected;
            }
            else if (dgContactsDisplay.RowDetailsVisibilityMode == DataGridRowDetailsVisibilityMode.VisibleWhenSelected)
            {
                dgContactsDisplay.RowDetailsVisibilityMode = DataGridRowDetailsVisibilityMode.Collapsed;
            }
        }


    }
}
