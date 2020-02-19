﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample2 {
    class GoldWidget : IProduct {
        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();

        }
        public string GetModelName() {
            return Product.GetModelName();
        }

        public GoldWidget() {
            Product = new Product {
                Code = "GW",
                Name = "Gold Widget",
                Model = ModelType.Gold
            };
        }

    }
}
