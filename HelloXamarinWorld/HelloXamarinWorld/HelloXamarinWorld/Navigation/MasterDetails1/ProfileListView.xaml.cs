using HelloXamarinWorld.List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarinWorld.Navigation.MasterDetails1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileListView : ContentPage
    {
        public ProfileListView()
        {
            InitializeComponent();
            lst_Vw.ItemsSource = new List<Profile>
            {
                new Profile{ Name = "Akash", Status = "Hey there..!!", PictureUrl = "https://i.picsum.photos/id/106/2592/1728.jpg" },
                new Profile{ Name = "Aakash", Status = "Hieee..!!", PictureUrl = "https://i.picsum.photos/id/1018/100/100.jpg" },
                new Profile{ Name = "Abhishek", Status = "Hey there..!!", PictureUrl = "https://i.picsum.photos/id/1023/100/100.jpg" },
                new Profile{ Name = "Abhjit", Status = "Hieee.. abhi!!", PictureUrl = "https://i.picsum.photos/id/1018/100/100.jpg" },
            };
        }
        IEnumerable<Profile> GetProfiles(string searchText = null)
        {
            var profiles = new List<Profile>()
            {
                new Profile(){ Name = "Akash", Status = "Hey there..!!", PictureUrl = "https://i.picsum.photos/id/1004/100/100.jpg" },
                new Profile(){ Name = "Aakash", Status = "Hieee..!!", PictureUrl = "https://i.picsum.photos/id/1018/100/100.jpg" },
                new Profile(){ Name = "Abhishek", Status = "Hey there..!!", PictureUrl = "https://i.picsum.photos/id/1023/100/100.jpg" },
                new Profile(){ Name = "Abhjit", Status = "Hieee.. abhi!!", PictureUrl = "https://i.picsum.photos/id/1018/100/100.jpg" },
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return profiles;
            return profiles.Where(pro => pro.Name.ToLower().StartsWith(searchText.ToLower()));
        }

        private async void lst_Vw_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            var profile = e.SelectedItem as Profile;
            await Navigation.PushAsync(new ProfileDetailPage(profile));
            lst_Vw.SelectedItem = null;
        }
    }
}