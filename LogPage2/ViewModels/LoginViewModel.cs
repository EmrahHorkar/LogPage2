using Android.App;
using System.Text.RegularExpressions;
namespace DXMauiApp1.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string userName = "";
        string password;

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked, ValidateLogin);
            PropertyChanged +=
                (_, __) => LoginCommand.ChangeCanExecute();
        }


        public string UserName
        {
            get => this.userName;
            set => SetProperty(ref this.userName, value);
        }

        public string Password
        {
            get => this.password;
            set => SetProperty(ref this.password, value);
        }

        public Command LoginCommand { get; }


        async void OnLoginClicked()
        {
            if (ValidateLogin())
            {
                if(userName == "abc@gmail.com" && password == "123")
                {
                    await Navigation.NavigateToAsync<AboutViewModel>(true);
                    Password = String.Empty;
                }
                else
                {
                   
                }

            }
                   
            
        }
        bool ValidateLogin()
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(UserName, regex, RegexOptions.IgnoreCase);
        }
    }
}