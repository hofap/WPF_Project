using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using BusinessLogic;
using System.ComponentModel;

namespace GUI
{
    /// <summary>
    /// Interaction logic for PhoneControl.xaml
    /// </summary>
    public partial class PhoneControl : UserControl, INotifyPropertyChanged
    {
        PhonebookLogic pl = new PhonebookLogic();

        public PhoneControl()
        {
            InitializeComponent();
            cmbPhoneType.ItemsSource = pl.PhoneTypeDisplay();
            PropertyChanged += new PropertyChangedEventHandler(PhoneControl_PropertyChanged);
        }

        /// <summary>
        /// Define the properties
        /// </summary>
        private string phoneNumber;
        private string phoneType;

        public int? PhoneID { get; set; }

        public string PhoneNumber
        {
            get
            {
                return txtPhoneNumber.Text;
            }
            set
            {
                phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }

        public int PhoneTypeID
        {
            get
            {
                return cmbPhoneType.SelectedIndex;
            }
        }

        public string PhoneType
        {
            get
            {
                return cmbPhoneType.Text;
            }
            set
            {
                phoneType = value;
                OnPropertyChanged("PhoneType");
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///  Generic OnPropertyChange method
        /// </summary>
        /// <param name="propertyName">The Property that was changed</param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Handles the PropertyChangedEventHandler and sets the UI Elements 
        /// </summary>
        void PhoneControl_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PhoneNumber")
            {
                txtPhoneNumber.Text = phoneNumber;
            }
            else if (e.PropertyName == "PhoneType")
            {
                cmbPhoneType.Text = phoneType;
            }
        }

        public event PropertyChangedEventHandler RemovePhone;
        private void btnRemovePhone_Click(object sender, RoutedEventArgs e)
        {
            if (RemovePhone != null)
                RemovePhone(this, new PropertyChangedEventArgs("PhoneID"));
        }

        /// <summary>
        ///  Validation alow only digits in phone number textbox
        /// </summary>
        private void txtPhoneNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!char.IsDigit(c))
                {
                    e.Handled = true;
                    break;
                }
            }
        }

    }

}