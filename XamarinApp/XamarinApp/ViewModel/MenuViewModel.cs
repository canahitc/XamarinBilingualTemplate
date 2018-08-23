using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinApp.Model;
using XamarinApp.en.View;

namespace XamarinApp.ViewModel
{
    public class MenuViewModel
    {
        public ObservableCollection<MenuModel> MenuItems { get; set; }
        public List<string> MenuList { get; set; }
        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuModel>(new[]
            {
                    new MenuModel { Id = 0, Title = "Home", TargetType= typeof(DetailsPage) },
                    //new MenuModel { Id = 1, Title = "Villas", TargetType=typeof(Villa) },
                    //new MenuModel { Id = 2, Title = "Apartments", TargetType = typeof(Page2) },                    
                    //new MenuModel { Id = 2, Title = "Commercial Properties" },
                    //new MenuModel { Id = 3, Title = "Residential Units" },
                });
        }
    }
}
