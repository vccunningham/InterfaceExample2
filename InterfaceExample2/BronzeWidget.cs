using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample2 {
    public class BronzeWidget : IProduct {
        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
            
        }

        public string GetModelName() {
            return Product.GetModelName();
        }

        public BronzeWidget() {
            Product = new Product {
                Code = "BW",
                Name = "Bronze Widget",
                Model = ModelType.Bronze
            };
        }

        
    }
}
