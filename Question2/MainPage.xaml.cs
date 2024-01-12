using System.Text.RegularExpressions;

namespace Question2
{
    public partial class MainPage : ContentPage
    {
        private static readonly Regex phoneRegex = new Regex(@"^\d{11}$", RegexOptions.Compiled);

        public MainPage()
        {
            InitializeComponent();
            PhoneEntry.TextChanged += OnPhoneEntryTextChanged;
            PasswordEntry.TextChanged += OnPasswordEntryTextChanged;
            TermsAndConditionsCheckBox.CheckedChanged += OnTermsAndConditionsCheckboxChanged;
        }
        private void OnPhoneEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            bool isValid = IsValidPhoneNumber(e.NewTextValue);
            InvalidPhoneNumber.IsVisible = !isValid;
            CheckRegisterButtonEnabled();
        }

        private void OnPasswordEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            bool isValid = IsValidPassword(e.NewTextValue);
            InvalidPasswordLabel.IsVisible = !isValid;
            CheckRegisterButtonEnabled();
        }

        private void OnTermsAndConditionsCheckboxChanged(object sender, CheckedChangedEventArgs e)
        {
            CheckRegisterButtonEnabled();
        }

        private void OnTermsAndConditionsLabelTapped(object sender, EventArgs e)
        {
            TermsAndConditionsCheckBox.IsChecked = !TermsAndConditionsCheckBox.IsChecked;
        }

        private void CheckRegisterButtonEnabled()
        {
            RegisterButton.IsEnabled = IsValidPhoneNumber(PhoneEntry.Text)
                                       && IsValidPassword(PasswordEntry.Text)
                                       && TermsAndConditionsCheckBox.IsChecked;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber != null && phoneRegex.IsMatch(phoneNumber);
            return !string.IsNullOrWhiteSpace(phoneNumber) && Regex.IsMatch(phoneNumber, @"^\d{10,11}$");
        }

        private bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password) && password.Length >= 6;
        }
    }

}
