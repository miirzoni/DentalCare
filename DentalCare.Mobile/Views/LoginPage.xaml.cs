
using Microsoft.Maui.Controls;

namespace DentalCare.Mobile.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text?.Trim() ?? "";
            string password = PasswordEntry.Text ?? "";

            // Provjera unesenih podataka
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert(
                    "Greška",
                    "Unesite email adresu i lozinku.",
                    "U redu");

                return;
            }

            // Privremena prijava bez baze podataka
            await Shell.Current.GoToAsync(nameof(MainPage));
        }

        private async void OnRegisterTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage));
        }
    }
}
