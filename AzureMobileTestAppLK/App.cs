﻿using System;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace AzureMobileTestAppLK
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate();
    }
    public class App : Application
	{
        public static IAuthenticate Authenticator { get; private set; }
         
        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App ()
		{
            MainPage = new LoginPage();

			// The root page of your application
			//MainPage = new TodoList();
		}

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

