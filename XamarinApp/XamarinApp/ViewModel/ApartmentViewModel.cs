using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using XamarinApp.Model;
using XamarinApp.Services;

namespace XamarinApp.ViewModel
{
   public class ApartmentViewModel : ViewModelBase
    {
        #region *****INITIALIZING********
        ApartmentServices services;
        public ObservableCollection<MenuModel> MenuItems { get; set; }

        private List<VillaModel> villaList;
        public List<VillaModel> list
        {
            get { return villaList; }
            set { SetProperty(ref villaList, value); }
        }

        #endregion

        //BINDING THE LIST VIEW AND MENU ITEMS
        public ApartmentViewModel()
        {
            services = new ApartmentServices();
            list = services.GetApartmentList();

            MenuItems = new ObservableCollection<MenuModel>(new[]
            {
                    new MenuModel { Id = 0, Title = "Page 1", TargetType= typeof(en.View.Page1) },
                    new MenuModel { Id = 0, Title = "Page 2", TargetType= typeof(en.View.Page2) },


                });
        }
    }
}
