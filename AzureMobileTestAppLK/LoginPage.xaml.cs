using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AzureMobileTestAppLK
{
    public partial class LoginPage : ContentPage
    {
        // Track whether the user has authenticated.
        bool authenticated = false;
        

        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnLoginClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new WelcomeScreen());
        }

        async void OnRegisterClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NewUser());
        }
    }
}
