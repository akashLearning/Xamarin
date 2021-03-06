﻿using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class ContactsPage : MasterDetailPage
	{
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			var contact = e.SelectedItem as Contact;
			Detail = new ContactDetailPage(contact);
		}

		public ContactsPage()
		{
			InitializeComponent();

			listView.ItemsSource = new List<Contact> {
				new Contact { Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" },
				new Contact { Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!" }
			};
		}
	}
}

