﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object
{
    public class Product
    {
        public int code { set; get; }
        public string name { set; get; }
        public string description { set; get; }
        public double price { set; get; }
        public int MinInPrepara { set; get; }
        public int quantity { set; get; }
        public char enabled { set; get; }

        public Product()
        {
        }

        public Product(int code, string name, string description, double price, int minInPrepara, char enabled)
        {
            this.code = code;
            this.name = name;
            this.description = description;
            this.price = price;
            MinInPrepara = minInPrepara;
            this.enabled = enabled;
        }

        public Product(int code, string name, string description, double price, int minInPrepara, int quantity, char enabled)
        {
            this.code = code;
            this.name = name;
            this.description = description;
            this.price = price;
            MinInPrepara = minInPrepara;
            this.quantity = quantity;
            this.enabled = enabled;
        }
    }
}

