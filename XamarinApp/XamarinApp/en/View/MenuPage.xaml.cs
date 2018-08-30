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
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (sender is Button)
            {
                if ((sender as Button).Text == "Page 1")
                {
                    this.Navigation.PushAsync(new Page1(), true);

                }
                else if ((sender as Button).Text != "Page 2")
                {
                    navigationDrawer.IsOpen = false;
                }

            }
        }
        // ON CLICKING HUMBURGER BUTTON MENU IS SHOWN
        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        //ON CLICKING AN ITEM IN THE MENU LIST, REDIRECTING TO NEXT PAGE
        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {                      
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