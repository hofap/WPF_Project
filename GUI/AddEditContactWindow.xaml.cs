using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using BusinessLogic;
using System;
using System.ComponentModel;

namespace GUI
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddEditContactWindow : Window
    {
        PhonebookLogic pl = new PhonebookLogic();
        private Person person;
        public AddEditContactWindow()
        {
            InitializeComponent();
            cmbGroupName.ItemsSource = pl.GroupsDisplay();
        }

        /// <summary>
        /// C'tor for insert contact's details in the specific fields
        /// </summary>
        public AddEditContactWindow(Person person)
        {
            InitializeComponent();
            cmbGroupName.ItemsSource = pl.GroupsDisplay();

            this.person = person;
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtID.Text = person.ID.ToString();
            cmbGroupName.Text = person.GroupName;
            PhoneNumbersGrid.Children.Clear();
            foreach (var item in person.Phones)
            {
                PhoneControl pc = new PhoneControl();
                pc.PhoneNumber = item.Number;
                pc.PhoneType = item.TypeName;
                pc.PhoneID = item.PhoneID;
                pc.RemovePhone += new PropertyChangedEventHandler(PhoneControl_RemovePhone);
                PhoneNumbersGrid.Children.Add(pc);
            }
        }

        # region Declare properties for contact

        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
        }

        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
           
        }

        public int GroupID
        {
            get
            {
                return cmbGroupName.SelectedIndex;
            }
            set
            {
                cmbGroupName.SelectedIndex = value;
            }
        }

        public List<Phone> Phones
        {
            get
            {
                List<Phone> phones = new List<Phone>();

                foreach (var userControl in PhoneNumbersGrid.Children.OfType<PhoneControl>())
                {
                    phones.Add(new Phone(userControl.PhoneID, userControl.cmbPhoneType.SelectedIndex + 1, userControl.txtPhoneNumber.Text));
                }

                return phones;
            }
        }

        # endregion Declare properties for contact


        /// <summary>
        /// Remove the display of the phone-control's phone
        /// </summary>
        void PhoneControl_RemovePhone(object sender, PropertyChangedEventArgs e)
        {
            if (PhoneNumbersGrid.Children.Count > 1)
            {
                PhoneNumbersGrid.Children.Remove(sender as UIElement);
            }
        }



        /// <summary>
        /// Used for Add or Edit function to accept changes.
        /// This answare (True) on the condition of: DialogResult.HasValue && DialogResult.Value
        /// (like DialogResult.OK in winForm)
        /// </summary>
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (validateFields())
                {
                    DialogResult = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }


        /// <summary>
        /// Check if all fields have a value, if so -> return True
        /// </summary>
        private bool validateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.Focus();
                throw new Exception("First Name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.Focus();
                throw new Exception("Last Name cannot be empty.");
            }

            if (cmbGroupName.SelectedIndex == -1)
            {
                cmbGroupName.Focus();
                throw new Exception("You must select a group");
            }

            foreach (PhoneControl item in PhoneNumbersGrid.Children)
            {
                if (string.IsNullOrWhiteSpace(item.PhoneNumber))
                {
                    item.Focus();
                    throw new Exception("You must insert a phone number");
                }

                if (item.PhoneTypeID == -1)
                {
                    item.Focus();
                    throw new Exception("You must insert a phone type");
                }
            }

            return true;
        }


        /// <summary>
        /// Add another phone number for a contact.
        /// Can only add 4 numbers
        /// </summary>
        private void btnAddAnotherPhone_Click(object sender, RoutedEventArgs e)
        {
            int currentCount = PhoneNumbersGrid.Children.Count;

            if (currentCount < 4)
            {
                PhoneControl p = new PhoneControl();
                PhoneNumbersGrid.Children.Add(p);
                p.RemovePhone += new PropertyChangedEventHandler(PhoneControl_RemovePhone);
                currentCount++;
            }
            else
                MessageBox.Show("You can add only 4 numbers each contact.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Close AddEditWindow
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
