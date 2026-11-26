
namespace DentalCare.Mobile.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string name = FullNameEntry.Text?.Trim() ?? "";
            string email = EmailEntry.Text?.Trim() ?? "";
            string phone = PhoneEntry.Text?.Trim() ?? "";
            string password = PasswordEntry.Text ?? "";
            string confirmPassword = ConfirmPasswordEntry.Text ?? "";

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                await DisplayAlert(
                    "Greška",
                    "Popunite sva polja.",
                    "U redu");
                return;
            }

            if (password.Length < 6)
            {
                await DisplayAlert(
                    "Greška",
                    "Lozinka mora imati najmanje 6 znakova.",
                    "U redu");
                return;
            }

            if (password != confirmPassword)
            {
                await DisplayAlert(
                    "Greška",
                    "Lozinke se ne podudaraju.",
                    "U redu");
                return;
            }

            await DisplayAlert(
                "Uspješna registracija",
                "Registracija je uspješno završena! Povezivanje s bazom ćemo dodati kasnije.",
                "U redu");

            await Shell.Current.GoToAsync("//LoginPage");
        }

        private async void OnLoginTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
