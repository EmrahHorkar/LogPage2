using DXMauiApp1.ViewModels;

namespace DXMauiApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
        }
        private async void BrowserOpen_Clicked(object sender, EventArgs e)
        {

            Uri uri = new Uri("https://www.basarimobile.com/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);


        }
        private void Pr(Object sender, EventArgs e)
        {
            DisplayAlert("a", "a", "ok");
        }
        private void ForgotClicked(Object sender, EventArgs e)
        {
            DisplayAlert("Mail Sended", "Please reset your password", "Ok");
        }
    }

}