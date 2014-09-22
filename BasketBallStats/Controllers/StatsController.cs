using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasketBallStats.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace BasketBallStats.Controllers
{
    public class StatsController : Controller
    {
        public ActionResult Index()
        {
           // StatsVm statsVm= new StatsVm(){Players =  GetPlayers()};
            var settings = new JsonSerializerSettings {ContractResolver = new CamelCasePropertyNamesContractResolver()};

            return View("Index", "", JsonConvert.SerializeObject(GetPlayers(), settings));
        }

        private IEnumerable<Player> GetPlayers()
        {
            yield return new Player(){Name = "Парфенчук", Number = 23, Points = 0};
            yield return new Player(){Name = "Давыдов", Number = 54, Points = 0};
            yield return new Player() { Name = "Мулык", Number = 25, Points = 0 };
            yield return new Player() { Name = "Безверхий", Number = 3, Points = 0};
            yield return new Player() { Name = "Ирокез", Number = 13, Points = 0 };
        }
    }
}
