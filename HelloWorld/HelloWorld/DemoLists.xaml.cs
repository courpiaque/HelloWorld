using HelloWorld.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoLists : ContentPage
    {
        private ObservableCollection<Contact> _contacts;

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
           // listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        ObservableCollection<Contact> GetContacts(string searchText = null)
        {
           // if (String.IsNullOrWhiteSpace(searchText))
            //{
                return new ObservableCollection<Contact>{

                    new Contact {
                        Name = "Mosh",
                        ImageUrl = "http://lorempixel.com/100/100/people/1",
                        Status = "I'm new here!"
                    },

                    new Contact {
                        Name = "John",
                        ImageUrl = "http://lorempixel.com/100/100/people/2",
                        Status ="Hey, let's talk!"
                    },
            };
          //  }

//            return _contacts.Insert(c => c.Name.StartsWith(searchText));
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        public DemoLists()
        {
            InitializeComponent();

            _contacts = GetContacts();

            listView.ItemsSource = _contacts;
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }
    }
}