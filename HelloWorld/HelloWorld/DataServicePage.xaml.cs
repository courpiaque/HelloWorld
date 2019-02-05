using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DataServicePage : ContentPage
	{
		public DataServicePage ()
		{
			InitializeComponent ();

            if (Application.Current.Properties.ContainsKey("Name"))
                title.Text = Application.Current.Properties["Name"].ToString();

            if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
                notaficationsEnabled.On = (bool) Application.Current.Properties["NotificationsEnabled"];
		}

        private void OnChange(object sender, System.EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationsEnabled"] = notaficationsEnabled.On;

            //Application.Current.SavePropertiesAsync();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}