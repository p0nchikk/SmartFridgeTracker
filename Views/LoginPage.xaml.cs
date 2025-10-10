namespace RegisterLogin.Views;
using RegisterLogin.Services;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }
    private void Button_TogglePass_Clicked(object sender, EventArgs e)
    {
        EntryPassword.IsPassword = !EntryPassword.IsPassword;
        if (!EntryPassword.IsPassword)
        {
            ButtonTogglePass.ImageSource = "view.png";
        }
        else
        {
            ButtonTogglePass.ImageSource = "hide.png";
        }
    }
    private async void ButtonGoToRegister_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
    private void ButtonLogin_Clicked(object sender, EventArgs e)
    {
        string entUsername = EntryUserName.Text;
        string entPassword = EntryPassword.Text;
        string username = LocalDataService.GetInstance().GetUser().UserName;
        string password = LocalDataService.GetInstance().GetUser().Password;
        if (!LocalDataService.IsInstanceAdded())
        {
            LblMessage.Text = "User isn't registered yet";
        }
        else if (entUsername != String.Empty && entPassword != String.Empty)
        {           
            //if (LocalDataService.GetInstance().IsUserRegistered(EntryUserName.Text, EntryPassword.Text))
            if (entUsername == username && entPassword == password)
            {
                LblMessage.Text = EntryUserName.Text + " welcome!";
            }
            else if (username == entUsername)
            {
                LblMessage.Text = "Wrong password";
            }
            else if (password == entPassword)
            {
                LblMessage.Text = "Wrong username";
            }
        }
        else
        {
            LblMessage.Text = "Fill both the username and password";
        }
    }
}