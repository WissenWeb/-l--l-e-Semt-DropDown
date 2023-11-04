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


            return View(new IndexViewModel() { Cities = GetCities(), District = new List<District>() });
        }


        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {


            List<District> selectedDistrict = GetDistrict().Where(s => s.CityId == model.SelectedItem).ToList();

            return View(new IndexViewModel() { Cities = GetCities(), District = selectedDistrict, SelectedItem = model.SelectedItem });



            // Semtleri siz yapın


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
            new City(){ Id = 4, CityName ="Kayseri" },
            new City(){ Id = 5, CityName ="Muğla" },

            new City(){ Id = 7, CityName ="Zonguldak" },
            new City(){ Id = 8, CityName ="Van" },


            };

        }
        public List<District> GetDistrict()
        {

            return new List<District>() {


             new District(){ Id=1, Name="Pendik", CityId = 1 },
             new District(){ Id=2, Name="Kartal", CityId = 1 },
             new District(){ Id=3, Name="Tuzla", CityId = 1 },
             new District(){ Id=4, Name="Bala", CityId = 2 },
             new District(){ Id=5, Name="Kızılay", CityId = 2 },
             new District(){ Id=6, Name="Keçiören", CityId = 2 },
             new District(){ Id=7, Name="Alsancak", CityId = 3 },
             new District(){ Id=8, Name="Urla", CityId = 3 },
             new District(){ Id=9, Name="Çeşme", CityId = 3 },
             new District(){ Id=10, Name="Oltu", CityId = 4 },
             new District(){ Id=11, Name="Hınıs", CityId = 4 },
              new District(){ Id=8, Name="Ağırnas", CityId = 5 },
             new District(){ Id=9, Name="Develi", CityId = 5 },
             new District(){ Id=10, Name="Bodrum", CityId = 6 },
             new District(){ Id=11, Name="Fethiye", CityId = 6 },

            };


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}