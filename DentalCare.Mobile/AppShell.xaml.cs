
using DentalCare.Mobile.Views;

namespace DentalCare.Mobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(
                nameof(MainPage),
                typeof(MainPage));

            Routing.RegisterRoute(
                nameof(RegisterPage),
                typeof(RegisterPage));
        }
    }
}
