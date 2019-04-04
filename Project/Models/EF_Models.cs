using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class EF_Models
    {
        //API 1
        public class Login
        {
            [Key]
            public string UserID { get; set; }
            public string FirstName { get; set; }
            public string  LastName { get; set; }
            public string Email { get; set; }
        }

        //API 2
        public class Company
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            
        }

       /* //API 3
        public class C3
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }

        //API 4
        public class Financials
        {
            [Key]
            public string cashFlow { get; set; }
            public string symbol { get; set; }
            public string grossProfit { get; set; }
            public string totalRevenue { get; set; }
            public string netIncome { get; set; }
            public string totalDebt { get; set; }
            public string totalAssets { get; set; }
            public string totalLiabilities { get; set; }
            public string currentCash { get; set; }
            public string currentDebt { get; set; }
            public string totalCash { get; set; }
            public string costOfRevenue { get; set; }

        }

        //API 5
        public class Dividend
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }*/
    }
}

