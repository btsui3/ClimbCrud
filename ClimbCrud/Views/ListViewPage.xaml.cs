using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ClimbCrud.Models;
using Xamarin.Forms;
using System.Linq;

namespace ClimbCrud.Views
{
    public partial class ListViewPage : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Ben", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Contact { Name = "Stella", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's chat" }
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;
            return contacts.Where(c => c.Name.StartsWith(searchText));
        }

            public ListViewPage()
            {
                InitializeComponent();

                listView.ItemsSource = GetContacts();


            }

             void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
             {
                 var contact = e.Item as Contact;
                 DisplayAlert("Tapped", contact.Name, "OK");
             }

            void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
            {
                var contact = e.SelectedItem as Contact;
                DisplayAlert("Selected", contact.Name, "OK");
            }

            void Call_Clicked(object sender, System.EventArgs e)
            {
                var menuItem = sender as MenuItem;
                var contact = menuItem.CommandParameter as Contact;
                DisplayAlert("Call", contact.Name, "OK");
            }


            void Delete_Clicked(object sender, System.EventArgs e)
            {
                var contact = (sender as MenuItem).CommandParameter as Contact;
        
            }


            void Handle_Refreshing(object sender, System.EventArgs e)
            {
                listView.ItemsSource = GetContacts();
                listView.EndRefresh();
            }

        
    }
}