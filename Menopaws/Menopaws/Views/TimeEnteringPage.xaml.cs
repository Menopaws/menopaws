﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menopaws.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TimeEnteringPage : ContentPage
    {
        public TimeEnteringPage()
        {
            InitializeComponent();
            timePicker.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
                {
                    OnTimeSelected(sender, e);
                }
            };
        }

        async void OnDoneButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async void OnTimeSelected(object sender, EventArgs e)
        {
            var timeSelected = timePicker.Time;
        }
    }
}