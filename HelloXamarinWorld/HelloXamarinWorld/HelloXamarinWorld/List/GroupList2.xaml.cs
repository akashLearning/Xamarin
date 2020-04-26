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
    public partial class GroupList2 : ContentPage
    {
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
        public GroupList2()
        {
            InitializeComponent();
            lst_Vw.ItemsSource = GetProfiles();
        }

        private void lst_Vw_Refreshing(object sender, EventArgs e)
        {
            lst_Vw.ItemsSource = GetProfiles();
            lst_Vw.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lst_Vw.ItemsSource = GetProfiles(e.NewTextValue);
        }
    }
}