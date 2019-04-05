using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static Project.Models.EF_Models;
using Project.Models;
// ADD THESE DIRECTIVES
using Project.DataAccess;
using Newtonsoft.Json;
using System.Net.Http;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        /*
            These lines are needed to use the Database context,
            define the connection to the API, and use the
            HttpClient to request data from the API
        */
        public ApplicationDbContext dbContext;
        //Base URL for the IEXTrading API. Method specific URLs are appended to this base URL.
        string BASE_URL = "https://api.iextrading.com/1.0/";
        HttpClient httpClient;

        /*
             These lines create a Constructor for the HomeController.
             Then, the Database context is defined in a variable.
             Then, an instance of the HttpClient is created.

        */
        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;

            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new
                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        /*
            Calls the IEX reference API to get the list of symbols.
            Returns a list of the companies whose information is available. 
        */
        
      /*
        public List<C1> GetSymbols()
        {
            string IEXTrading_API_PATH = BASE_URL + "ref-data/symbols";
            string companyList = "";
            List<C1> companies = null;

            // connect to the IEXTrading API and retrieve information
            httpClient.BaseAddress = new Uri(IEXTrading_API_PATH);
            HttpResponseMessage response = httpClient.GetAsync(IEXTrading_API_PATH).GetAwaiter().GetResult();

            // read the Json objects in the API response
            if (response.IsSuccessStatusCode)
            {
                companyList = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }

            // now, parse the Json strings as C# objects
            if (!companyList.Equals(""))
            {
                // https://stackoverflow.com/a/46280739
                companies = JsonConvert.DeserializeObject<List<C1>>(companyList);
                companies = companies.GetRange(0, 50);
            }

            return companies;
        }
        public IActionResult Index()
        {
            //Set ViewBag variable first
            ViewBag.dbSuccessComp = 0;
            List<C1> companies = GetSymbols();

            //Save companies in TempData, so they do not have to be retrieved again
            TempData["Companies"] = JsonConvert.SerializeObject(companies);

            return View(companies);
        }

        
        //    The Symbols action calls the GetSymbols method that returns a list of Companies.
          //  This list of Companies is passed to the Symbols View.
        
        public IActionResult Symbols()
        {
            //Set ViewBag variable first
            ViewBag.dbSuccessComp = 0;
            List<Company> companies = GetSymbols();

            //Save companies in TempData, so they do not have to be retrieved again
            TempData["Companies"] = JsonConvert.SerializeObject(companies);

            return View(companies);
        }
       
        
        //    Save the available symbols in the database
        
        public IActionResult PopulateSymbols()
        {
            // Retrieve the companies that were saved in the symbols method
            List<C1> companies = JsonConvert.DeserializeObject<List<C1>>(TempData["Companies"].ToString());

            foreach (C1 company in companies)
            {
                //Database will give PK constraint violation error when trying to insert record with existing PK.
                //So add company only if it doesnt exist, check existence using symbol (PK)
                if (dbContext.Companies.Where(c => c.symbol.Equals(C1.symbol)).Count() == 0)
                {
                    dbContext.Companies.Add(C1);
                }
            }

            dbContext.SaveChanges();
            ViewBag.dbSuccessComp = 1;
            return View("Index", companies);
        }

      */
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
