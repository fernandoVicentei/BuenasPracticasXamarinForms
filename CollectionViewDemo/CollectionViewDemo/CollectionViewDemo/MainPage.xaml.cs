﻿using CollectionViewDemo.VIewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            /* collection.ItemsSource = new string[]
             {
                 "Buldog","Rock Wailer","Meowth","Rasputin","MimeCat"
             };*/
            BindingContext = new MainPageViewModel();

        }

    }
}
