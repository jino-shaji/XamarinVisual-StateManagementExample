using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam_VS_Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        Frame frameSelected;
        public MainPage()
        {
            InitializeComponent();
            VisualStateManager.GoToState(AllNewsTab, "Selected");
            frameSelected = AllNewsTab;
        }
        protected override void OnAppearing()
        {
            VisualStateManager.GoToState(AllNewsTab, "Selected");
            base.OnAppearing();
        }
        private void Tab_Tapped(object sender, EventArgs e)
        {
            if (frameSelected != null)
                VisualStateManager.GoToState(frameSelected, "UnSelected");

            VisualStateManager.GoToState((Frame)sender, "Selected");

            frameSelected = (Frame)sender;
        }
    }
}