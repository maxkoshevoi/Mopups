﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Maui.Controls;

using Mopups.Services;

namespace SampleMaui.CSharpMarkup
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BuildContent();

            MopupService.Instance.Pushing += (sender, e) => Debug.WriteLine($"[Popup] Pushing: {e.GetType().Name}");
            MopupService.Instance.Pushed += (sender, e) => Debug.WriteLine($"[Popup] Pushed: {e.GetType().Name}");
            MopupService.Instance.Popping += (sender, e) => Debug.WriteLine($"[Popup] Popping: {e.GetType().Name}");
            MopupService.Instance.Popped += (sender, e) => Debug.WriteLine($"[Popup] Popped: {e.GetType().Name}");
        }

        protected override void OnAppearing()
        { 
        
        }
    }
}
