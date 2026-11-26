namespace DentalCare.Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBookAppointmentClicked(object sender, EventArgs e)
        {
            await DisplayAlert(
                "DentalCare",
                "Uskoro ćete moći zakazati svoj termin.",
                "U redu"
            );
        }
    }
}
