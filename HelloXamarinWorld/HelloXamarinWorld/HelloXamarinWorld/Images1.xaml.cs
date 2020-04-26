using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarinWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Images1 : ContentPage
    {
        int count;
        public Images1()
        {
            InitializeComponent();
            imgRes.Source = ImageSource.FromResource("HelloXamarinWorld.Resources.Images.lapi.jpg");
        }

        private void imgRes_Clicked(object sender, EventArgs e)
        {

            lbl_Text.Text = count++.ToString();
        }
    }
}