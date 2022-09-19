namespace LogPage2;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
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