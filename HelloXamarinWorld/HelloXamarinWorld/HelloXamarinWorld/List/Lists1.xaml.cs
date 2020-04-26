using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarinWorld.List
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lists1 : ContentPage
    {
        public Lists1()
        {
            InitializeComponent();

            lst_BasicList.ItemsSource = new List<Profile>()
            {
                new Profile(){ Name = "Akash", Status = "Hey there..!!", PictureUrl = "https://i.picsum.photos/id/1004/100/100.jpg" },
                //new Profile(){ Name = "Aakash", Status = "Hieee..!!", ProfilePictureUrl = "https://i.picsum.photos/id/1018/100/100.jpg" },
                new Profile(){ Name = "Abhishek", Status = "Hey Abhishek..!!", PictureUrl = "https://i.picsum.photos/id/1023/100/100.jpg" },
            };
        }
    }
}