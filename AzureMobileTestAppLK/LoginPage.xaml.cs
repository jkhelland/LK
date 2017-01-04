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

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Refresh items only when authenticated.
            if (authenticated == true)
            {
                // Set syncItems to true in order to synchronize the data
                // on startup when running in offline mode.
                //await RefreshItems(true, syncItems: false);
                this.LoginButton.IsVisible = false;
                this.valueLabel.Text = "Logget inn!";
            }
        }

        async void OnLoginClicked(object sender, EventArgs args)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();

            if (authenticated)
                await Navigation.PushModalAsync(new WelcomeScreen());

            //// Set syncItems to true to synchronize the data on startup when offline is enabled.
            //if (authenticated == true)
            //    await RefreshItems(true, syncItems: false);
        }

        async void OnRegisterClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NewUser());
        }
    }
}
