using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

#if OFFLINE_SYNC_ENABLED
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
#endif

namespace AzureMobileTestAppLK
{
    public partial class ActivityManager
    {
        static ActivityManager defaultInstance = new ActivityManager();
        MobileServiceClient client;

        const string offlineDbPath = @"localstore.db";

        private ActivityManager()
        {
            this.client = new MobileServiceClient(Constants.ApplicationURL);
        }

        public static ActivityManager DefaultManager
        {
            get
            {
                return defaultInstance;
            }
            private set
            {
                defaultInstance = value;
            }
        }

        public MobileServiceClient CurrentClient
        {
            get { return client; }
        }

    }
}
