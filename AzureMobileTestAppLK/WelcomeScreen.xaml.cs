using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AzureMobileTestAppLK
{
    public partial class WelcomeScreen : TabbedPage
    {
        bool authenticated = true;

        public WelcomeScreen()
        {
            InitializeComponent();
        }

        async void OnLogoffClicked(object sender, EventArgs args)
        {

        }
    }
}
