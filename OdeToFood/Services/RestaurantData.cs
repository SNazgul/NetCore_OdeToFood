using OdeToFood.Entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace OdeToFood.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
    }


    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _restaurants;


        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant(){Id=1, Name="Tersiguel's"},
                new Restaurant(){Id=2, Name="LJ's and the Kat"},
                new Restaurant(){Id=3, Name="King's Contrivance"}
            };
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}
