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
    public partial class ProfileDetailPage : ContentPage
    {
        public ProfileDetailPage(Profile profile)
        {
            if (profile == null)
            {
                throw new ArgumentNullException();
            }
            BindingContext = profile;
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}