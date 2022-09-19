namespace LogPage2;
using System.Text.RegularExpressions;

public partial class MainPage : ContentPage
{
    private static bool IsValid(string email)
    {
        string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

        return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
    }

    public MainPage()
    {
        InitializeComponent();
    }
    private async void Button_Clicked(Object sender, EventArgs e)
    {
        if (IsValid(Email.Text))
        {
            if (Email.Text == "abc@gmail.com" && Password.Text == "123")
            {
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
                Email.Text = "";
                Password.Text = "";
                DisplayAlert("Login", "Login Succesful", "OK");

            }
            else if (Email.Text == "abc@gmail.com" && Password.Text != "123")
            {
                DisplayAlert("Error", "Passwords is incorrect", "Ok");
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
}

