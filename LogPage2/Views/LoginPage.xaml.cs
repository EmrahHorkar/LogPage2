using DXMauiApp1.ViewModels;
using System.Text.RegularExpressions;
namespace DXMauiApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
        
        private async void Button(Object sender, EventArgs e)
        {
            if (IsValid(Email.Text))
            {
                if (Email.Text == "abc@gmail.com" && Password.Text == "123")
                {
                    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
                    Email.Text = "";
                    Password.Text = "";
                    DisplayAlert("Login", "Login Succesful", "OK");

                }
                else
                {
                    DisplayAlert("Error", "There is no Account", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "E-mail adress is not valid", "OK");
            }

        }
        private void ForgotClicked(Object sender, EventArgs e)
        {
            DisplayAlert("Mail Sended", "Please reset your password", "Ok");
        }
        private static bool IsValid(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}