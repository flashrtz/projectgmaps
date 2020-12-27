using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projectgmaps.Models;

namespace projectgmaps.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string conString = "Data Source=DESKTOP-DAA2QQ4\\SQLEXPRESS01;Initial Catalog=MapsDB;Integrated Security=True";

        //public List<FarmerLocation> butnclick() {

        //    SqlConnection con = new SqlConnection(conString);
        //    con.Open();

        //    if (con.State == System.Data.ConnectionState.Open)
        //    {
        //        //var dat = con.Farmer_googlemap.T
        //        string q = "SELECT * FROM [dbo].[Farmer_googlemap]";
        //        SqlCommand cmd = new SqlCommand(q, con);
        //        cmd.ExecuteNonQuery();
        //        return cmd;
        //    }
        //    return null;
        //}
        //public IEnumerable<TEntity> GetAll()
        //{
        //    using (var connection = connectionFactory.GetConnection())
        //    {
        //        connection.Open();
        //        return connection.GetAll<TEntity>();
        //    }
        //}


    }
}
