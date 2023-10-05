using System.Diagnostics;

namespace social_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void LoginButton_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("Clicked !");
        }
    }
}