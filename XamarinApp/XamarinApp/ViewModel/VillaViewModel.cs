using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinApp.en.View;
using XamarinApp.Model;
using XamarinApp.Services;

namespace XamarinApp.ViewModel
{
    public class VillaViewModel : ViewModelBase
    {
        VillaServices services;
        public MenuViewModel menuviewmodel { get; set; }
        public ObservableCollection<MenuModel> MenuItems { get; set; }
        private Command<SfListView> selectionChangedCommand;
        private List<VillaModel> villaList;
        public List<VillaModel> list
        {
            get { return villaList; }
            set { SetProperty(ref villaList, value); }
        }
        public Command<SfListView> SelectionChangedCommand
        {
            get { return selectionChangedCommand; }
            protected set { selectionChangedCommand = value; }
        }
        public VillaViewModel()
        {

            services = new VillaServices();
            list = services.GetVillaList();
            menuviewmodel = new MenuViewModel();
            MenuItems = new ObservableCollection<MenuModel>(new[]
            {
                    new MenuModel { Id = 0, Title = "Details Page", TargetType= typeof(en.View.DetailsPage) },
                    
                    
                });

            selectionChangedCommand = new Command<SfListView>(OnSelectionChanged);
        }
        public void OnSelectionChanged(SfListView listView)
        {
            VillaModel model = new VillaModel();
            var selectedItems = listView.SelectedItems;
            if (selectedItems.Count > 0)
            {

                model = (VillaModel)selectedItems[0];
            }
            //Application.Current.MainPage.Navigation.PushAsync(new DetailsPage());
        }
    }
}
