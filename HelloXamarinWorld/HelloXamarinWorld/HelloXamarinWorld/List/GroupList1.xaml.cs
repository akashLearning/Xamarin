using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarinWorld.List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupList1 : ContentPage
    {
        string selectedName ="";
        ObservableCollection<Profile> list = new ObservableCollection<Profile>()
        {
            new Profile(){ Name = "Akash", Status = "Hey there..!!", PictureUrl = "https://i.picsum.photos/id/1004/100/100.jpg" },
            new Profile(){ Name = "Aakash", Status = "Hieee..!!", PictureUrl = "https://i.picsum.photos/id/1018/100/100.jpg" },
            new Profile(){ Name = "Abhishek", Status = "Hey there..!!", PictureUrl = "https://i.picsum.photos/id/1023/100/100.jpg" },
            new Profile(){ Name = "Abhjit", Status = "Hieee.. abhi!!", PictureUrl = "https://i.picsum.photos/id/1018/100/100.jpg" },
        };
        public GroupList1()
        {
            InitializeComponent();
            lst_BasicList.ItemsSource = list;
        }

        private void lst_BasicList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            selectedName = (e.SelectedItem as Profile)?.Name;
            //DisplayAlert("Selected", (e.SelectedItem as Profile).Name, "Close");
            //if((e.SelectedItem as Profile)?.Name == selectedName)
            //{
            //    lst_BasicList.SelectedItem = null;
            //}
        }

        private void lst_BasicList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //DisplayAlert("taPPERD", (e.Item as Profile).Name, "Close");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            
        }
        private void Delete_Clicked(object sender, EventArgs e)
        {
            list.Remove((sender as MenuItem).CommandParameter as Profile);
        }
    }
}