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
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        //API 2
        public class Company
        {
            [Key]
            public string symbol { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string website { get; set; }
        }
        
        //API 4
        public class Financials
        {
            [Key]
            public decimal cashFlow { get; set; }
            public string symbol { get; set; }
            public decimal grossProfit { get; set; }
            public decimal totalRevenue { get; set; }
            public decimal netIncome { get; set; }
            public decimal totalDebt { get; set; }
            public decimal totalAssets { get; set; }
            public decimal totalLiabilities { get; set; }
            public decimal currentAssets { get; set; }
            public decimal currentCash { get; set; }
            public decimal currentDebt { get; set; }
            public decimal totalCash { get; set; }
            public decimal costOfRevenue { get; set; }
        }

        //API 5
        public class KeyStats
        {
            [Key]
            public string symbol { get; set; }
            public decimal NamedividendRate { get; set; }
            public decimal revenue { get; set; }
            public decimal grossProfit { get; set; }
            public decimal cash { get; set; }
            public decimal debt { get; set; }
            public decimal revenuePerShare { get; set; }
        }
        
    }
}

