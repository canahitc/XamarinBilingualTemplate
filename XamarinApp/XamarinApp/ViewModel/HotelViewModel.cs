using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinApp.Model;
using XamarinApp.Services;

namespace XamarinApp.ViewModel
{
    class HotelViewModel : ViewModelBase
    {
        #region *****INITIALIZING********
        HotelServices services;
        public ObservableCollection<MenuModel> MenuItems { get; set; }

        private List<VillaModel> villaList;
        public List<VillaModel> list
        {
            get { return villaList; }
            set { SetProperty(ref villaList, value); }
        }

        #endregion

        //BINDING THE LIST VIEW AND MENU ITEMS
        public HotelViewModel()
        {
            services = new HotelServices();
            list = services.GetHotelList();

            MenuItems = new ObservableCollection<MenuModel>(new[]
            {
                    new MenuModel { Id = 0, Title = "Page 1", TargetType= typeof(en.View.Page1) },
                    new MenuModel { Id = 0, Title = "Page 2", TargetType= typeof(en.View.Page2) },


                });
        }

    }
}
