using Microsoft.AspNetCore.Mvc;
using OdeToFood.ViewModels;
using OdeToFood.Services;
using OdeToFood.Entities;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData ,IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public ViewResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentGreeting = _greeter.GetGreeting();

            //return Content("Hello, from a controller");
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            var restaurant = new Restaurant();
            restaurant.Name = model.Name;
            restaurant.Cuisine = model.Cuisine;

            _restaurantData.Add(restaurant);

            // It is dangerous returns View from POST:
            //  for example try to update page after this view has been received,
            //  data will be send to server twice
            //return View("Details", restaurant);
            //
            // lets redirect
            return RedirectToAction("Details", new { id = restaurant.Id});
        }


        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                //return NotFound();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
