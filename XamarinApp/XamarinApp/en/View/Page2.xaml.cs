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
	public partial class Page2 : ContentPage
    {
        SearchBar searchBar = null;
        public Page2 ()
		{
			InitializeComponent ();
            BindingContext = new ApartmentViewModel();
        }
        private void hamburgerButton_Clicked(object sender, EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        private void listView1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {            
            navigationDrawer.ToggleDrawer();
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
                    this.Navigation.PushAsync(new Page2(), true);
                    //navigationDrawer.IsOpen = false;
                }

            }
        }
        //LIST VIEW FILTER
        #region ************SEARCH**********
        private void filterText_TextChanged(object sender, TextChangedEventArgs e)
        {
            searchBar = (sender as SearchBar);
            if (listView.DataSource != null)
            {
                this.listView.DataSource.Filter = FilterContacts;
                this.listView.DataSource.RefreshFilter();
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