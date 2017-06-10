using OdeToFood.Entities;
using System;
using System.Collections.Generic;

namespace OdeToFood.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public String CurrentGreeting { get; set; }
    }
}
