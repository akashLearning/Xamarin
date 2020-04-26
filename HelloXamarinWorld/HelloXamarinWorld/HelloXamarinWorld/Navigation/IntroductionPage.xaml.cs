using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloXamarinWorld.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}