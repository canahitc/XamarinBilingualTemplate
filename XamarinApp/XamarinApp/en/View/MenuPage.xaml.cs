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
	public partial class MenuPage : ContentPage
	{
        SearchBar searchBar = null;
        public MenuPage ()
		{
            InitializeComponent();           
            BindingContext = new VillaViewModel();
        }
        // ON CLICKING HUMBURGER BUTTON MENU IS SHOWN
        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        //ON CLICKING AN ITEM IN THE MENU LIST, REDIRECTING TO NEXT PAGE
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {           

            var item = e.SelectedItem as MenuModel;
            if (item == null)
                return;

            var page = (ContentView)Activator.CreateInstance(item.TargetType);           
            navigationDrawer.ContentView = page;

            navigationDrawer.ToggleDrawer();
        }

        //LIST VIEW FILTER
        #region ************SEARCH**********
        private void filterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchBar = (sender as SearchBar);
            if (listView1.DataSource != null)
            {
                this.listView1.DataSource.Filter = FilterContacts;
                this.listView1.DataSource.RefreshFilter();
            }
        }
        private bool FilterContacts(object obj)
        {
            if (searchBar == null || searchBar.Text == null)
                return true;

            var contacts = obj as VillaModel;
            if (contacts.rate.ToLower().Contains(searchBar.Text.ToLower())
                 || contacts.rate.ToLower().Contains(searchBar.Text.ToLower()))
                return true;
            else
                return false;
        }
        #endregion
    }
}