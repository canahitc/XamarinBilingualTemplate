using System;
using System.Collections.Generic;
using System.Text;
using XamarinApp.Model;

namespace XamarinApp.Services
{
    public class ApartmentServices
    {
        public List<VillaModel> GetApartmentList()
        {
            List<VillaModel> villalist = new List<VillaModel>()
           {
               new VillaModel()
               {
                   image = "appartment1.jpg",
                   rate = "175,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment2.jpg",
                   rate = "360,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment3.jpg",
                   rate = "160,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment4.jpg",
                   rate = "165,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment5.jpg",
                   rate = "170,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment1.jpg",
                   rate = "180,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment2.jpg",
                   rate = "185,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment3.jpg",
                   rate = "150,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment4.jpg",
                   rate = "190,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
               new VillaModel()
               {
                   image = "appartment5.jpg",
                   rate = "110,000 AED/year",
                   address = "Cedre Villas, Dubai Silicon Oasis, Dubai"
               },
           };
            return villalist;
        }
    }
}
