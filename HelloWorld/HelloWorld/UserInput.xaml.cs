using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserInput : ContentPage
    {
        private IList<ContactMethod> _contactMethods;

        public UserInput()
        {
            InitializeComponent();

            _contactMethods = GetContactMethods();

            foreach (var method in _contactMethods)
                picker.Items.Add(method.Name);
        }

        private IList<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id = 1, Name="SMS"},
                new ContactMethod { Id = 2, Name="EMAIL"}
            };
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            label.Text = "Is completed";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue;
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var contactMethod = _contactMethods.Single(cm => cm.Name == name);
            DisplayAlert("Selection", name, "OK");
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}