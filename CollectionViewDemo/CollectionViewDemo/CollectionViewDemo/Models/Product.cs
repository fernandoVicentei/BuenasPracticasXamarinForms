using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionViewDemo.Models
{
    public class Product
    {
        public string name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public bool HasOffer { get; set; }
        public decimal OfferPrice { get; set; }
    }
}
