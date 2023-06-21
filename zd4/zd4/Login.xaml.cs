using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        static string login;
        static string password;

        public Login()
        {
            InitializeComponent();
        }

        private bool CheckFields(string _login, string _password)
        {
            if (string.IsNullOrWhiteSpace(_login))
            {
                DisplayAlert("Ошибка", "Поле логина пустое", "OK");
                return false;
            }
            if (string.IsNullOrWhiteSpace(_password))
            {
                DisplayAlert("Ошибка", "Поле пароля пустое", "OK");
                return false;
            }
            if (_login.Length <= 4)
            {
                DisplayAlert("Ошибка", "Длина логина должна быть больше 4 символов", "OK");
                return false;
            }
            if (_password.Length <= 4)
            {
                DisplayAlert("Ошибка", "Длина пароля должна быть больше 4 символов", "OK");
                return false;
            }
            login = _login;
            password = _password;
            return true;
        }

        private void LogButton_Clicked(object sender, EventArgs e)
        {
            if (CheckFields(LoginTB.Text, Password.Text))
            {
                Navigation.PushAsync(new MainPage(login, password));
            }
        }
    }
}