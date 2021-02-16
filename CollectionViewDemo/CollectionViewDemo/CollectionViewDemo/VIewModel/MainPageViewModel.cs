using CollectionViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionViewDemo.VIewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Product> products { get; set; }

        public MainPageViewModel()
        {
            products = new ObservableCollection<Product>
            {
                new Product
                {
                    name="Leche",
                    Price = 60.0m,
                    Image ="dog.jpg",
                    HasOffer=false

                },
                new Product
                {
                    name="Yogurt",
                    Price = 30,
                    Image ="imgM.gif",
                    HasOffer=false
                },
                 new Product
                 {
                    name="Pan tostao",
                    Price = 35.6m,
                    Image ="homero.JPG",
                    HasOffer=true,
                    OfferPrice=45.6m

                  },
                  new Product
                  {
                    name="Galleta",
                    Price = 30.7m,
                    Image ="miauasies.JPG",
                    HasOffer=false

                   },
                   new Product
                {
                    name="Leche",
                    Price = 60.0m,
                    Image ="dog.jpg",
                    HasOffer=false

                },
                new Product
                {
                    name="Yogurt",
                    Price = 30,
                    Image ="imgM.gif",
                    HasOffer=false
                },
                 new Product
                 {
                    name="Pan tostao",
                    Price = 35.6m,
                    Image ="homero.JPG",
                    HasOffer=true,
                    OfferPrice=45.6m

                  },
                  new Product
                  {
                    name="Galleta",
                    Price = 30.7m,
                    Image ="miauasies.JPG",
                    HasOffer=false

                   },
                   new Product
                {
                    name="Leche",
                    Price = 60.0m,
                    Image ="dog.jpg",
                    HasOffer=false

                },
                new Product
                {
                    name="Yogurt",
                    Price = 30,
                    Image ="imgM.gif",
                    HasOffer=false
                },
                 new Product
                 {
                    name="Pan tostao",
                    Price = 35.6m,
                    Image ="homero.JPG",
                    HasOffer=true,
                    OfferPrice=45.6m

                  },
                  new Product
                  {
                    name="Galleta",
                    Price = 30.7m,
                    Image ="miauasies.JPG",
                    HasOffer=false

                   }
            };
        }



    }
}
