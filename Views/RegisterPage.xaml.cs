namespace RegisterLogin.Views;
using RegisterLogin.ViewModels;

using RegisterLogin.Models;
using System.Text.RegularExpressions;
public partial class RegisterPage : ContentPage
{
    //bool isValid;
    public RegisterPage()
    {
        InitializeComponent();
        BindingContext = new RegisterViewModel();
    }

    //private void ButtonRegister_Clicked(object sender, EventArgs e)
    //{
    //    isValid = true;

    //    if (EntryUserName.Text.Length < 5)
    //    {
    //        LblErrorName.Text = "Too short must be above 5 chars";
    //        isValid = false;
    //    }

    //    //string passPattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*(),.?"":{}|<>])[A-Za-z\d!@#$%^&*(),.?"":{}|<>]{8,}$";
    //    //bool isPasswordOk = Regex.IsMatch(EntryPassword.Text, passPattern);

    //    //string emailPattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
    //    //bool isEmailOk = Regex.IsMatch(EntryUserEmail.Text, emailPattern);

    //    //if (!isPasswordOk)
    //    //{
    //    //    LblErrorPassword.Text = "Password must be at least 8 chars, contain an uppercase letter and a special char";
    //    //    isValid = false;
    //    //}

    //    //if (!isEmailOk)
    //    //{
    //    //    LblErrorUserEmail.Text = "Valid email address";
    //    //    isValid = false;
    //    //}

    //    if (EntryPassword.Text != EntryVerifyPassword.Text)
    //    {
    //        isValid = false;
    //    }

    //    if (isValid)
    //    {
    //        User user = new User() { UserName = EntryUserName.Text, Password = EntryPassword.Text, Email = EntryUserEmail.Text };
    //        LocalDataService.GetInstance().AddUser(user);
    //        ButtonGoToLogin_Clicked(sender, EventArgs.Empty);
    //    }
    //}
    //private void Button_TogglePass1_Clicked(object sender, EventArgs e)
    //{
    //    EntryPassword.IsPassword = !EntryPassword.IsPassword;
    //    if (!EntryPassword.IsPassword)
    //    {
    //        ButtonTogglePass1.ImageSource = "view.png";
    //    }
    //    else
    //    {
    //        ButtonTogglePass1.ImageSource = "hide.png";
    //    }
    //}
    //private void Button_TogglePass2_Clicked(object sender, EventArgs e)
    //{
    //    EntryVerifyPassword.IsPassword = !EntryVerifyPassword.IsPassword;
    //    if (!EntryVerifyPassword.IsPassword)
    //    {
    //        ButtonTogglePass2.ImageSource = "view.png";
    //    }
    //    else
    //    {
    //        ButtonTogglePass2.ImageSource = "hide.png";
    //    }
    //}

    //private async void ButtonGoToLogin_Clicked(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new LoginPage());
    //}
}