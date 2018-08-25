using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApp.Model;
using XamarinApp.ViewModel;

namespace XamarinApp.en.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentView
    {
		public Page2 ()
		{
			InitializeComponent ();
            BindingContext = new VillaViewModel();
        }
        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MenuModel;
            if (item == null)
                return;

            var page = (ContentView)Activator.CreateInstance(item.TargetType);           
            navigationDrawer.ContentView = page;

            navigationDrawer.ToggleDrawer();
        }
    }
}