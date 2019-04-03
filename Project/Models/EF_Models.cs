using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class EF_Models
    {
        public class C1
        {
            [Key]
            public string Symbol { get; set; }
            public string Name { get; set; }
            public string Date { get; set; }
        }
    }
}

