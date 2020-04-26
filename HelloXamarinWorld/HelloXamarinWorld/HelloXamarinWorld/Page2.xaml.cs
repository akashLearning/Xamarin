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
    public partial class Page2 : ContentPage
    {
        public string[] quotes { get; } = new string[]
        {
            "Learn to build native mobile apps for Android, iOS and Windows using your existing C# skills",
            "Build a simple app for browsing a list of quotes.",
            "Create a new page called QuotesPage.",
            "Use set this page as the main page in App.cs:",
            "Use 20 units padding for the page (20",
            "units on all sides). You can set this",
            "directly in the ContentPage element:"
        };
        int index;
        public Page2()
        {
            InitializeComponent();
            txt.Text = quotes[index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index = (index + 1) % quotes.Length;
            txt.Text = quotes[index];
        }
    }
}