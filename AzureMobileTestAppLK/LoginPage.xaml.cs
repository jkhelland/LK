﻿using System;
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
    }
}
