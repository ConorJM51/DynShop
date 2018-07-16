﻿using Rocket.API;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DynShop
{
    public class DefaultValues : IDefaultable
    {
        public int FileVersion = 0;
        [XmlArray("Items"), XmlArrayItem(ElementName = "Item")]
        public List<ShopItem> Items = new List<ShopItem>();

        [XmlArray("Vehicles"), XmlArrayItem(ElementName = "Vehicle")]
        public List<ShopVehicle> Vehicles = new List<ShopVehicle>();

        public void LoadDefaults()
        {
            Items.Add(new ShopItem(2, 2, .5m, .5m, .01m));
            Vehicles.Add(new ShopVehicle(1, 397));
        }
    }
}