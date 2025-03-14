﻿using System.ComponentModel;
using ZorkBuilder.Data;

namespace ZorkBuilder.Data
{
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; } 
        public int Weight { get; set; }
    }
}
