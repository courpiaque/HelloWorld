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
	public partial class Image_Embedded_Page : ContentPage
	{
		public Image_Embedded_Page ()
		{
			InitializeComponent ();
		}
	}
}