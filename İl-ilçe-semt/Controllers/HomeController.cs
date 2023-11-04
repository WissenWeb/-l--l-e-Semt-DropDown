using İl_ilçe_semt.Models;
using İl_ilçe_semt.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace İl_ilçe_semt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View(new IndexViewModel() { Cities = GetCities() });
        }


        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {


            return View(new IndexViewModel() { Cities = GetCities(), SelectedItem = model.SelectedItem });



        }

        public IActionResult Privacy()
        {
            return View();
        }
        public List<City> GetCities()
        {

            return new List<City>() {

            new City(){ Id = 1, CityName ="İstanbul" },
            new City(){ Id = 2, CityName ="Ankara" },
            new City(){ Id = 3, CityName ="İzmir" },
            new City(){ Id = 4, CityName ="Erzurum" },
            new City(){ Id = 5, CityName ="Muğla" },
            new City(){ Id = 6, CityName ="Kayseri" },
            new City(){ Id = 7, CityName ="Zonguldak" },
            new City(){ Id = 8, CityName ="Van" },



            };

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}