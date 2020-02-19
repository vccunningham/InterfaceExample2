using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample2 {

    public enum ModelType { Bronze, Silver, Gold };
    
    public class Product {
        

        public string Code { get; set; }
        public string Name { get; set; }
        public ModelType Model { get; set; } 
        

        public double GetPrice() {
            return Model switch
            {
                ModelType.Bronze => 20,
                ModelType.Silver => 90,
                ModelType.Gold => 500,
                _ => 0 // everything else
            };


            

            

        }
        public string GetModelName() {
            return Model switch
            {
                ModelType.Bronze => "Bronze Widget",
                ModelType.Silver => "Silver Widget",
                ModelType.Gold => "Gold Widget",
                _ => "Not Found"
            };
        }
        public Product() { 
        
        }

    }
}
